using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public class Administrador
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public event Action<Usuario> NuevoUsuarioAgregado;
        public event Action<Usuario> UsuarioEliminado;
        

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
            NuevoUsuarioAgregado?.Invoke(usuario);
        }

        public void SuspendExpulsarUsuario(Usuario usuario)
        {
            usuario.Estado = EstadoUsuario.Suspendido;
            UsuarioEliminado?.Invoke(usuario);
        }

        // Otros métodos para eliminar, editar y obtener usuarios
    }
}