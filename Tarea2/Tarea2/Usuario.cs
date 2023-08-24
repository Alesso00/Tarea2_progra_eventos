using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    public enum EstadoUsuario
    {
        Activo,
        Inactivo,
        Expulsado,
        Suspendido
    }

    public class Usuario
    {
        public string Nombre { get; set; }
        public EstadoUsuario Estado { get; set; }
    }
}