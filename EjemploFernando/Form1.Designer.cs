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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAntiguo = new System.Windows.Forms.TextBox();
            this.rbSalario = new System.Windows.Forms.RadioButton();
            this.rbAntiguo = new System.Windows.Forms.RadioButton();
            this.btmIngresar = new System.Windows.Forms.Button();
            this.btmOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador de Trabajadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Trabajador: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(281, 115);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(247, 26);
            this.tbNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salario en Cordobas:";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(281, 181);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(247, 26);
            this.tbSalario.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(43, 334);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 204);
            this.listBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario en Cordobas:";
            // 
            // tbAntiguo
            // 
            this.tbAntiguo.Location = new System.Drawing.Point(281, 265);
            this.tbAntiguo.Name = "tbAntiguo";
            this.tbAntiguo.Size = new System.Drawing.Size(247, 26);
            this.tbAntiguo.TabIndex = 8;
            // 
            // rbSalario
            // 
            this.rbSalario.AutoSize = true;
            this.rbSalario.Location = new System.Drawing.Point(612, 317);
            this.rbSalario.Name = "rbSalario";
            this.rbSalario.Size = new System.Drawing.Size(83, 24);
            this.rbSalario.TabIndex = 6;
            this.rbSalario.TabStop = true;
            this.rbSalario.Text = "Salario";
            this.rbSalario.UseVisualStyleBackColor = true;
            // 
            // rbAntiguo
            // 
            this.rbAntiguo.AutoSize = true;
            this.rbAntiguo.Location = new System.Drawing.Point(612, 365);
            this.rbAntiguo.Name = "rbAntiguo";
            this.rbAntiguo.Size = new System.Drawing.Size(71, 24);
            this.rbAntiguo.TabIndex = 9;
            this.rbAntiguo.TabStop = true;
            this.rbAntiguo.Text = "Años";
            this.rbAntiguo.UseVisualStyleBackColor = true;
            // 
            // btmIngresar
            // 
            this.btmIngresar.Location = new System.Drawing.Point(635, 101);
            this.btmIngresar.Name = "btmIngresar";
            this.btmIngresar.Size = new System.Drawing.Size(231, 56);
            this.btmIngresar.TabIndex = 10;
            this.btmIngresar.Text = "Ingresar";
            this.btmIngresar.UseVisualStyleBackColor = true;
            // 
            // btmOrdenar
            // 
            this.btmOrdenar.Location = new System.Drawing.Point(635, 207);
            this.btmOrdenar.Name = "btmOrdenar";
            this.btmOrdenar.Size = new System.Drawing.Size(231, 56);
            this.btmOrdenar.TabIndex = 11;
            this.btmOrdenar.Text = "Ordenar";
            this.btmOrdenar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 596);
            this.Controls.Add(this.btmOrdenar);
            this.Controls.Add(this.btmIngresar);
            this.Controls.Add(this.rbAntiguo);
            this.Controls.Add(this.tbAntiguo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbSalario);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAntiguo;
        private System.Windows.Forms.RadioButton rbSalario;
        private System.Windows.Forms.RadioButton rbAntiguo;
        private System.Windows.Forms.Button btmIngresar;
        private System.Windows.Forms.Button btmOrdenar;
    }
}

