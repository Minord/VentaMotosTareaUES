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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void ButtonRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.ShowDialog();
        }
    }
}
