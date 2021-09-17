namespace assignment6
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
            this.btnSqRef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSqRefOut = new System.Windows.Forms.Button();
            this.btnSqVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSqRef
            // 
            this.btnSqRef.Location = new System.Drawing.Point(44, 88);
            this.btnSqRef.Name = "btnSqRef";
            this.btnSqRef.Size = new System.Drawing.Size(196, 33);
            this.btnSqRef.TabIndex = 0;
            this.btnSqRef.Text = "Square by Reference";
            this.btnSqRef.UseVisualStyleBackColor = true;
            this.btnSqRef.Click += new System.EventHandler(this.btnSqRef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // txtboxNum
            // 
            this.txtboxNum.Location = new System.Drawing.Point(140, 38);
            this.txtboxNum.Name = "txtboxNum";
            this.txtboxNum.Size = new System.Drawing.Size(100, 22);
            this.txtboxNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(194, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(32, 17);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "--.--";
            // 
            // btnSqRefOut
            // 
            this.btnSqRefOut.Location = new System.Drawing.Point(44, 127);
            this.btnSqRefOut.Name = "btnSqRefOut";
            this.btnSqRefOut.Size = new System.Drawing.Size(196, 33);
            this.btnSqRefOut.TabIndex = 0;
            this.btnSqRefOut.Text = "Square by Reference Out";
            this.btnSqRefOut.UseVisualStyleBackColor = true;
            this.btnSqRefOut.Click += new System.EventHandler(this.btnSqRefOut_Click);
            // 
            // btnSqVal
            // 
            this.btnSqVal.Location = new System.Drawing.Point(44, 166);
            this.btnSqVal.Name = "btnSqVal";
            this.btnSqVal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSqVal.Size = new System.Drawing.Size(196, 33);
            this.btnSqVal.TabIndex = 0;
            this.btnSqVal.Text = "Square by Value";
            this.btnSqVal.UseVisualStyleBackColor = true;
            this.btnSqVal.Click += new System.EventHandler(this.btnSqVal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 302);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSqVal);
            this.Controls.Add(this.btnSqRefOut);
            this.Controls.Add(this.btnSqRef);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSqRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSqRefOut;
        private System.Windows.Forms.Button btnSqVal;
    }
}

