using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Publicaciones_y_Páginas_de_Facebook
{
    internal class Usuarios
    {

        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Seguidores { get; set; }
        public string Pagina { get; set; }
        public string Contenido { get; set; }
        public string Like { get; set; }

        public Usuarios() { }

        public Usuarios(string nombre, string usuario, string seguidores, string pagina, string contenido, string like)
        {
            Nombre = nombre;
            Usuario = usuario;
            Seguidores = seguidores;
            Pagina = pagina;
            Contenido = contenido;
            Like = like;
        }
    }
}
