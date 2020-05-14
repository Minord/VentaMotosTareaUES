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
    }
}
