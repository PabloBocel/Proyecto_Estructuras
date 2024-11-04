using System;
using System.Windows.Forms;
using static Proyecto_Estructuras.AgregarContrasena;

namespace Proyecto_Estructuras
{
    public partial class TbValorNuevo : UserControl
    {
        FormMenu formMenu;
        public CripRSA rsa = new CripRSA();
        public TbValorNuevo(FormMenu formMenu)
        {
            InitializeComponent();
            this.formMenu = formMenu;

            foreach (Control control in this.Controls)
            {
                // Especificar el namespace completo para Button
                if (control is System.Windows.Forms.Button)
                {
                    control.Click += new EventHandler(formMenu.ReiniciarContadorInactividad);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);
            formMenu.Show();
            this.ParentForm.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(TBNuevaContraMaestra.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            // Obtener el nuevo valor de la contraseña maestra
            string nueva = TBNuevaContraMaestra.Text;

            // Actualizar la MasterPassword de la instancia actual de FormMenu
            formMenu.MasterPassword = nueva; // Actualiza la contraseña maestra en FormMenu
            formMenu.AgregarContrasenaForm.MasterPassword = nueva; // Asegúrate de que esta propiedad sea accesible

            // Mostrar mensaje de éxito
            MessageBox.Show("La contraseña maestra se actualizó correctamente.");

            // Limpiar el campo de texto
            TBNuevaContraMaestra.Text = string.Empty; // Establecer el texto a vacío
        }


        private void button2_Click(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);

            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(TBBuscarId.Text) ||
                string.IsNullOrWhiteSpace(TBValorViejo.Text) ||
                string.IsNullOrWhiteSpace(TBNuevoValor.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return; // Salir del método si hay campos vacíos
            }

            // Obtener el ID a buscar
            if (!int.TryParse(TBBuscarId.Text, out int buscarId))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return; // Salir si el ID no es válido
            }

            // Buscar el sitio en el diccionario usando el ID
            if (GlobalData.SitiosData.TryGetValue(buscarId, out var sitio))
            {
                // Definir el nombre del campo que se desea actualizar
                string campoAActualizar = TBValorViejo.Text.ToLower();
                string viejoValor = "";

                // Obtener la propiedad a modificar usando reflexión
                var propertyInfo = typeof(SitioInfo).GetProperty(campoAActualizar,
                                      System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

                // Verificar si la propiedad existe
                if (propertyInfo != null && propertyInfo.CanWrite)
                {
                    // Obtener el valor antiguo del campo
                    viejoValor = propertyInfo.GetValue(sitio)?.ToString() ?? string.Empty;

                    // Verificar si el campo es "contraseña" y, si es así, encriptar el nuevo valor
                    string nuevoValor = TBNuevoValor.Text;
                    if (campoAActualizar.ToLower() == "contrasena")
                    {
                        nuevoValor = rsa.Encriptar(TBNuevoValor.Text); // Encriptar el nuevo valor
                    }

                    // Actualizar el valor del campo
                    propertyInfo.SetValue(sitio, nuevoValor);

                    // Actualizar la fecha de actualización
                    sitio.FechaActualizacion = DateTime.UtcNow;

                    // Mostrar mensaje de éxito con los valores antiguos y nuevos
                    MessageBox.Show($"El campo '{campoAActualizar}' se modificó de '{viejoValor}' a '{propertyInfo.GetValue(sitio)}'.");
                }
                else
                {
                    MessageBox.Show("Campo no válido para actualizar.");
                    return; // Salir si el campo no es válido
                }

                // Limpiar los campos después de la actualización
                TBBuscarId.Text = string.Empty;
                TBNuevoValor.Text = string.Empty;
                TBValorViejo.Text = string.Empty;
                return;
            }

            // Si no se encuentra el ID
            MessageBox.Show($"No se encontró ningún sitio con ID: {buscarId}");
        }




        private void TBNuevaContraMaestra_TextChanged(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);

        }

        private void BTBuscarArchivo_Click(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);
            // Obtener el ID ingresado por el usuario
            if (!int.TryParse(TBEscribirIdBuscar.Text, out int buscarId))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            // Obtener el nombre del campo que se desea buscar y pasarlo a minúsculas
            string campoBuscar = TBBuscarArchivo.Text.ToLower();

            // Buscar el sitio en el diccionario usando el ID
            if (GlobalData.SitiosData.TryGetValue(buscarId, out var sitio))
            {
                // Usar reflexión para obtener la propiedad a buscar
                var propertyInfo = typeof(SitioInfo).GetProperty(campoBuscar,
                                     System.Reflection.BindingFlags.IgnoreCase | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

                // Verificar si la propiedad existe y puede leerse
                if (propertyInfo != null && propertyInfo.CanRead)
                {
                    // Obtener el valor del campo especificado
                    string valorCampo = propertyInfo.GetValue(sitio)?.ToString() ?? "No encontrado";

                    if (campoBuscar.ToLower() == "contrasena")
                    {
                        //Desencriptar contraseña
                        string contraDesencriptada = rsa.Desencriptar(valorCampo);
                        MessageBox.Show($"Valor de '{campoBuscar}' para el ID {buscarId}: {contraDesencriptada}");


                    }
                    else
                    {
                        // Mostrar el resultado al usuario
                        MessageBox.Show($"Valor de '{campoBuscar}' para el ID {buscarId}: {valorCampo}");
                    }


                }
                else
                {
                    MessageBox.Show("Campo no válido. Asegúrate de que el nombre del campo es correcto.");
                }
            }
            else
            {
                MessageBox.Show("ID no encontrado en los datos.");
            }
        }

        private void TBBuscarId_TextChanged(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);

        }

        private void TBValorViejo_TextChanged(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);

        }

        private void TBNuevoValor_TextChanged(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);

        }

        private void TBEscribirIdBuscar_TextChanged(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);

        }

        private void TBBuscarArchivo_TextChanged(object sender, EventArgs e)
        {
            formMenu.ReiniciarContadorInactividad(sender, e);

        }
    }
}
