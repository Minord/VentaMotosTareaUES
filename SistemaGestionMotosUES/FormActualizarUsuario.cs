using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionMotosUES.Models;
using SistemaGestionMotosUES.Validators;

namespace SistemaGestionMotosUES
{
    public partial class FormActualizarUsuario : Form
    {
        public FormActualizarUsuario(Vendedor vendedor)
        {
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ButtonActualizar_Click(object sender, EventArgs e)
        {
            if (validar(this))
            {
                //string nombre = textBoxNombre.Text;
                //DateTime fechaNacimento = dateTimePickerNacimiento.Value;
                //string correo = textBoxCorreo.Text;
                //string telefono = textBoxTelefono.Text;
                //string password = textBoxPassword.Text;

                //Vendedor vendedor = new Vendedor(nombre, fechaNacimento, correo, telefono, "", password);

                //vendedor.registrarVendedorDb();
                //MessageBox.Show("Vendedor Registrado");
            }
        }

        //*********************************************************
        //Apartir de aqui solo hay validadores, ignorar lo de abajo
        //*********************************************************


        //Metodo necesario para forzar el cierre del formulario cuando el boton cancelar tengo el foco
        public void cancelador(CancelEventArgs e)
        {
            if (buttonCancelar.ContainsFocus)
            {
                e.Cancel = false;
            }
        }

        //Metodo que retorna un valor booleano que permite saber si algun TextBox esta o no vacio
        private bool validar(Form formulario)
        {
            bool vacio = false; // Variable utilizada para saber si hay algún TextBox vacio.
            // Buscamos en cada TextBox de nuestro Formulario.
            foreach (Control oControls in formulario.Controls)
            {
                // Verificamos que no este vacio.
                if (oControls is TextBox & oControls.Text == String.Empty)
                {
                    // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                    vacio = true;
                }
            }
            // Si nuestra variable es verdadera mostramos un mensaje.
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos.");

            return !vacio;
        }

        private void TextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Inserte un nombre valido sin numeros";
            string text = textBoxNombre.Text;
            if (!(Validaciones.notContainsNumbers(text) && !Validaciones.isEmply(text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxNombre.Select(0, textBoxNombre.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxNombre, errorMsg);
                cancelador(e);
            }
        }

        private void textBoxNombre_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxNombre, "");
        }

        private void textBoxTelefono_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Porfavor incerte un numero valido con el formato ########";
            string text = textBoxTelefono.Text;
            if (!(Validaciones.isEmply(text) || Validaciones.isTelefone(text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxTelefono.Select(0, textBoxTelefono.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxTelefono, errorMsg);
                cancelador(e);
            }
        }

        private void textBoxTelefono_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxTelefono, "");
        }

        private void textBoxCorreo_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Debe introducir un correo de la forma: ejemplo@";
            if (!Validaciones.isEmail(textBoxCorreo.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxCorreo.Select(0, textBoxCorreo.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxCorreo, errorMsg);
                cancelador(e);
            }
        }

        private void textBoxCorreo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxCorreo, "");
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "No puede estar vacio";
            if (Validaciones.isEmply(textBoxPassword.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxPassword.Select(0, textBoxPassword.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxPassword, errorMsg);
                cancelador(e);
            }
        }

        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxPassword, "");
        }

        private void textBoxRepPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Las contraseñas tienen que coincidir";
            if (!(textBoxPassword.Text == textBoxRepPassword.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxRepPassword.Select(0, textBoxRepPassword.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxRepPassword, errorMsg);
                cancelador(e);
            }
        }

        private void textBoxRepPassword_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxRepPassword, "");
        }

        private void dateTimePickerNacimiento_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Tiene que seleccionar un fecha";
            if (dateTimePickerNacimiento.Text.Length == 0)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(dateTimePickerNacimiento, errorMsg);
                cancelador(e);
            }
        }

        private void dateTimePickerNacimiento_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(dateTimePickerNacimiento, "");
        }
    }
}
