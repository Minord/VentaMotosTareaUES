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
    public partial class MainCatalogo : Form
    {

        //Variables

        //Usuario de vendedor
        private Vendedor vendedorActual;


        //Metodos Windows From
        public MainCatalogo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se usara para inicializar los combo box

        }

        private void IniciarSeccionButton_Click(object sender, EventArgs e)
        {
            //Abrir nueva Ventana en El sistema
            Login login = new Login();
            login.ShowDialog();
        }

        private void TextBoxMinPrice_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "El valor de este campo tiene que ser Decimal";


            string text = textBoxMinPrice.Text;
            bool valid = false;
            if (!Validaciones.isEmply(text) && Validaciones.isDecimal(text))
            {
                if (Validaciones.isEmply(textBoxMaxPrice.Text))
                {
                    valid = true;
                }
                else
                {
                    if (!Validaciones.notNegative(text))
                    {
                        valid = false;
                    }
                    else
                    {
                        float min = (float)Convert.ToDouble(text);
                        float max = (float)Convert.ToDouble(textBoxMaxPrice.Text);

                        if (!(max > min))
                        {
                            errorMsg = "El valor maximo es major al maximo";
                            valid = false;
                        }
                        else {
                            valid = true;
                        }
                    }
                }
            }
            else
            {
                valid = true;
                if (!Validaciones.isDecimal(text))
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                e.Cancel = true;

                textBoxMaxPrice.Select(0, textBoxMinPrice.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderMain.SetError(textBoxMinPrice, errorMsg);
            }

        }

        private void TextBoxMaxPrice_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "El valor de este campo tiene que ser Decimal";


            string text = textBoxMaxPrice.Text;
            bool valid = false;
            if (!Validaciones.isEmply(text) && Validaciones.isDecimal(text))
            {
                if (Validaciones.isEmply(textBoxMinPrice.Text))
                {
                    valid = true;
                }
                else
                {
                    if (!Validaciones.notNegative(text))
                    {
                        valid = false;
                    }
                    else {
                        float min = (float) Convert.ToDouble(textBoxMinPrice.Text);
                        float max = (float) Convert.ToDouble(text);

                        if (!(max > min)) {
                            errorMsg = "El valor maximo es menor al minimo";
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                }
            }
            else
            {
                valid = true;
                if (!Validaciones.isDecimal(text))
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                e.Cancel = true;

                textBoxMaxPrice.Select(0, textBoxMaxPrice.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProviderMain.SetError(textBoxMaxPrice, errorMsg);
            }
        }

        private void TextBoxMaxPrice_Validated(object sender, EventArgs e)
        {
            errorProviderMain.SetError(textBoxMaxPrice, "");

        }

        private void TextBoxMinPrice_Validated(object sender, EventArgs e)
        {
            errorProviderMain.SetError(textBoxMinPrice, "");
        }

        private void ButtonNuevoProducto_Click(object sender, EventArgs e)
        {
            FormNuevoProducto formNuevoProducto = new FormNuevoProducto();
            formNuevoProducto.Show();
        }

        private void ButtonConfUser_Click(object sender, EventArgs e)
        {
            FormActualizarUsuario fromActualizarUsuario = new FormActualizarUsuario(vendedorActual);
            fromActualizarUsuario.ShowDialog();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonComprar_Click(object sender, EventArgs e)
        {
            //TODO: Poner la variable moto
            FormVenta formVentas = new FormVenta(vendedorActual, null);
            formVentas.ShowDialog();
            
        }
    }
}
