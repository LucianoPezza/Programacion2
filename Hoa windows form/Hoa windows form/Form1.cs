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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = "¡Hola, Windows Forms!";
            string mensaje = $"Soy:{txtNombre.Text} {txtApellido.Text} Y mi materia favotira es:{cbMateria.Text}";

           
          if(Validar())
            {
                Form2 frmSaludo = new Form2(titulo, mensaje);
                frmSaludo.ShowDialog();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string mat = "Matematica 1,Programacion 1,Laboratorio De Programacion 1,SPD,Ingles 1,Estadistica,Programacion 2,Laboratorio De Programacion 2,Arquitectura de Sistema Operativos,Ingles 2,Metodologia De La Investigacion";
            string[] Materias = mat.Split(',');
            foreach (var materia in Materias)
            {
                cbMateria.Items.Add((string)materia);
            }
            cbMateria.Text = Materias[6];

        }

        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

    }

}
