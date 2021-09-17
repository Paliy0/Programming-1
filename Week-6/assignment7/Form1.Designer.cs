namespace assignment7
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
            this.txtboxDegrees = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radCtoK = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radFtoC = new System.Windows.Forms.RadioButton();
            this.radCtoF = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxDegrees
            // 
            this.txtboxDegrees.Location = new System.Drawing.Point(163, 31);
            this.txtboxDegrees.Name = "txtboxDegrees";
            this.txtboxDegrees.Size = new System.Drawing.Size(100, 22);
            this.txtboxDegrees.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Degrees";
            // 
            // radCtoK
            // 
            this.radCtoK.AutoSize = true;
            this.radCtoK.Location = new System.Drawing.Point(12, 36);
            this.radCtoK.Name = "radCtoK";
            this.radCtoK.Size = new System.Drawing.Size(132, 21);
            this.radCtoK.TabIndex = 2;
            this.radCtoK.TabStop = true;
            this.radCtoK.Text = "Celsius to Kelvin";
            this.radCtoK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radFtoC);
            this.panel1.Controls.Add(this.radCtoF);
            this.panel1.Controls.Add(this.radCtoK);
            this.panel1.Location = new System.Drawing.Point(36, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 156);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conversion";
            // 
            // radFtoC
            // 
            this.radFtoC.AutoSize = true;
            this.radFtoC.Location = new System.Drawing.Point(12, 123);
            this.radFtoC.Name = "radFtoC";
            this.radFtoC.Size = new System.Drawing.Size(162, 21);
            this.radFtoC.TabIndex = 2;
            this.radFtoC.TabStop = true;
            this.radFtoC.Text = "Fahrenheit to Celsius";
            this.radFtoC.UseVisualStyleBackColor = true;
            // 
            // radCtoF
            // 
            this.radCtoF.AutoSize = true;
            this.radCtoF.Location = new System.Drawing.Point(12, 80);
            this.radCtoF.Name = "radCtoF";
            this.radCtoF.Size = new System.Drawing.Size(162, 21);
            this.radCtoF.TabIndex = 2;
            this.radCtoF.TabStop = true;
            this.radCtoF.Text = "Celsius to Fahrenheit";
            this.radCtoF.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Converted degrees";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(217, 327);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 17);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "--.--";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(36, 264);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(227, 42);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 373);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxDegrees);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxDegrees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radCtoK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton radFtoC;
        private System.Windows.Forms.RadioButton radCtoF;
        private System.Windows.Forms.Button btnCalc;
    }
}

