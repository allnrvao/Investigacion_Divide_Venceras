namespace Sistema_de_incripcion_UAM
{
    partial class LbESst
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.cbFact = new System.Windows.Forms.ComboBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbProm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCarr = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEst = new System.Windows.Forms.ListBox();
            this.tbApe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbSal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Promedio: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("NSimSun", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(136, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(372, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = " Aprobacion de becas UAM";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(106, 100);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(346, 22);
            this.tbNombre.TabIndex = 5;
            // 
            // cbFact
            // 
            this.cbFact.FormattingEnabled = true;
            this.cbFact.Items.AddRange(new object[] {
            "Facultad de ciencias medicas (FCM)",
            "Facultad de odotologia (FO)",
            "Facultad de ciencias administrativas y economicas (FCAE)",
            " Facultad de relaciones publicas (FRP)",
            "Facultad de ingieneriay arquitectura (FIA)"});
            this.cbFact.Location = new System.Drawing.Point(106, 283);
            this.cbFact.Name = "cbFact";
            this.cbFact.Size = new System.Drawing.Size(346, 24);
            this.cbFact.TabIndex = 6;
            this.cbFact.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(106, 194);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(108, 22);
            this.tbEdad.TabIndex = 7;
            // 
            // tbProm
            // 
            this.tbProm.Location = new System.Drawing.Point(106, 239);
            this.tbProm.Name = "tbProm";
            this.tbProm.Size = new System.Drawing.Size(108, 22);
            this.tbProm.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Facultad:";
            // 
            // cbCarr
            // 
            this.cbCarr.FormattingEnabled = true;
            this.cbCarr.Items.AddRange(new object[] {
            "Medicina",
            "Odontologia",
            "Contabilidad ",
            "Adminisracion de empresas ",
            "Negocios internacionales ",
            "Derecho ",
            "Relaciones internacionales ",
            "Ing. Civil",
            "Ing. Sistema",
            "Ing. Industrial ",
            "Arquitectura"});
            this.cbCarr.Location = new System.Drawing.Point(106, 323);
            this.cbCarr.Name = "cbCarr";
            this.cbCarr.Size = new System.Drawing.Size(346, 24);
            this.cbCarr.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Carrera ";
            // 
            // lbEst
            // 
            this.lbEst.FormattingEnabled = true;
            this.lbEst.ItemHeight = 16;
            this.lbEst.Location = new System.Drawing.Point(31, 458);
            this.lbEst.Name = "lbEst";
            this.lbEst.Size = new System.Drawing.Size(966, 132);
            this.lbEst.TabIndex = 15;
            this.lbEst.SelectedIndexChanged += new System.EventHandler(this.lbEst_SelectedIndexChanged);
            // 
            // tbApe
            // 
            this.tbApe.Location = new System.Drawing.Point(106, 147);
            this.tbApe.Name = "tbApe";
            this.tbApe.Size = new System.Drawing.Size(346, 22);
            this.tbApe.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Apellido:";
            // 
            // btSave
            // 
            this.btSave.Image = global::Sistema_de_incripcion_UAM.Properties.Resources.disco_flexible;
            this.btSave.Location = new System.Drawing.Point(473, 100);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(114, 69);
            this.btSave.TabIndex = 18;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::Sistema_de_incripcion_UAM.Properties.Resources.uam;
            this.pictureBox1.Location = new System.Drawing.Point(633, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 427);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbSal
            // 
            this.lbSal.AutoSize = true;
            this.lbSal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSal.Location = new System.Drawing.Point(638, 399);
            this.lbSal.Name = "lbSal";
            this.lbSal.Size = new System.Drawing.Size(0, 25);
            this.lbSal.TabIndex = 19;
            // 
            // LbESst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1130, 663);
            this.Controls.Add(this.lbSal);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbApe);
            this.Controls.Add(this.lbEst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCarr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbProm);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.cbFact);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LbESst";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbFact;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbProm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCarr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbEst;
        private System.Windows.Forms.TextBox tbApe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbSal;
    }
}

