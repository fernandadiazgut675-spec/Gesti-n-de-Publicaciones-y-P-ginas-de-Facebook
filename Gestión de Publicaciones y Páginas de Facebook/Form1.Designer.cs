namespace Gestión_de_Publicaciones_y_Páginas_de_Facebook
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ActualizarGrid = new System.Windows.Forms.DataGridView();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtseguidores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpagina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcontenido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlike = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnexportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActualizarGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO ";
            // 
            // ActualizarGrid
            // 
            this.ActualizarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActualizarGrid.Location = new System.Drawing.Point(319, 30);
            this.ActualizarGrid.Name = "ActualizarGrid";
            this.ActualizarGrid.RowHeadersWidth = 51;
            this.ActualizarGrid.RowTemplate.Height = 24;
            this.ActualizarGrid.Size = new System.Drawing.Size(469, 269);
            this.ActualizarGrid.TabIndex = 1;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(121, 27);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(181, 22);
            this.txtusuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "SEGUIDORES ";
            // 
            // txtseguidores
            // 
            this.txtseguidores.Location = new System.Drawing.Point(121, 66);
            this.txtseguidores.Name = "txtseguidores";
            this.txtseguidores.Size = new System.Drawing.Size(181, 22);
            this.txtseguidores.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "PAGINA";
            // 
            // txtpagina
            // 
            this.txtpagina.Location = new System.Drawing.Point(121, 107);
            this.txtpagina.Name = "txtpagina";
            this.txtpagina.Size = new System.Drawing.Size(181, 22);
            this.txtpagina.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CONTENIDO ";
            // 
            // txtcontenido
            // 
            this.txtcontenido.Location = new System.Drawing.Point(121, 138);
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(181, 22);
            this.txtcontenido.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "FECHA ";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(121, 167);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(181, 22);
            this.txtfecha.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "LIKE";
            // 
            // txtlike
            // 
            this.txtlike.Location = new System.Drawing.Point(121, 197);
            this.txtlike.Name = "txtlike";
            this.txtlike.Size = new System.Drawing.Size(181, 22);
            this.txtlike.TabIndex = 12;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 354);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(231, 35);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(0, 0);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 18;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(280, 324);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(231, 35);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(280, 380);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(231, 35);
            this.btnactualizar.TabIndex = 16;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.Location = new System.Drawing.Point(537, 354);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(231, 35);
            this.btnexportar.TabIndex = 17;
            this.btnexportar.Text = "EXAMINAR";
            this.btnexportar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtlike);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpagina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtseguidores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.ActualizarGrid);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ActualizarGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ActualizarGrid;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtseguidores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpagina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcontenido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtlike;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnexportar;
    }
}

