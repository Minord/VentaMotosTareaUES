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
    public partial class FormVenta : Form
    {

        private Vendedor vendedor;
        private Moto moto;

        public FormVenta(Vendedor vendedor, Moto moto)
        {
            InitializeComponent();
            this.vendedor = vendedor;
            this.moto = moto;

            textBoxNombreVendedor.Text = vendedor.nombre;
            textBoxPrecioMoto.Text = moto.price.ToString("C");
            textBoxIVA.Text = (moto.price*0.13f).ToString("C");
            textBoxTotal.Text = (moto.price * 1.13f).ToString("C");
            textBoxNombreMoto.Text = moto.nombre;

            buttonCancelar.CausesValidation = false;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void ButtonComprar_Click(object sender, EventArgs e)
        {
            bool noerrors = true;
            foreach (Control c in this.Controls)
            {
                if (errorProvider.GetError(c).Length > 0)
                    noerrors = false;
            }

            if (noerrors)
            {
                vendedor.realizarVenta(moto, textBoxNombreCliente.Text, textBoxNumTarjeta.Text, comboBox2.Text);
                MessageBox.Show("Compra realizada");
            }
            else
            {
                MessageBox.Show("Tiene que llenar los campos correctamente");
            }
        }

        private void TextBoxNombreCliente_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Error Vacio";
            string text = textBoxNombreCliente.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxNombreCliente.Select(0, textBoxNombreCliente.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxNombreCliente, errorMsg);
            }
        }

        private void TextBoxNombreCliente_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxNombreCliente, "");
        }

        private void TextBoxNumTarjeta_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(textBoxNumTarjeta, "");
        }

        private void TextBoxNumTarjeta_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "Error Vacio";
            string text = textBoxNumTarjeta.Text;
            if (Validaciones.isEmply(text))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                textBoxNumTarjeta.Select(0, textBoxNumTarjeta.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider.SetError(textBoxNumTarjeta, errorMsg);
            }
        }
    }
}
