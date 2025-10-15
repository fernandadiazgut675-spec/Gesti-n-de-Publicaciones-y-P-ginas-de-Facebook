using System;
using System.Collections.Generic;
using System.IO;
using ClosedXML.Excel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gestión_de_Publicaciones_y_Páginas_de_Facebook
{
    internal class Acciones : IAcciones
    {
        List<Usuarios> usuarios = new List<Usuarios>();

        public bool Agregar(string usuario)
        {
            try
            {
                if (usuarios.Any(u => u.Usuario.Equals(usuario, StringComparison.OrdinalIgnoreCase)))
                {
                    return false; // Usuario ya existe
                }
                usuarios.Add(new Usuarios(usuario));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Eliminar(string usuario)
        {
            try
            {
                var usuarioAEliminar = usuarios.FirstOrDefault(u => u.Usuario.Equals(usuario, StringComparison.OrdinalIgnoreCase));
                if (usuarioAEliminar != null)
                {
                    usuarios.Remove(usuarioAEliminar);
                    return true;
                }
                return false; // Usuario no encontrado
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Usuarios> Mostrar()
        {
            return usuarios;
        }

        public bool Actualizar(string usuarioAntiguo, string usuarioNuevo)
        {
            try
            {
                var usuarioAActualizar = usuarios.FirstOrDefault(u => u.Usuario.Equals(usuarioAntiguo, StringComparison.OrdinalIgnoreCase));
                if (usuarioAActualizar != null)
                {
                    if (usuarios.Any(u => u.Usuario.Equals(usuarioNuevo, StringComparison.OrdinalIgnoreCase)))
                    {
                        return false; // El nuevo nombre de usuario ya existe
                    }
                    usuarioAActualizar.Usuario = usuarioNuevo;
                    return true;
                }
                return false; // Usuario no encontrado
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ExportarAExcel(string ruta) // 👈 corregido aquí
        {
            try
            {
                if (usuarios == null || usuarios.Count == 0)
                {
                    Console.WriteLine("No hay usuarios para exportar.");
                    return false;
                }

                if (string.IsNullOrEmpty(ruta))
                    ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "usuarios.xlsx");

                using (var wb = new ClosedXML.Excel.XLWorkbook())
                {
                    var ws = wb.AddWorksheet("Usuarios");

                    // Encabezados
                    ws.Cell(1, 1).Value = "Usuario";

                    // Datos
                    for (int i = 0; i < usuarios.Count; i++)
                    {
                        ws.Cell(i + 2, 1).Value = usuarios[i].Usuario;
                    }

                    // Estilos
                    ws.Row(1).Style.Font.Bold = true;
                    ws.Columns().AdjustToContents();
                    ws.RangeUsed().SetAutoFilter();

                    // Guardar
                    wb.SaveAs(ruta);
                }

                Console.WriteLine($"✅ Archivo exportado correctamente en: {ruta}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al exportar: {ex.Message}");
                return false;
            }
        }
    }
}
