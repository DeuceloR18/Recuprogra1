namespace Sistema_de_peliculas
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.txtTituloo = new System.Windows.Forms.TextBox();
            this.txtGeneroo = new System.Windows.Forms.TextBox();
            this.txtAutorr = new System.Windows.Forms.TextBox();
            this.txtDuracionn = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnActualizarr = new System.Windows.Forms.Button();
            this.btnEliminarr = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.btnEliminarr);
            this.groupBox3.Controls.Add(this.btnActualizarr);
            this.groupBox3.Controls.Add(this.btnnuevo);
            this.groupBox3.Controls.Add(this.txtDuracionn);
            this.groupBox3.Controls.Add(this.txtAutorr);
            this.groupBox3.Controls.Add(this.txtGeneroo);
            this.groupBox3.Controls.Add(this.txtTituloo);
            this.groupBox3.Controls.Add(this.txtidentificacion);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(23, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 288);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Movies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Titulo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Genero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 14);
            this.label8.TabIndex = 3;
            this.label8.Text = "Autor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 14);
            this.label9.TabIndex = 4;
            this.label9.Text = "Duracion";
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(76, 20);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(100, 21);
            this.txtidentificacion.TabIndex = 5;
            // 
            // txtTituloo
            // 
            this.txtTituloo.Location = new System.Drawing.Point(76, 53);
            this.txtTituloo.Name = "txtTituloo";
            this.txtTituloo.Size = new System.Drawing.Size(100, 21);
            this.txtTituloo.TabIndex = 6;
            // 
            // txtGeneroo
            // 
            this.txtGeneroo.Location = new System.Drawing.Point(76, 93);
            this.txtGeneroo.Name = "txtGeneroo";
            this.txtGeneroo.Size = new System.Drawing.Size(100, 21);
            this.txtGeneroo.TabIndex = 7;
            // 
            // txtAutorr
            // 
            this.txtAutorr.Location = new System.Drawing.Point(76, 137);
            this.txtAutorr.Name = "txtAutorr";
            this.txtAutorr.Size = new System.Drawing.Size(100, 21);
            this.txtAutorr.TabIndex = 8;
            // 
            // txtDuracionn
            // 
            this.txtDuracionn.Location = new System.Drawing.Point(76, 175);
            this.txtDuracionn.Name = "txtDuracionn";
            this.txtDuracionn.Size = new System.Drawing.Size(100, 21);
            this.txtDuracionn.TabIndex = 9;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(76, 201);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.Text = "Agregar";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnActualizarr
            // 
            this.btnActualizarr.Location = new System.Drawing.Point(24, 240);
            this.btnActualizarr.Name = "btnActualizarr";
            this.btnActualizarr.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarr.TabIndex = 11;
            this.btnActualizarr.Text = "Modificar";
            this.btnActualizarr.UseVisualStyleBackColor = true;
            // 
            // btnEliminarr
            // 
            this.btnEliminarr.Location = new System.Drawing.Point(133, 240);
            this.btnEliminarr.Name = "btnEliminarr";
            this.btnEliminarr.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarr.TabIndex = 12;
            this.btnEliminarr.Text = "Eliminar";
            this.btnEliminarr.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(214, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(309, 243);
            this.dataGridView2.TabIndex = 13;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(698, 402);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label Titulopelicula;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.Label Duracion;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox txtDuracion5;
        private System.Windows.Forms.TextBox txtAutor4;
        private System.Windows.Forms.TextBox txtGenero3;
        private System.Windows.Forms.TextBox txtTitulo2;
        private System.Windows.Forms.TextBox txtide;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvtotalseries;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnEliminarr;
        private System.Windows.Forms.Button btnActualizarr;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtDuracionn;
        private System.Windows.Forms.TextBox txtAutorr;
        private System.Windows.Forms.TextBox txtGeneroo;
        private System.Windows.Forms.TextBox txtTituloo;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

