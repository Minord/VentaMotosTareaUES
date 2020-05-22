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

namespace SistemaGestionMotosUES
{
    public partial class FormNuevoProducto : Form
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
            buttonCancelar.CausesValidation = false;

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

        }

        private void TextBoxNombre_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxNombre, "");
        }

        private void TextBoxNombre_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Error Vacio";
            string text = textBoxNombre.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxNombre.Select(0, textBoxNombre.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxNombre, errorMsg);
            }
        }

        private void TextBoxDescripcion_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxDescripcion, "");
        }

        private void TextBoxDescripcion_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Error Vacio";
            string text = textBoxDescripcion.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxDescripcion.Select(0, textBoxDescripcion.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxDescripcion, errorMsg);
            }
        }

        private void TextBoxMarca_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxMarca, "");
        }

        private void TextBoxMarca_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Error Vacio";
            string text = textBoxMarca.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxMarca.Select(0, textBoxMarca.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxMarca, errorMsg);
            }
        }

        private void TextBoxModelo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxModelo, "");
        }

        private void TextBoxModelo_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Error Vacio";
            string text = textBoxModelo.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxModelo.Select(0, textBoxModelo.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxModelo, errorMsg);
            }
        }

        private void TextBoxColor_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxColor, "");
        }

        private void TextBoxColor_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Error Vacio";
            string text = textBoxColor.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxColor.Select(0, textBoxColor.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxColor, errorMsg);
            }
        }

        private void TextBoxTipo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxTipo, "");
        }

        private void TextBoxTipo_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Error Vacio";
            string text = textBoxTipo.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxTipo.Select(0, textBoxTipo.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxTipo, errorMsg);
            }
        }

        private void TextBoxPrecio_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxPrecio, "");
        }

        private void TextBoxPrecio_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Tiene que ser un decimal";
            string text = textBoxPrecio.Text;
            if (!Validaciones.isDecimal(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxPrecio.Select(0, textBoxPrecio.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxPrecio, errorMsg);
            }
        }

        private void TextBoxStock_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxStock, "");
        }

        private void TextBoxStock_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Tine que ser numero";
            string text = textBoxStock.Text;
            if (!Validaciones.isNumber(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxStock.Select(0, textBoxStock.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxStock, errorMsg);
            }
        }

        private void ButtonRegistrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
