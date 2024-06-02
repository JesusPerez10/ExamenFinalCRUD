namespace ExamenFinalCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textArtista = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechalanzamiento = new System.Windows.Forms.DateTimePicker();
            this.textAlbum = new System.Windows.Forms.TextBox();
            this.textDuracion = new System.Windows.Forms.TextBox();
            this.textPopularidad = new System.Windows.Forms.TextBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.dataGridViewCanciones = new System.Windows.Forms.DataGridView();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FechaLanzamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duracion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "IDCancion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Popularidad";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(91, 6);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 7;
            // 
            // textArtista
            // 
            this.textArtista.Location = new System.Drawing.Point(467, 6);
            this.textArtista.Name = "textArtista";
            this.textArtista.Size = new System.Drawing.Size(93, 20);
            this.textArtista.TabIndex = 8;
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(269, 6);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(112, 20);
            this.textTitulo.TabIndex = 9;
            // 
            // dateTimePickerFechalanzamiento
            // 
            this.dateTimePickerFechalanzamiento.Location = new System.Drawing.Point(343, 52);
            this.dateTimePickerFechalanzamiento.Name = "dateTimePickerFechalanzamiento";
            this.dateTimePickerFechalanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechalanzamiento.TabIndex = 10;
            // 
            // textAlbum
            // 
            this.textAlbum.Location = new System.Drawing.Point(91, 51);
            this.textAlbum.Name = "textAlbum";
            this.textAlbum.Size = new System.Drawing.Size(84, 20);
            this.textAlbum.TabIndex = 11;
            // 
            // textDuracion
            // 
            this.textDuracion.Location = new System.Drawing.Point(644, 55);
            this.textDuracion.Name = "textDuracion";
            this.textDuracion.Size = new System.Drawing.Size(100, 20);
            this.textDuracion.TabIndex = 12;
            // 
            // textPopularidad
            // 
            this.textPopularidad.Location = new System.Drawing.Point(657, 10);
            this.textPopularidad.Name = "textPopularidad";
            this.textPopularidad.Size = new System.Drawing.Size(100, 20);
            this.textPopularidad.TabIndex = 13;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.Location = new System.Drawing.Point(77, 375);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(114, 50);
            this.buttonInsertar.TabIndex = 14;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = true;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Genero";
            // 
            // textGenero
            // 
            this.textGenero.Location = new System.Drawing.Point(91, 104);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(129, 20);
            this.textGenero.TabIndex = 16;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(213, 375);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(114, 52);
            this.buttonCargar.TabIndex = 17;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // dataGridViewCanciones
            // 
            this.dataGridViewCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCanciones.Location = new System.Drawing.Point(36, 139);
            this.dataGridViewCanciones.Name = "dataGridViewCanciones";
            this.dataGridViewCanciones.Size = new System.Drawing.Size(752, 178);
            this.dataGridViewCanciones.TabIndex = 18;
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(502, 375);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(101, 52);
            this.buttonupdate.TabIndex = 19;
            this.buttonupdate.Text = "Actualizar";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(343, 323);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(139, 25);
            this.buttonbuscar.TabIndex = 20;
            this.buttonbuscar.Text = "Buscar por id";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(634, 375);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(110, 47);
            this.buttoneliminar.TabIndex = 21;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.dataGridViewCanciones);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.textPopularidad);
            this.Controls.Add(this.textDuracion);
            this.Controls.Add(this.textAlbum);
            this.Controls.Add(this.dateTimePickerFechalanzamiento);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.textArtista);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textArtista;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechalanzamiento;
        private System.Windows.Forms.TextBox textAlbum;
        private System.Windows.Forms.TextBox textDuracion;
        private System.Windows.Forms.TextBox textPopularidad;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.DataGridView dataGridViewCanciones;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttoneliminar;
    }
}

