namespace EjemploFernando
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.lbSalida = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAntiguo = new System.Windows.Forms.TextBox();
            this.btmOrdenar = new System.Windows.Forms.Button();
            this.btmIngresar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Trabajadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Trabajador: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(187, 75);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(166, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salario en Cordobas:";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(187, 118);
            this.tbSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(166, 20);
            this.tbSalario.TabIndex = 4;
            // 
            // lbSalida
            // 
            this.lbSalida.FormattingEnabled = true;
            this.lbSalida.Location = new System.Drawing.Point(29, 217);
            this.lbSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSalida.Name = "lbSalida";
            this.lbSalida.Size = new System.Drawing.Size(297, 134);
            this.lbSalida.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario en Cordobas:";
            // 
            // tbAntiguo
            // 
            this.tbAntiguo.Location = new System.Drawing.Point(187, 172);
            this.tbAntiguo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAntiguo.Name = "tbAntiguo";
            this.tbAntiguo.Size = new System.Drawing.Size(166, 20);
            this.tbAntiguo.TabIndex = 8;
            // 
            // btmOrdenar
            // 
            this.btmOrdenar.Location = new System.Drawing.Point(423, 315);
            this.btmOrdenar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmOrdenar.Name = "btmOrdenar";
            this.btmOrdenar.Size = new System.Drawing.Size(154, 36);
            this.btmOrdenar.TabIndex = 10;
            this.btmOrdenar.Text = "Ordenar";
            this.btmOrdenar.UseVisualStyleBackColor = true;
            this.btmOrdenar.Click += new System.EventHandler(this.btmOrdenar_Click_1);
            // 
            // btmIngresar
            // 
            this.btmIngresar.Location = new System.Drawing.Point(423, 217);
            this.btmIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmIngresar.Name = "btmIngresar";
            this.btmIngresar.Size = new System.Drawing.Size(154, 36);
            this.btmIngresar.TabIndex = 11;
            this.btmIngresar.Text = "Ingresar";
            this.btmIngresar.UseVisualStyleBackColor = true;
            this.btmIngresar.Click += new System.EventHandler(this.btmOrdenar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de dato a ordenar";
            // 
            // lbDato
            // 
            this.lbDato.FormattingEnabled = true;
            this.lbDato.Location = new System.Drawing.Point(417, 117);
            this.lbDato.Name = "lbDato";
            this.lbDato.Size = new System.Drawing.Size(151, 30);
            this.lbDato.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 387);
            this.Controls.Add(this.lbDato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btmIngresar);
            this.Controls.Add(this.btmOrdenar);
            this.Controls.Add(this.tbAntiguo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSalida);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.ListBox lbSalida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAntiguo;
        private System.Windows.Forms.Button btmOrdenar;
        private System.Windows.Forms.Button btmIngresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbDato;
    }
}

