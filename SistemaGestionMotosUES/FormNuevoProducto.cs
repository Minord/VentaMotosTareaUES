using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionMotosUES
{
    public partial class FormNuevoProducto : Form
    {
        public FormNuevoProducto()
        {
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
