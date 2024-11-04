using System;
using System.Windows.Forms;

namespace Proyecto_Estructuras
{
    public partial class Preguntas : UserControl
    {
        public event Action<string, string, string> DatosCompletados;
        private Form3 form3;

        public Preguntas(Form3 form3)
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
            if (string.IsNullOrWhiteSpace(TBNombreMascota.Text) ||
                string.IsNullOrWhiteSpace(TBColorFav.Text) ||
                string.IsNullOrWhiteSpace(TBNombrePapa.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            DatosCompletados?.Invoke(TBNombreMascota.Text, TBColorFav.Text, TBNombrePapa.Text);
            this.Hide();
            form3.Hide();
        }


        private void TBNombreMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNombrePapa_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBColorFav_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
