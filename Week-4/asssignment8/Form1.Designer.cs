namespace asssignment8
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
            this.compareBtn = new System.Windows.Forms.Button();
            this.numTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sum1Lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum2Lbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(31, 94);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(231, 35);
            this.compareBtn.TabIndex = 0;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // numTxtbox
            // 
            this.numTxtbox.Location = new System.Drawing.Point(162, 43);
            this.numTxtbox.Name = "numTxtbox";
            this.numTxtbox.Size = new System.Drawing.Size(100, 22);
            this.numTxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a number (n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "sum = 1 +2 + ... + n";
            // 
            // sum1Lbl
            // 
            this.sum1Lbl.AutoSize = true;
            this.sum1Lbl.Location = new System.Drawing.Point(216, 172);
            this.sum1Lbl.Name = "sum1Lbl";
            this.sum1Lbl.Size = new System.Drawing.Size(32, 17);
            this.sum1Lbl.TabIndex = 2;
            this.sum1Lbl.Text = "--.--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "sum = n * (n + 1) / 2";
            // 
            // sum2Lbl
            // 
            this.sum2Lbl.AutoSize = true;
            this.sum2Lbl.Location = new System.Drawing.Point(216, 241);
            this.sum2Lbl.Name = "sum2Lbl";
            this.sum2Lbl.Size = new System.Drawing.Size(32, 17);
            this.sum2Lbl.TabIndex = 2;
            this.sum2Lbl.Text = "--.--";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(28, 327);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(12, 17);
            this.resultLbl.TabIndex = 2;
            this.resultLbl.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 366);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.sum2Lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sum1Lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTxtbox);
            this.Controls.Add(this.compareBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.TextBox numTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sum1Lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sum2Lbl;
        private System.Windows.Forms.Label resultLbl;
    }
}

