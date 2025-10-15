using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Publicaciones_y_Páginas_de_Facebook
{
    internal class Contenido : Usuarios
    {
        public Contenido() { }

        public Contenido(string usuario, int seguidores, string publicacion, string pagina, string contenidoMultimedia, DateTime fecha, int likes)
            : base(usuario)
        {
            Seguidores = seguidores;
            Publicacion = publicacion;
            Pagina = pagina;
            ContenidoMultimedia = contenidoMultimedia;
            Fecha = fecha;
            Likes = likes;
        }

        public int Seguidores { get; set; }
        public string Publicacion { get; set; }
        public string Pagina { get; set; }
        public string ContenidoMultimedia { get; set; }

        public DateTime Fecha { get; set; }

        public int Likes { get; set; }
    }
}
