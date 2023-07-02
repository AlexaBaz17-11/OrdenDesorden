namespace OrdenDesorden
{
    partial class Arrays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrays));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPalabraIngresada = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxAgregarPalabra = new System.Windows.Forms.TextBox();
            this.listBoxPalabrasRegistradas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDesordenar = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.textBoxPalabraIngresada);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.textBoxAgregarPalabra);
            this.groupBox1.Controls.Add(this.listBoxPalabrasRegistradas);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("ROG Fonts", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Palabra";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxPalabraIngresada
            // 
            this.textBoxPalabraIngresada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPalabraIngresada.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPalabraIngresada.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPalabraIngresada.Location = new System.Drawing.Point(323, 229);
            this.textBoxPalabraIngresada.Multiline = true;
            this.textBoxPalabraIngresada.Name = "textBoxPalabraIngresada";
            this.textBoxPalabraIngresada.Size = new System.Drawing.Size(176, 68);
            this.textBoxPalabraIngresada.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.LightGray;
            this.buttonAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonAgregar.Location = new System.Drawing.Point(38, 259);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(168, 38);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "REGISTRAR";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxAgregarPalabra
            // 
            this.textBoxAgregarPalabra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxAgregarPalabra.Location = new System.Drawing.Point(38, 178);
            this.textBoxAgregarPalabra.Multiline = true;
            this.textBoxAgregarPalabra.Name = "textBoxAgregarPalabra";
            this.textBoxAgregarPalabra.Size = new System.Drawing.Size(170, 54);
            this.textBoxAgregarPalabra.TabIndex = 0;
            // 
            // listBoxPalabrasRegistradas
            // 
            this.listBoxPalabrasRegistradas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxPalabrasRegistradas.ForeColor = System.Drawing.Color.Black;
            this.listBoxPalabrasRegistradas.FormattingEnabled = true;
            this.listBoxPalabrasRegistradas.ItemHeight = 32;
            this.listBoxPalabrasRegistradas.Location = new System.Drawing.Point(270, 73);
            this.listBoxPalabrasRegistradas.Name = "listBoxPalabrasRegistradas";
            this.listBoxPalabrasRegistradas.Size = new System.Drawing.Size(292, 260);
            this.listBoxPalabrasRegistradas.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttonDesordenar);
            this.groupBox2.Controls.Add(this.buttonOrdenar);
            this.groupBox2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(241, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 399);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Palabra Registrada";
            // 
            // buttonDesordenar
            // 
            this.buttonDesordenar.BackColor = System.Drawing.Color.LightGray;
            this.buttonDesordenar.ForeColor = System.Drawing.Color.Black;
            this.buttonDesordenar.Location = new System.Drawing.Point(168, 329);
            this.buttonDesordenar.Name = "buttonDesordenar";
            this.buttonDesordenar.Size = new System.Drawing.Size(181, 38);
            this.buttonDesordenar.TabIndex = 4;
            this.buttonDesordenar.Text = "DESORDENAR";
            this.buttonDesordenar.UseVisualStyleBackColor = false;
            this.buttonDesordenar.Click += new System.EventHandler(this.buttonDesordenar_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.BackColor = System.Drawing.Color.LightGray;
            this.buttonOrdenar.ForeColor = System.Drawing.Color.Black;
            this.buttonOrdenar.Location = new System.Drawing.Point(16, 329);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(136, 38);
            this.buttonOrdenar.TabIndex = 3;
            this.buttonOrdenar.Text = "ORDENAR";
            this.buttonOrdenar.UseVisualStyleBackColor = false;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // Arrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(685, 495);
            this.Controls.Add(this.groupBox1);
            this.Name = "Arrays";
            this.Text = "Arrays";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPalabrasRegistradas;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxAgregarPalabra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDesordenar;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.TextBox textBoxPalabraIngresada;
    }
}

