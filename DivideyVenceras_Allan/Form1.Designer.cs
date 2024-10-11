namespace DivideyVenceras_Allan
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLookUp = new System.Windows.Forms.Button();
            this.LbWrkLookedup = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbWorkers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLookUp1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIVIDE Y VECERÁS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(176, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar trabajadores a la lista";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAdd.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(197, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 54);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(414, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Puesto:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(148, 155);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(221, 38);
            this.tbName.TabIndex = 5;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(517, 155);
            this.tbPosition.Multiline = true;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(221, 38);
            this.tbPosition.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(84, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trabajadores agregados";
            // 
            // BtnLookUp
            // 
            this.BtnLookUp.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnLookUp.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnLookUp.ForeColor = System.Drawing.Color.White;
            this.BtnLookUp.Location = new System.Drawing.Point(503, 432);
            this.BtnLookUp.Name = "BtnLookUp";
            this.BtnLookUp.Size = new System.Drawing.Size(159, 54);
            this.BtnLookUp.TabIndex = 9;
            this.BtnLookUp.Text = "Buscar";
            this.BtnLookUp.UseVisualStyleBackColor = false;
            this.BtnLookUp.Click += new System.EventHandler(this.BtnLookUp_Click);
            // 
            // LbWrkLookedup
            // 
            this.LbWrkLookedup.AutoSize = true;
            this.LbWrkLookedup.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWrkLookedup.ForeColor = System.Drawing.Color.Red;
            this.LbWrkLookedup.Location = new System.Drawing.Point(459, 551);
            this.LbWrkLookedup.Name = "LbWrkLookedup";
            this.LbWrkLookedup.Size = new System.Drawing.Size(80, 33);
            this.LbWrkLookedup.TabIndex = 10;
            this.LbWrkLookedup.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(460, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Trabajador buscado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(412, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(340, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "_________________";
            // 
            // lbWorkers
            // 
            this.lbWorkers.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorkers.FormattingEnabled = true;
            this.lbWorkers.ItemHeight = 26;
            this.lbWorkers.Location = new System.Drawing.Point(52, 388);
            this.lbWorkers.Name = "lbWorkers";
            this.lbWorkers.Size = new System.Drawing.Size(337, 290);
            this.lbWorkers.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(478, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buscar trabajador";
            // 
            // tbLookUp1
            // 
            this.tbLookUp1.Location = new System.Drawing.Point(465, 348);
            this.tbLookUp1.Multiline = true;
            this.tbLookUp1.Name = "tbLookUp1";
            this.tbLookUp1.Size = new System.Drawing.Size(229, 41);
            this.tbLookUp1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(777, 744);
            this.Controls.Add(this.tbLookUp1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbWorkers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LbWrkLookedup);
            this.Controls.Add(this.BtnLookUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnLookUp;
        private System.Windows.Forms.Label LbWrkLookedup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbWorkers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLookUp1;
    }
}

