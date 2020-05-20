using System;
using System.Collections.Generic;
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
        private string nombre { get; }
        private DateTime fechaNacimento { get; set; }
        private string correo { get; set; }
        private string telefono { get; set; }
        private string direccion { get; set; }
        private string password { get; set; }

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

        public static Vendedor getVendedorPorId() {
            return null;
        }

        public static int getIdByName() {
            return -1;
        }

        public void registrarVendedorDb() {
            string query_text = "INSERT INTO Vendedores (nombre, fecha_nacimiento, telefono, correo, direccion, contraseña) VALUES (" +
                $"'{nombre}'" +
                $"'{fechaNacimento.ToString()}'" +
                $"'{telefono}'" +
                $"'{correo}'" +
                $"'{direccion}'" +
                $"'{password}');";
            vendedor_id = DataBasePort.insertarDatos(query_text);
        }

        public void actualizarVendedorDb() {
            string query_text = "UPDATE Vendedores SET" +
                $"nombre = '{nombre}'," +
                $" fecha_nacimiento = '{fechaNacimento.ToString()}'," +
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
            DataBasePort.actualizarDatos($"UPDATE Motos SET stock = (stock -1) WHERE moto_id = {moto_id}");
        }
    }
}
