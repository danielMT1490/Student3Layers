namespace Student.Presentation.WinSite
{
    partial class AlumnosForm
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
            this.textId = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDateBron = new System.Windows.Forms.Label();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptionCast = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptionCat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOptionIng = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.txtConfigOption = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonConfigOption = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlConfigOption = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlConfigOption = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(188, 44);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(40, 20);
            this.textId.TabIndex = 3;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(188, 80);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(242, 20);
            this.textNombre.TabIndex = 4;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(188, 117);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(242, 20);
            this.textApellido.TabIndex = 5;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(188, 153);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(242, 20);
            this.textDni.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(57, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(49, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellidos";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(57, 160);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "Dni";
            // 
            // lblDateBron
            // 
            this.lblDateBron.AutoSize = true;
            this.lblDateBron.Location = new System.Drawing.Point(57, 199);
            this.lblDateBron.Name = "lblDateBron";
            this.lblDateBron.Size = new System.Drawing.Size(108, 13);
            this.lblDateBron.TabIndex = 11;
            this.lblDateBron.Text = "Fecha de Nacimiento";
            // 
            // dateBorn
            // 
            this.dateBorn.Location = new System.Drawing.Point(188, 193);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(236, 20);
            this.dateBorn.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.idiomaToolStripMenuItem,
            this.formatoConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegistro});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // MenuRegistro
            // 
            this.MenuRegistro.Name = "MenuRegistro";
            this.MenuRegistro.Size = new System.Drawing.Size(98, 22);
            this.MenuRegistro.Text = "Lista";
            this.MenuRegistro.Click += new System.EventHandler(this.MenuRegistro_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOptionCast,
            this.MenuOptionCat,
            this.MenuOptionIng});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // MenuOptionCast
            // 
            this.MenuOptionCast.Name = "MenuOptionCast";
            this.MenuOptionCast.Size = new System.Drawing.Size(129, 22);
            this.MenuOptionCast.Text = "Castellano";
            this.MenuOptionCast.Click += new System.EventHandler(this.MenuOptionCast_Click);
            // 
            // MenuOptionCat
            // 
            this.MenuOptionCat.Name = "MenuOptionCat";
            this.MenuOptionCat.Size = new System.Drawing.Size(129, 22);
            this.MenuOptionCat.Text = "Catalán";
            this.MenuOptionCat.Click += new System.EventHandler(this.MenuOptionCat_Click);
            // 
            // MenuOptionIng
            // 
            this.MenuOptionIng.Name = "MenuOptionIng";
            this.MenuOptionIng.Size = new System.Drawing.Size(129, 22);
            this.MenuOptionIng.Text = "Inglés";
            this.MenuOptionIng.Click += new System.EventHandler(this.MenuOptionIng_Click);
            // 
            // formatoConfig
            // 
            this.formatoConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtConfigOption,
            this.jsonConfigOption,
            this.xmlConfigOption,
            this.sqlConfigOption});
            this.formatoConfig.Name = "formatoConfig";
            this.formatoConfig.Size = new System.Drawing.Size(64, 20);
            this.formatoConfig.Text = "Formato";
            // 
            // txtConfigOption
            // 
            this.txtConfigOption.Name = "txtConfigOption";
            this.txtConfigOption.Size = new System.Drawing.Size(97, 22);
            this.txtConfigOption.Text = "Txt";
            this.txtConfigOption.Click += new System.EventHandler(this.txtConfigOption_Click);
            // 
            // jsonConfigOption
            // 
            this.jsonConfigOption.Name = "jsonConfigOption";
            this.jsonConfigOption.Size = new System.Drawing.Size(97, 22);
            this.jsonConfigOption.Text = "Json";
            this.jsonConfigOption.Click += new System.EventHandler(this.jsonConfigOption_Click);
            // 
            // xmlConfigOption
            // 
            this.xmlConfigOption.Name = "xmlConfigOption";
            this.xmlConfigOption.Size = new System.Drawing.Size(97, 22);
            this.xmlConfigOption.Text = "Xml";
            this.xmlConfigOption.Click += new System.EventHandler(this.xmlConfigOption_Click);
            // 
            // sqlConfigOption
            // 
            this.sqlConfigOption.Name = "sqlConfigOption";
            this.sqlConfigOption.Size = new System.Drawing.Size(97, 22);
            this.sqlConfigOption.Text = "Sql";
            this.sqlConfigOption.Click += new System.EventHandler(this.sqlConfigOption_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(225, 277);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 58);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Añadir";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AlumnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dateBorn);
            this.Controls.Add(this.lblDateBron);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlumnosForm";
            this.Text = "AlumnosShowForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDateBron;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuRegistro;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOptionCast;
        private System.Windows.Forms.ToolStripMenuItem MenuOptionCat;
        private System.Windows.Forms.ToolStripMenuItem MenuOptionIng;
        private System.Windows.Forms.ToolStripMenuItem formatoConfig;
        private System.Windows.Forms.ToolStripMenuItem txtConfigOption;
        private System.Windows.Forms.ToolStripMenuItem jsonConfigOption;
        private System.Windows.Forms.ToolStripMenuItem xmlConfigOption;
        private System.Windows.Forms.ToolStripMenuItem sqlConfigOption;
        private System.Windows.Forms.Button BtnAdd;
    }
}