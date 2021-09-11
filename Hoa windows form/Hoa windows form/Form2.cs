using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoa_windows_form
{
    public partial class Form2 : Form
    {
        public Form2(string titulo, string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            lblTitulo.Text = titulo;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
