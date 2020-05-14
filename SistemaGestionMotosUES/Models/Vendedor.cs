using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionMotosUES.Models
{
    public class Vendedor
    {
        //propiedades
        private int vendedor_id { get;  }
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

        }

        public void actualizarVendedorDb() {

        }

        public void realizarVenta() {
            //TODO: hacer codigo para realizar la venta
        }
    }
}
