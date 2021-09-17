namespace Assignment5
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
            this.avrgBtn = new System.Windows.Forms.Button();
            this.num1Txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avrgLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num2Txtbox = new System.Windows.Forms.TextBox();
            this.num3Txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // avrgBtn
            // 
            this.avrgBtn.Location = new System.Drawing.Point(42, 281);
            this.avrgBtn.Name = "avrgBtn";
            this.avrgBtn.Size = new System.Drawing.Size(173, 50);
            this.avrgBtn.TabIndex = 0;
            this.avrgBtn.Text = "Calculate Average";
            this.avrgBtn.UseVisualStyleBackColor = true;
            this.avrgBtn.Click += new System.EventHandler(this.avrgBtn_Click);
            // 
            // num1Txtbox
            // 
            this.num1Txtbox.Location = new System.Drawing.Point(115, 46);
            this.num1Txtbox.Name = "num1Txtbox";
            this.num1Txtbox.Size = new System.Drawing.Size(100, 22);
            this.num1Txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number1:";
            // 
            // avrgLbl
            // 
            this.avrgLbl.AutoSize = true;
            this.avrgLbl.Location = new System.Drawing.Point(169, 214);
            this.avrgLbl.Name = "avrgLbl";
            this.avrgLbl.Size = new System.Drawing.Size(0, 17);
            this.avrgLbl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Average:";
            // 
            // num2Txtbox
            // 
            this.num2Txtbox.Location = new System.Drawing.Point(115, 102);
            this.num2Txtbox.Name = "num2Txtbox";
            this.num2Txtbox.Size = new System.Drawing.Size(100, 22);
            this.num2Txtbox.TabIndex = 1;
            // 
            // num3Txtbox
            // 
            this.num3Txtbox.Location = new System.Drawing.Point(115, 147);
            this.num3Txtbox.Name = "num3Txtbox";
            this.num3Txtbox.Size = new System.Drawing.Size(100, 22);
            this.num3Txtbox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.avrgLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num3Txtbox);
            this.Controls.Add(this.num2Txtbox);
            this.Controls.Add(this.num1Txtbox);
            this.Controls.Add(this.avrgBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avrgBtn;
        private System.Windows.Forms.TextBox num1Txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avrgLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num2Txtbox;
        private System.Windows.Forms.TextBox num3Txtbox;
    }
}

