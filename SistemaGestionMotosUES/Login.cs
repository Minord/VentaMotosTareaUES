using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionMotosUES.Validators;
using SistemaGestionMotosUES.Models;
using SistemaGestionMotosUES.Data;

namespace SistemaGestionMotosUES
{
    public partial class Login : Form
    {
        public bool vendedorFinding = false;
        public Vendedor vendedor_resultado = null;
        public bool encontrado = false;
        public Login()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            buttonCancelar.CausesValidation = false;
            buttonRegistro.CausesValidation = false;
        }

        public bool encontradobool()
        {
            return encontrado;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            //Dispose();
        }

        private void ButtonRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.ShowDialog();
        }

        private void ButtonIniciar_Click(object sender, EventArgs e)
        {
            bool noerrors = true;
            foreach (Control c in this.Controls)
            {
                if (errorProvider.GetError(c).Length > 0)
                    noerrors = false;
            }

            if (noerrors)
            {
                if (Vendedor.revisarExistenciaPorCorreo(textBoxUsuario.Text)) {
                    if (Vendedor.revisarValidezPassword(textBoxUsuario.Text, textBoxPassword.Text)) {

                        string usuario = DataBasePort.user_ID(textBoxUsuario.Text, textBoxPassword.Text);
                        MessageBox.Show("Se ha iniciado seccion al usuario "+usuario+"", "Bienvenido");
                        encontrado = true;
                        this.Dispose();
                    }
                    else {
                        MessageBox.Show("La contraseña no es valida");
                    }
                }
                else
                {
                    MessageBox.Show("El coreo no es valido");
                }

            }
            else
            {
                MessageBox.Show("Tiene que llenar los campos correctamente");
            }
        }


        private void TextBoxUsuario_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Incerte correo Valido";
            string text = textBoxUsuario.Text;
            if (!Validaciones.isEmail(text) || Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxUsuario.Select(0, textBoxUsuario.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxUsuario, errorMsg);
            }
        }

        private void TextBoxUsuario_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxUsuario, "");
        }

        private void TextBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Incerte un correo valido";
            string text = textBoxPassword.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxPassword.Select(0, textBoxPassword.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxPassword, errorMsg);
            }
        }

        private void TextBoxPassword_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxPassword, "");
        }
    }
}
