using System.Windows.Forms;

namespace Proyecto_Estructuras
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void LoadUserControl(UserControl userControl)
        {
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
        }
    }
}
