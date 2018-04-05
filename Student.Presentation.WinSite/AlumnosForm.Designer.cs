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
            this.BtnTxt = new System.Windows.Forms.Button();
            this.BtnJson = new System.Windows.Forms.Button();
            this.BtnXml = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTxt
            // 
            this.BtnTxt.Location = new System.Drawing.Point(60, 293);
            this.BtnTxt.Name = "BtnTxt";
            this.BtnTxt.Size = new System.Drawing.Size(94, 58);
            this.BtnTxt.TabIndex = 0;
            this.BtnTxt.Text = "Txt";
            this.BtnTxt.UseVisualStyleBackColor = true;
            this.BtnTxt.Click += new System.EventHandler(this.BtnTxt_Click);
            // 
            // BtnJson
            // 
            this.BtnJson.Location = new System.Drawing.Point(237, 293);
            this.BtnJson.Name = "BtnJson";
            this.BtnJson.Size = new System.Drawing.Size(94, 58);
            this.BtnJson.TabIndex = 1;
            this.BtnJson.Text = "Json";
            this.BtnJson.UseVisualStyleBackColor = true;
            this.BtnJson.Click += new System.EventHandler(this.BtnJson_Click);
            // 
            // BtnXml
            // 
            this.BtnXml.Location = new System.Drawing.Point(420, 293);
            this.BtnXml.Name = "BtnXml";
            this.BtnXml.Size = new System.Drawing.Size(94, 58);
            this.BtnXml.TabIndex = 2;
            this.BtnXml.Text = "Xml";
            this.BtnXml.UseVisualStyleBackColor = true;
            this.BtnXml.Click += new System.EventHandler(this.BtnXml_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Nacimiento";
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
            this.toolStripMenuItem1});
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
            this.MenuRegistro.Size = new System.Drawing.Size(180, 22);
            this.MenuRegistro.Text = "Lista";
            this.MenuRegistro.Click += new System.EventHandler(this.MenuRegistro_Click);
            // 
            // AlumnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.dateBorn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.BtnXml);
            this.Controls.Add(this.BtnJson);
            this.Controls.Add(this.BtnTxt);
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

        private System.Windows.Forms.Button BtnTxt;
        private System.Windows.Forms.Button BtnJson;
        private System.Windows.Forms.Button BtnXml;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuRegistro;
    }
}