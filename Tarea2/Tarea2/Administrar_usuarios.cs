using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2;

namespace Tarea2
{
    public partial class Administrar_usuarios : Form
    {
        private Administrador administrador;
        public Administrar_usuarios()
        {
            InitializeComponent();

            administrador = new Administrador();
           
            administrador.NuevoUsuarioAgregado += NuevoUsuarioAgregadoHandler;
            administrador.UsuarioEliminado += UsuarioEliminadoHandler;
        } // Agrega esta línea fuera del método
        private List<Usuario> listaUsuarios = new List<Usuario>();
       // Manejador de evento para un nuevo usuario agregado
        private void NuevoUsuarioAgregadoHandler(Usuario usuario)
        {
            listaUsuarios.Add(usuario); // Agrega el usuario a la lista
            listBoxUsuarios.Items.Add($"{usuario.Nombre} - {usuario.Estado}");
            MessageBox.Show($"Nuevo usuario agregado: {usuario.Nombre}");
        }
        // Manejador de evento para un usuario eliminado
        private void UsuarioEliminadoHandler(Usuario usuario)
        {
            listaUsuarios.Remove(usuario); // Remover la instancia del usuario de la lista
            listBoxUsuarios.Items.Remove($"{usuario.Nombre} - {usuario.Estado}");
            MessageBox.Show($"Usuario {usuario.Nombre} eliminado");
        }

        private void BotonSuspender_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null)
            {
                string nombreEstadoSeleccionado = listBoxUsuarios.SelectedItem.ToString();
                string[] partes = nombreEstadoSeleccionado.Split('-');

                if (partes.Length == 2)
                {
                    string nombreSeleccionado = partes[0].Trim();
                    Usuario usuarioSeleccionado = listaUsuarios.FirstOrDefault(u => u.Nombre == nombreSeleccionado);

                    if (usuarioSeleccionado != null)
                    {
                        DialogResult result = MessageBox.Show($"¿Estás seguro de suspender al usuario {usuarioSeleccionado.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            usuarioSeleccionado.Estado = EstadoUsuario.Suspendido; // Cambiar el estado a Suspendido
                            listBoxUsuarios.Items.Remove(nombreEstadoSeleccionado);
                            listBoxUsuarios.Items.Add($"{usuarioSeleccionado.Nombre} - {usuarioSeleccionado.Estado}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado en la lista.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario de la lista.");
            }
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null)
            {
                string nombreEstadoSeleccionado = listBoxUsuarios.SelectedItem.ToString();
                string[] partes = nombreEstadoSeleccionado.Split('-');

                if (partes.Length == 2)
                {
                    string nombreSeleccionado = partes[0].Trim();
                    Usuario usuarioSeleccionado = listaUsuarios.FirstOrDefault(u => u.Nombre == nombreSeleccionado);

                    if (usuarioSeleccionado != null)
                    {
                        string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el nuevo nombre:", "Editar Usuario", usuarioSeleccionado.Nombre);
                        if (!string.IsNullOrWhiteSpace(nuevoNombre))
                        {
                            usuarioSeleccionado.Nombre = nuevoNombre;
                            listBoxUsuarios.Items.Remove(nombreEstadoSeleccionado);
                            listBoxUsuarios.Items.Add($"{usuarioSeleccionado.Nombre} - {usuarioSeleccionado.Estado}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado en la lista.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario de la lista.");
            }
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (listBoxUsuarios.SelectedItem != null)
            {
                string nombreEstadoSeleccionado = listBoxUsuarios.SelectedItem.ToString();
                string[] partes = nombreEstadoSeleccionado.Split('-');

                if (partes.Length == 2)
                {
                    string nombreSeleccionado = partes[0].Trim();
                    Usuario usuarioSeleccionado = listaUsuarios.FirstOrDefault(u => u.Nombre == nombreSeleccionado);

                    if (usuarioSeleccionado != null)
                    {
                        DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar al usuario {usuarioSeleccionado.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            administrador.SuspendExpulsarUsuario(usuarioSeleccionado);

                            listaUsuarios.Remove(usuarioSeleccionado);
                            listBoxUsuarios.Items.Remove(nombreEstadoSeleccionado);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado en la lista.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario de la lista.");
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del usuario no puede estar en blanco.");
                return;
            }

            Usuario nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Estado = EstadoUsuario.Activo
            };

            administrador.AgregarUsuario(nuevoUsuario);

            txtNombre.Clear();
        }
    }
}
