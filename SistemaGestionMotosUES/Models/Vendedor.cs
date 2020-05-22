using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionMotosUES.Data;

namespace SistemaGestionMotosUES.Models
{
    public class Vendedor
    {
        //propiedades
        private int vendedor_id;
        public int Vendedor_id
        {
            get { return vendedor_id; }
        }
        public string nombre { get; }
        public DateTime fechaNacimento { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string password { get; set; }

        public Vendedor(
            string nombre, 
            DateTime fechaNacimento,
            string correo,
            string telefono,
            string direccion,
            string password)
        {
            this.nombre = nombre;
            this.fechaNacimento = fechaNacimento;
            this.correo = correo;
            this.telefono = telefono;
            this.direccion = direccion;
            this.password = password;
        }

        public Vendedor(
            int vendedor_id,
            string nombre,
            DateTime fechaNacimento,
            string correo,
            string telefono,
            string direccion,
            string password)
        {
            this.vendedor_id = vendedor_id;
            this.nombre = nombre;
            this.fechaNacimento = fechaNacimento;
            this.correo = correo;
            this.telefono = telefono;
            this.direccion = direccion;
            this.password = password;
        }

        public static Vendedor getVendedorPorId(string vendedor_id) {
            string query_text = $"SELECT vendedor_id, nombre, CAST(fecha_nacimiento AS text) AS fecha_nacimiento, telefono, correo, direccion, contraseña FROM Vendedores WHERE vendedor_id = '{vendedor_id}';";


            DataTable result = DataBasePort.getTableQuery(query_text);

            if (result.Rows.Count <= 0) {
                return null;
            }
            int id = Int32.Parse(result.Rows[0]["vendedor_id"].ToString());
            string nombre = result.Rows[0]["nombre"].ToString();
            DateTime fechaNacimiento = DateTime.Parse( result.Rows[0]["fecha_nacimiento"].ToString() );
            string telefono = result.Rows[0]["telefono"].ToString();
            string correo = result.Rows[0]["correo"].ToString();
            string direccion =result.Rows[0]["direccion"].ToString();
            string contraseña = result.Rows[0]["contraseña"].ToString();

            Vendedor encontrado = new Vendedor(id, nombre, fechaNacimiento, correo, telefono, direccion, contraseña);


            return encontrado;
        }

        public static int getIdByCorreoAndPassword(string correo, string password) {
            string query_text = $"SELECT vendedor_id FROM Vendedores WHERE correo = '{correo}'AND contraseña = '{password}';";

            int result = (int)DataBasePort.getScalarQuery(query_text);

            return result;
        }

        public static bool revisarExistenciaPorCorreo(string correo) {
            string query_text = $"SELECT 200 FROM Vendedores WHERE correo = '{correo}'";

            int result = (int)DataBasePort.getScalarQuery(query_text);

            return result == 200;
        }

        public static bool revisarValidezPassword(string correo, string password) {
            string query_text = $"SELECT 200 FROM Vendedores WHERE correo = '{correo}' AND contraseña = '{password}'";

            int result = (int)DataBasePort.getScalarQuery(query_text);

            return result == 200;
        }

        public void registrarVendedorDb() {
            string query_text = "INSERT INTO Vendedores (nombre, fecha_nacimiento, telefono, correo, direccion, contraseña) VALUES (" +
                $"'{nombre}'," +
                $"'{fechaNacimento.ToString()}'," +
                $"'{telefono}'," +
                $"'{correo}'," +
                $"'{direccion}'," +
                $"'{password}');";
            vendedor_id = DataBasePort.insertarDatos(query_text);
        }

        public void actualizarVendedorDb() {
            string query_text = "UPDATE Vendedores SET" +
                $"nombre = '{nombre}'," +
                $" fecha_nacimiento = '{fechaNacimento.Date.ToString()}'," +
                $" telefono = '{telefono}'," +
                $" correo = '{correo}'," +
                $" direccion =  '{direccion}'," +
                $" contraseña = '{password}' WHERE" +
                $"vendedor_id = {vendedor_id};";
            DataBasePort.actualizarDatos(query_text);
        }


        public static List<string> getNombresVendedores() {
            string query_text = "SELECT nombre FROM Vendedores;";
            return DataBasePort.getListOfStringQuery(query_text);
        }
        public void realizarVenta(Moto moto, string nombre_cliente, string numero_tarjeta, string metodo_pago) {

            int moto_id = moto.moto_id;
            float moto_precio = moto.price;
            float IVA = moto_precio * 0.15f;
            float Total = moto_precio + IVA;

            string registerQuery = "INSERT INTO Ventas (vendedor_id, moto_id, nombre_cliente, numero_tarjeta, metodo_pago, monto, IVA, Total) VALUES (" +
                $"{vendedor_id}," +
                $"{moto_id}," +
                $"'{nombre_cliente}'," +
                $"'{numero_tarjeta}'," +
                $"'{metodo_pago}'," +
                $"{moto_precio}," +
                $"{IVA}," +
                $"{Total});";

            DataBasePort.insertarDatos(registerQuery);

            //Disminuir el stock
            DataBasePort.actualizarDatos($"UPDATE Motos SET strock = (strock -1) WHERE moto_id = {moto_id}");
        }


    }
}
