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


namespace SistemaGestionMotosUES
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            textBoxContraseña.PasswordChar = '*';
            textBoxRepContraseña.PasswordChar = '*';

        }
        private void TextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Incerte un correo valido";
            string text = textBoxNombre.Text;
            if (!(Validaciones.notContainsNumbers(text) && !Validaciones.isEmply(text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxNombre.Select(0, textBoxNombre.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxNombre, errorMsg);
            }
        }

        private void TextBoxNombre_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxNombre, "");
        }

        private void TextBoxTelefono_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Porfavor incerte un numero valido con el formato ####-####";
            string text = textBoxTelefono.Text;
            if (!(!Validaciones.isEmply(text) && Validaciones.isTelefone(text)))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxNombre.Select(0, textBoxNombre.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxNombre, errorMsg);
            }
        }

        private void TextBoxTelefono_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxTelefono, "");
        }

        private void TextBoxCorreo_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "error";
            if (!Validaciones.isEmail(textBoxCorreo.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxCorreo.Select(0, textBoxCorreo.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxCorreo, errorMsg);
            }
        }

        private void TextBoxCorreo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxCorreo, "");
        }

        private void TextBoxContraseña_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "No puede estar vacio";
            if (Validaciones.isEmply(textBoxContraseña.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxContraseña.Select(0, textBoxContraseña.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxContraseña, errorMsg);
            }
        }
        private void TextBoxContraseña_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxContraseña, "");
        }
        private void TextBoxRepContraseña_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Las contraseñas tienen que coinsidir";
            if (!(textBoxContraseña.Text == textBoxRepContraseña.Text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxRepContraseña.Select(0, textBoxRepContraseña.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(textBoxRepContraseña, errorMsg);
            }
        }

        private void TextBoxRepContraseña_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxRepContraseña, "");
        }

        private void DateTimePickerNacimiento_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "tiene que seleccionar un fecha";
            if (dateTimePickerNacimiento.Text.Length == 0)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider.SetError(dateTimePickerNacimiento, errorMsg);
            }
        }

        private void DateTimePickerNacimiento_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(dateTimePickerNacimiento, "");
        }

        private void ButtonRegistro_Click(object sender, EventArgs e)
        {
            bool noerrors = true;
            foreach (Control c in this.Controls)
            {
                if (errorProvider.GetError(c).Length > 0)
                    noerrors = false;
            }

            if (noerrors) {
                string nombre = textBoxNombre.Text;
                DateTime fechaNacimento = dateTimePickerNacimiento.Value;
                string correo = textBoxCorreo.Text;
                string telefono = textBoxTelefono.Text;
                string password = textBoxContraseña.Text;

                Vendedor vendedor = new Vendedor(nombre, fechaNacimento, correo, telefono, "", password);

                vendedor.registrarVendedorDb();
                MessageBox.Show("Vendedor Registrado");
            }
            else {
                MessageBox.Show("Tiene que llenar el formulario correctamente");
            }
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
