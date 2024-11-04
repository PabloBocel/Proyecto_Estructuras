﻿using System;
using System.Windows.Forms;

namespace Proyecto_Estructuras
{
    public partial class Form1 : Form
    {
        public string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si el campo de la contraseña está vacío
            if (string.IsNullOrWhiteSpace(TBContraMaestra.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return; // Salir de la función si la contraseña no es válida
            }

            string password = TBContraMaestra.Text; // Obtener la contraseña

            // Crear una instancia de FormMenu
            FormMenu formMenu = new FormMenu();
            formMenu.MasterPassword = password; // Asignar la contraseña maestra

            // Ahora puedes crear la instancia de AgregarContrasena que usará el formMenu ya creado
            formMenu.AgregarContrasenaForm.MasterPassword = password; // También asignar aquí si es necesario

            this.Hide(); // Cerrar Form1
            formMenu.Show(); // Mostrar FormMenu
        }

    }

}
