namespace Ejercicio_1
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
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Valor1TextBox = new System.Windows.Forms.TextBox();
            this.Respuesta1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Respuesta2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(127, 211);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(103, 38);
            this.CalcularButton.TabIndex = 0;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el Valor Entero:";
            // 
            // Valor1TextBox
            // 
            this.Valor1TextBox.Location = new System.Drawing.Point(167, 58);
            this.Valor1TextBox.Name = "Valor1TextBox";
            this.Valor1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Valor1TextBox.TabIndex = 2;
            // 
            // Respuesta1TextBox
            // 
            this.Respuesta1TextBox.Location = new System.Drawing.Point(183, 109);
            this.Respuesta1TextBox.Name = "Respuesta1TextBox";
            this.Respuesta1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Respuesta1TextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Respuesta 1 (Par o Impar):";
            // 
            // Respuesta2TextBox
            // 
            this.Respuesta2TextBox.Location = new System.Drawing.Point(221, 156);
            this.Respuesta2TextBox.Name = "Respuesta2TextBox";
            this.Respuesta2TextBox.Size = new System.Drawing.Size(159, 20);
            this.Respuesta2TextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Respuesta 2 (Positivo o Negativo):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 321);
            this.Controls.Add(this.Respuesta2TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Respuesta1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Valor1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Valor1TextBox;
        private System.Windows.Forms.TextBox Respuesta1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Respuesta2TextBox;
        private System.Windows.Forms.Label label3;
    }
}

