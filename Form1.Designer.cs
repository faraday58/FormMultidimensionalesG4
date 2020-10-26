namespace FormMultidimensionalesG4
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
            this.rdbGrados = new System.Windows.Forms.RadioButton();
            this.rdbRadianes = new System.Windows.Forms.RadioButton();
            this.txtbIntro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMatriz1 = new System.Windows.Forms.Label();
            this.lbMatriz2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnIntro = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbGrados
            // 
            this.rdbGrados.AutoSize = true;
            this.rdbGrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGrados.Location = new System.Drawing.Point(80, 25);
            this.rdbGrados.Name = "rdbGrados";
            this.rdbGrados.Size = new System.Drawing.Size(101, 29);
            this.rdbGrados.TabIndex = 0;
            this.rdbGrados.TabStop = true;
            this.rdbGrados.Text = "Grados";
            this.rdbGrados.UseVisualStyleBackColor = true;
            // 
            // rdbRadianes
            // 
            this.rdbRadianes.AutoSize = true;
            this.rdbRadianes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRadianes.Location = new System.Drawing.Point(251, 25);
            this.rdbRadianes.Name = "rdbRadianes";
            this.rdbRadianes.Size = new System.Drawing.Size(119, 29);
            this.rdbRadianes.TabIndex = 0;
            this.rdbRadianes.TabStop = true;
            this.rdbRadianes.Text = "Radianes";
            this.rdbRadianes.UseVisualStyleBackColor = true;
            // 
            // txtbIntro
            // 
            this.txtbIntro.Location = new System.Drawing.Point(80, 88);
            this.txtbIntro.Name = "txtbIntro";
            this.txtbIntro.Size = new System.Drawing.Size(367, 26);
            this.txtbIntro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matriz 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(201, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matriz 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(326, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // lbMatriz1
            // 
            this.lbMatriz1.AutoSize = true;
            this.lbMatriz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMatriz1.Location = new System.Drawing.Point(76, 195);
            this.lbMatriz1.Name = "lbMatriz1";
            this.lbMatriz1.Size = new System.Drawing.Size(64, 25);
            this.lbMatriz1.TabIndex = 2;
            this.lbMatriz1.Text = "label1";
            // 
            // lbMatriz2
            // 
            this.lbMatriz2.AutoSize = true;
            this.lbMatriz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMatriz2.Location = new System.Drawing.Point(201, 195);
            this.lbMatriz2.Name = "lbMatriz2";
            this.lbMatriz2.Size = new System.Drawing.Size(64, 25);
            this.lbMatriz2.TabIndex = 2;
            this.lbMatriz2.Text = "label1";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbResultado.Location = new System.Drawing.Point(326, 195);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(64, 25);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "label1";
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(70, 315);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(88, 63);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(209, 315);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(88, 63);
            this.btnResta.TabIndex = 3;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(359, 315);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(88, 63);
            this.btnMultiplicar.TabIndex = 3;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnIntro
            // 
            this.btnIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.Location = new System.Drawing.Point(519, 315);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(88, 177);
            this.btnIntro.TabIndex = 3;
            this.btnIntro.Text = "Intro";
            this.btnIntro.UseVisualStyleBackColor = true;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(70, 439);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(88, 63);
            this.btnSeno.TabIndex = 3;
            this.btnSeno.Text = "Sen";
            this.btnSeno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 519);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbMatriz2);
            this.Controls.Add(this.lbMatriz1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbIntro);
            this.Controls.Add(this.rdbRadianes);
            this.Controls.Add(this.rdbGrados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbGrados;
        private System.Windows.Forms.RadioButton rdbRadianes;
        private System.Windows.Forms.TextBox txtbIntro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMatriz1;
        private System.Windows.Forms.Label lbMatriz2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.Button btnSeno;
    }
}

