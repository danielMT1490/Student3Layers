namespace Student.Presentation.WinSite
{
    partial class AlumnosShowForm
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.textValue = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBoxSelect = new System.Windows.Forms.ComboBox();
            this.formatoConfigOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConfigOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonConfigOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlConfigOption1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlConfigOption1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(82, 126);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(634, 220);
            this.DataGrid.TabIndex = 0;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(590, 59);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(126, 39);
            this.BtnFiltrar.TabIndex = 4;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(82, 69);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(207, 20);
            this.textValue.TabIndex = 9;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(313, 53);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 15;
            this.lblCampo.Text = "Campo";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(79, 53);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(94, 13);
            this.lblValor.TabIndex = 16;
            this.lblValor.Text = "Introduzca el valor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.formatoConfigOption1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroToolStripMenuItem.Text = "Registrar";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // CBoxSelect
            // 
            this.CBoxSelect.FormattingEnabled = true;
            this.CBoxSelect.Items.AddRange(new object[] {
            "Guid",
            "ID",
            "Nombre",
            "Apellidos",
            "Edad",
            "Fecha de Nacimiento",
            "Fecha de Registro"});
            this.CBoxSelect.Location = new System.Drawing.Point(316, 69);
            this.CBoxSelect.Name = "CBoxSelect";
            this.CBoxSelect.Size = new System.Drawing.Size(228, 21);
            this.CBoxSelect.TabIndex = 20;
            // 
            // formatoConfigOption1
            // 
            this.formatoConfigOption1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtConfigOption1,
            this.jsonConfigOption1,
            this.xmlConfigOption1,
            this.sqlConfigOption1});
            this.formatoConfigOption1.Name = "formatoConfigOption1";
            this.formatoConfigOption1.Size = new System.Drawing.Size(64, 20);
            this.formatoConfigOption1.Text = "Formato";
            // 
            // txtConfigOption1
            // 
            this.txtConfigOption1.Name = "txtConfigOption1";
            this.txtConfigOption1.Size = new System.Drawing.Size(180, 22);
            this.txtConfigOption1.Text = "Txt";
            this.txtConfigOption1.Click += new System.EventHandler(this.txtConfigOption1_Click);
            // 
            // jsonConfigOption1
            // 
            this.jsonConfigOption1.Name = "jsonConfigOption1";
            this.jsonConfigOption1.Size = new System.Drawing.Size(180, 22);
            this.jsonConfigOption1.Text = "Json";
            this.jsonConfigOption1.Click += new System.EventHandler(this.jsonConfigOption1_Click);
            // 
            // xmlConfigOption1
            // 
            this.xmlConfigOption1.Name = "xmlConfigOption1";
            this.xmlConfigOption1.Size = new System.Drawing.Size(180, 22);
            this.xmlConfigOption1.Text = "Xml";
            this.xmlConfigOption1.Click += new System.EventHandler(this.xmlConfigOption1_Click);
            // 
            // sqlConfigOption1
            // 
            this.sqlConfigOption1.Name = "sqlConfigOption1";
            this.sqlConfigOption1.Size = new System.Drawing.Size(180, 22);
            this.sqlConfigOption1.Text = "Sql";
            this.sqlConfigOption1.Click += new System.EventHandler(this.sqlConfigOption1_Click);
            // 
            // AlumnosShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 390);
            this.Controls.Add(this.CBoxSelect);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlumnosShowForm";
            this.Text = "AlumnoForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.TextBox textValue;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBoxSelect;
        private System.Windows.Forms.ToolStripMenuItem formatoConfigOption1;
        private System.Windows.Forms.ToolStripMenuItem txtConfigOption1;
        private System.Windows.Forms.ToolStripMenuItem jsonConfigOption1;
        private System.Windows.Forms.ToolStripMenuItem xmlConfigOption1;
        private System.Windows.Forms.ToolStripMenuItem sqlConfigOption1;
    }
}