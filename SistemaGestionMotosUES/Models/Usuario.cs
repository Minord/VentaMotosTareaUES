using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionMotosUES.Models
{
    public class Usuario
    {

        private int ID;
        private string nombre;
        private string contraseña;
        private string logeado;

        public Usuario()
        {

        }

        /// <summary>
        /// Este metodo sirve para obtener un usuario registrado en el sistema
        /// si el usuario existe y la contraseña es valida
        /// </summary>
        /// <param name="usuario">nombre de usuario</param>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        public Usuario getUsuarioPorCredenciales(string usuario, string contraseña) {
            return null;
        }

        /// <summary>
        /// Este metodo registra en la base de datos el usuario que se
        /// contiene en esta clase
        /// </summary>
        public void registrarUsuario() {

        }



    }
}
