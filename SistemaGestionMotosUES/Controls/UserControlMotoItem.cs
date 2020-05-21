using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionMotosUES.Models;

namespace SistemaGestionMotosUES.Controls
{
    public partial class UserControlMotoItem : UserControl
    {

        public Moto moto;
        public Vendedor vendedor;

        public UserControlMotoItem(Moto moto, Vendedor vendedor)
        {
            InitializeComponent();
            this.moto = moto;
            this.vendedor = vendedor;
            labelMarco.Text = moto.marca;
            labelYear.Text = moto.year.ToString();
            labelColor.Text = moto.color;
            labelTipo.Text = moto.tipo;
            labelPrecio.Text = moto.price.ToString("C");
            textBoxDescripcion.Text = moto.descripcion;
        }

        private void ButtonComprar_Click(object sender, EventArgs e)
        {
            //TODO: Lanzar formulario de venta.
        }
    }
}
