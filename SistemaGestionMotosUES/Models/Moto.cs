using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionMotosUES.Data;

namespace SistemaGestionMotosUES.Models
{
    public class Moto
    {
        public int moto_id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }
        public string marca { get; set; }
        public int year { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public string tipo { get; set; }
        public float price { get; set; }
        public int stock { get; set; }


        /// <summary>
        /// Este es el constructor de el objeto crea objetos que no estar registrados
        /// en la base de datos por lo tanto no tienen asignados un id
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="marca"></param>
        /// <param name="year"></param>
        /// <param name="modelo"></param>
        /// <param name="tipo"></param>
        /// <param name="color"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        public Moto(
            string nombre,
            string descripcion,
            string marca,
            int year,
            string modelo,
            string tipo,
            string color,
            float price,
            int stock) {

            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
            this.year = year;
            this.modelo = modelo;
            this.tipo = tipo;
            this.color = color;
            this.price = price;
            this.stock = stock;
        }

        public Moto(
           int moto_id,
           string nombre,
           string descripcion,
           string marca,
           int year,
           string modelo,
           string tipo,
           string color,
           float price,
           int stock)
        {
            this.moto_id = moto_id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
            this.year = year;
            this.modelo = modelo;
            this.tipo = tipo;
            this.color = color;
            this.price = price;
            this.stock = stock;
        }

        /// <summary>
        /// Este motodo devuelve una lista de Motos los cuales son resultado de una busqueda en la base de datos
        /// </summary>
        /// <param name="marca">marca comercial de la motocicleta</param>
        /// <param name="year">año de fabricacion</param>
        /// <param name="tipo">tipo de moto deportiva, comercial, etc</param>
        /// <param name="color">colo general de la moto</param>
        /// <param name="min_price">precio minimo de busqueda</param>
        /// <param name="max_price">precio maxiomo de budqueda</param>
        /// <returns></returns>
        public static List<Moto> motosPorCriterios(
            string marca, 
            int year, 
            string tipo, 
            string color, 
            float min_price, 
            float max_price)
        {
            string queryTemplate = "SELECT * FROM Motos WHERE " +
                $"marca = {marca} AND " +
                $"year = {year} AND" +
                $"tipo = {tipo} AND" +
                $"color = {color} AND" +
                "stock > 0 AND" +
                $"precio BETWEEN {min_price} AND {max_price};";

            return null;
        }

        public static List<Moto> getTodasMotoDB() {
            string queryTemplate = "SELECT moto_id, nombre, descripcion, marca, year, modelo,color, tipo, precio, strock FROM Motos;";

            DataTable tableMotos = DataBasePort.getTableQuery(queryTemplate);
            List<Moto> result = new List<Moto>();

            foreach (DataRow row in tableMotos.Rows) {

                int motoId = Int32.Parse(row["moto_id"].ToString());
                string nombre = row["nombre"].ToString();
                string descripcion = row["descripcion"].ToString();
                string marca = row["marca"].ToString(); 
                int year = Int32.Parse(row["year"].ToString());
                string modelo = row["modelo"].ToString();
                string tipo = row["tipo"].ToString();
                string color = row["color"].ToString();
                float price = float.Parse(row["precio"].ToString());
                int stock = Int32.Parse(row["strock"].ToString());


                Moto moto = new Moto(motoId, nombre, descripcion, marca, year, modelo, tipo, color, price, stock);

                result.Add(moto);
            }

            return result;
        }

        public void registrarMotoDB() {
            string query_register = "INSERT INTO Motos (nombre, descripcion, marca, year, modelo,color, tipo, precio, strock) VALUES (" +
                $"'{nombre}'," +
                $"'{descripcion}'," +
                $"'{marca}'," +
                $"{year}," +
                $"'{modelo}'," +
                $"'{color}'," +
                $"'{tipo}'," +
                $"{price}," +
                $"{stock});";

            moto_id = DataBasePort.insertarDatos(query_register);
        }
    }
}
