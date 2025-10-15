using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Publicaciones_y_Páginas_de_Facebook
{
    internal class Usuarios
    {
        public Usuarios(string usuario)
        {
            Usuario = usuario;
        }

        public string Usuario { get; set; }
        public Usuarios() { }
    }
}
