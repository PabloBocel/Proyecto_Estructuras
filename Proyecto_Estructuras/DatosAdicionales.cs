using System;
using System.Windows.Forms;

namespace Proyecto_Estructuras
{
    public partial class DatosAdicionales : UserControl
    {
        private Form3 form3;

        public DatosAdicionales(Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validacion de campos vacios
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }


        }
    }
}
