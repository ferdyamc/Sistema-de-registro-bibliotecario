
namespace Sistema_de_registro_bibliotecario
{
    partial class FrmInterno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLibro = new System.Windows.Forms.Label();
            this.TxtLibro = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.LblAutor = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBuscarLibro = new System.Windows.Forms.Button();
            this.TxtBuscarLibro = new System.Windows.Forms.TextBox();
            this.TxtBuscarAutor = new System.Windows.Forms.TextBox();
            this.BtnBuscarAutor = new System.Windows.Forms.Button();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.LblUbicacion = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DtgLibros = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.EpvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLibros)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpvError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 50);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sistema_de_registro_bibliotecario.Properties.Resources.dspace_logo_only;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 502);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 50);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Casper", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(426, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desarrollado por Andrés Carvajal ®  2022";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LblLibro
            // 
            this.LblLibro.AutoSize = true;
            this.LblLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLibro.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblLibro.Location = new System.Drawing.Point(54, 214);
            this.LblLibro.Name = "LblLibro";
            this.LblLibro.Size = new System.Drawing.Size(55, 17);
            this.LblLibro.TabIndex = 12;
            this.LblLibro.Text = "Libro :";
            // 
            // TxtLibro
            // 
            this.TxtLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibro.Location = new System.Drawing.Point(145, 214);
            this.TxtLibro.Name = "TxtLibro";
            this.TxtLibro.Size = new System.Drawing.Size(218, 23);
            this.TxtLibro.TabIndex = 13;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAutor.Location = new System.Drawing.Point(145, 252);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(218, 23);
            this.TxtAutor.TabIndex = 15;
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblAutor.Location = new System.Drawing.Point(54, 255);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(57, 17);
            this.LblAutor.TabIndex = 14;
            this.LblAutor.Text = "Autor :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.TxtBuscarAutor);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.BtnBuscarLibro);
            this.panel5.Controls.Add(this.TxtBuscarLibro);
            this.panel5.Controls.Add(this.BtnBuscarAutor);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1042, 38);
            this.panel5.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.MidnightBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.MaximumSize = new System.Drawing.Size(300, 38);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.label14.Size = new System.Drawing.Size(274, 38);
            this.label14.TabIndex = 20;
            this.label14.Text = "Consultar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(312, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Libro :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSlateGray;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(692, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Autor :";
            // 
            // BtnBuscarLibro
            // 
            this.BtnBuscarLibro.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnBuscarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarLibro.FlatAppearance.BorderSize = 0;
            this.BtnBuscarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarLibro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarLibro.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarLibro.Location = new System.Drawing.Point(580, 10);
            this.BtnBuscarLibro.Name = "BtnBuscarLibro";
            this.BtnBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarLibro.TabIndex = 18;
            this.BtnBuscarLibro.Text = "Buscar";
            this.BtnBuscarLibro.UseVisualStyleBackColor = false;
            this.BtnBuscarLibro.Click += new System.EventHandler(this.BtnBuscarLibro_Click);
            // 
            // TxtBuscarLibro
            // 
            this.TxtBuscarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarLibro.Location = new System.Drawing.Point(373, 9);
            this.TxtBuscarLibro.Name = "TxtBuscarLibro";
            this.TxtBuscarLibro.Size = new System.Drawing.Size(201, 23);
            this.TxtBuscarLibro.TabIndex = 15;
            // 
            // TxtBuscarAutor
            // 
            this.TxtBuscarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarAutor.Location = new System.Drawing.Point(748, 10);
            this.TxtBuscarAutor.Name = "TxtBuscarAutor";
            this.TxtBuscarAutor.Size = new System.Drawing.Size(201, 23);
            this.TxtBuscarAutor.TabIndex = 17;
            // 
            // BtnBuscarAutor
            // 
            this.BtnBuscarAutor.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnBuscarAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarAutor.FlatAppearance.BorderSize = 0;
            this.BtnBuscarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAutor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarAutor.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarAutor.Location = new System.Drawing.Point(955, 9);
            this.BtnBuscarAutor.Name = "BtnBuscarAutor";
            this.BtnBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarAutor.TabIndex = 19;
            this.BtnBuscarAutor.Text = "Buscar";
            this.BtnBuscarAutor.UseVisualStyleBackColor = false;
            this.BtnBuscarAutor.Click += new System.EventHandler(this.BtnBuscarAutor_Click);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblCantidad.Location = new System.Drawing.Point(54, 337);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(82, 17);
            this.LblCantidad.TabIndex = 27;
            this.LblCantidad.Text = "Cantidad :";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(145, 334);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(218, 23);
            this.TxtCantidad.TabIndex = 28;
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUbicacion.Location = new System.Drawing.Point(145, 291);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(218, 23);
            this.TxtUbicacion.TabIndex = 26;
            // 
            // LblUbicacion
            // 
            this.LblUbicacion.AutoSize = true;
            this.LblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUbicacion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LblUbicacion.Location = new System.Drawing.Point(54, 294);
            this.LblUbicacion.Name = "LblUbicacion";
            this.LblUbicacion.Size = new System.Drawing.Size(89, 17);
            this.LblUbicacion.TabIndex = 25;
            this.LblUbicacion.Text = "Ubicación :";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.Green;
            this.BtnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(145, 396);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(218, 23);
            this.BtnRegistrar.TabIndex = 34;
            this.BtnRegistrar.Text = "Registrar Libro";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(52, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 26);
            this.label7.TabIndex = 35;
            this.label7.Text = "Inventario de Libros";
            // 
            // DtgLibros
            // 
            this.DtgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgLibros.Location = new System.Drawing.Point(414, 211);
            this.DtgLibros.Name = "DtgLibros";
            this.DtgLibros.Size = new System.Drawing.Size(498, 143);
            this.DtgLibros.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 100);
            this.panel1.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 278);
            this.panel6.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1042, 39);
            this.panel4.TabIndex = 29;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkRed;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(145, 444);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(218, 23);
            this.BtnSalir.TabIndex = 37;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // EpvError
            // 
            this.EpvError.ContainerControl = this;
            // 
            // FrmInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1042, 552);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DtgLibros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.LblLibro);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TxtLibro);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LblUbicacion);
            this.Controls.Add(this.TxtUbicacion);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FrmInterno";
            this.Text = "Interno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLibros)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EpvError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblLibro;
        private System.Windows.Forms.TextBox TxtLibro;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label LblUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBuscarLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBuscarAutor;
        private System.Windows.Forms.Button BtnBuscarLibro;
        private System.Windows.Forms.Button BtnBuscarAutor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DtgLibros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ErrorProvider EpvError;
    }
}