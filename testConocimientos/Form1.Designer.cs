namespace testConocimientos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.picLogotipo = new System.Windows.Forms.PictureBox();
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.cUESTIONARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culturaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cienciasNaturalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matemáticasYLógicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESULTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).BeginInit();
            this.menuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(297, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 44);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TestManía Escolar";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 263);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(842, 190);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = resources.GetString("lblDescripcion.Text");
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogotipo
            // 
            this.picLogotipo.Image = ((System.Drawing.Image)(resources.GetObject("picLogotipo.Image")));
            this.picLogotipo.Location = new System.Drawing.Point(376, 97);
            this.picLogotipo.Name = "picLogotipo";
            this.picLogotipo.Size = new System.Drawing.Size(150, 151);
            this.picLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogotipo.TabIndex = 2;
            this.picLogotipo.TabStop = false;
            // 
            // menuOpciones
            // 
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUESTIONARIOSToolStripMenuItem,
            this.rESULTADOSToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(915, 24);
            this.menuOpciones.TabIndex = 3;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // cUESTIONARIOSToolStripMenuItem
            // 
            this.cUESTIONARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.culturaGeneralToolStripMenuItem,
            this.historiaToolStripMenuItem,
            this.cienciasNaturalesToolStripMenuItem,
            this.matemáticasYLógicaToolStripMenuItem});
            this.cUESTIONARIOSToolStripMenuItem.Name = "cUESTIONARIOSToolStripMenuItem";
            this.cUESTIONARIOSToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.cUESTIONARIOSToolStripMenuItem.Text = "Cuestionarios";
            // 
            // culturaGeneralToolStripMenuItem
            // 
            this.culturaGeneralToolStripMenuItem.Name = "culturaGeneralToolStripMenuItem";
            this.culturaGeneralToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.culturaGeneralToolStripMenuItem.Text = "Cultura General";
            this.culturaGeneralToolStripMenuItem.Click += new System.EventHandler(this.culturaGeneralToolStripMenuItem_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.historiaToolStripMenuItem.Text = "Historia";
            // 
            // cienciasNaturalesToolStripMenuItem
            // 
            this.cienciasNaturalesToolStripMenuItem.Name = "cienciasNaturalesToolStripMenuItem";
            this.cienciasNaturalesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.cienciasNaturalesToolStripMenuItem.Text = "Ciencias Naturales";
            // 
            // matemáticasYLógicaToolStripMenuItem
            // 
            this.matemáticasYLógicaToolStripMenuItem.Name = "matemáticasYLógicaToolStripMenuItem";
            this.matemáticasYLógicaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.matemáticasYLógicaToolStripMenuItem.Text = "Matemáticas y Lógica";
            // 
            // rESULTADOSToolStripMenuItem
            // 
            this.rESULTADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verResultadosToolStripMenuItem});
            this.rESULTADOSToolStripMenuItem.Name = "rESULTADOSToolStripMenuItem";
            this.rESULTADOSToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.rESULTADOSToolStripMenuItem.Text = "Resultados";
            // 
            // verResultadosToolStripMenuItem
            // 
            this.verResultadosToolStripMenuItem.Name = "verResultadosToolStripMenuItem";
            this.verResultadosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verResultadosToolStripMenuItem.Text = "Ver Resultados";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 491);
            this.Controls.Add(this.picLogotipo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "frmPrincipal";
            this.Text = "Conocimiento en Acción";
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipo)).EndInit();
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox picLogotipo;
        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem cUESTIONARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem culturaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cienciasNaturalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matemáticasYLógicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rESULTADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

