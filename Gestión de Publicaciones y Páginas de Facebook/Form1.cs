using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_de_Publicaciones_y_Páginas_de_Facebook
{
    public partial class Form1 : Form
    {
        Acciones acciones = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
          acciones.Agregar(txtusuario.Text, txtseguidores.Text, txtpagina.Text, txtcontenido.Text, txtfecha.Text, txtlike.Text);
            ActualizarGrid.DataSource = acciones.Mostrar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            acciones.Eliminar(txtusuario.Text);
        }

        
private void btnactualizar_Click(object sender, EventArgs e)
         { 
            acciones.Actualizar(txtusuario.Text, txtseguidores.Text, txtpagina.Text, txtcontenido.Text, txtfecha.Text, txtlike.Text);
        }
    }
    }

