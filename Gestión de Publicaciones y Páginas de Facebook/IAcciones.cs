using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_Publicaciones_y_Páginas_de_Facebook
{
    internal interface IAcciones
    {
        List<Usuarios> Mostrar();

       
          bool Agregar(string usuario);
         bool Eliminar(string usuario);
            bool Actualizar(string usuarioAntiguo, string usuarioNuevo);

        bool ExportarAExcel(string ruta);



    }
}
