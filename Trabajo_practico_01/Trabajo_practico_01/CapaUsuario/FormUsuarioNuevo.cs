using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trabajo_practico_01.CapaUsuario
{
    public partial class FormUsuarioNuevo : Form
    {
        public FormUsuarioNuevo()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nuevoUser = txtNuevoUsuario.Text.Trim();
            string nuevaPass = txtNuevaPass.Text.Trim();
            string confirmarPass = txtConfirmarPass.Text.Trim();

          // 2. Validación: Que no haya campos vacíos (Requisito del TP)
            if (string.IsNullOrEmpty(nuevoUser) || string.IsNullOrEmpty(nuevaPass) || string.IsNullOrEmpty(confirmarPass))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validación: Que las contraseñas coincidan (Requisito del TP)
            if (nuevaPass != confirmarPass)
            {
                MessageBox.Show("Las contraseñas no coinciden. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        
            CapaDatos.Usuario usuarioNegocio = new CapaDatos.Usuario();

            try
            {
                // 5. Validación: Evitar usuarios duplicados (Requisito del TP) 
                if (usuarioNegocio.ExisteUsuario(nuevoUser))
                {
                    MessageBox.Show("El nombre de usuario ya está registrado. Elija otro.", "Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 6. Intentar insertar el nuevo usuario en SQL 
                if (usuarioNegocio.InsertarUsuario(nuevoUser, nuevaPass))
                {
                    
                    MessageBox.Show("¡Usuario registrado con éxito!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 7. Limpiar los campos (Requisito del TP) 
                    txtNuevoUsuario.Clear();
                    txtNuevaPass.Clear();
                    txtConfirmarPass.Clear();

                    this.Close(); // Cierra esta ventana y vuelve a la anterior
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores de conexión 
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

    }
    
}
