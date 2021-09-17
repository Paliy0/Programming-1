namespace assigment9
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.memberTxtbox = new System.Windows.Forms.TextBox();
            this.footballRad = new System.Windows.Forms.RadioButton();
            this.handballRad = new System.Windows.Forms.RadioButton();
            this.ageTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.feeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate Fee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sport";
            // 
            // memberTxtbox
            // 
            this.memberTxtbox.Location = new System.Drawing.Point(184, 203);
            this.memberTxtbox.Name = "memberTxtbox";
            this.memberTxtbox.Size = new System.Drawing.Size(100, 22);
            this.memberTxtbox.TabIndex = 2;
            // 
            // footballRad
            // 
            this.footballRad.AutoSize = true;
            this.footballRad.Location = new System.Drawing.Point(174, 41);
            this.footballRad.Name = "footballRad";
            this.footballRad.Size = new System.Drawing.Size(79, 21);
            this.footballRad.TabIndex = 3;
            this.footballRad.TabStop = true;
            this.footballRad.Text = "Football";
            this.footballRad.UseVisualStyleBackColor = true;
            // 
            // handballRad
            // 
            this.handballRad.AutoSize = true;
            this.handballRad.Location = new System.Drawing.Point(174, 97);
            this.handballRad.Name = "handballRad";
            this.handballRad.Size = new System.Drawing.Size(85, 21);
            this.handballRad.TabIndex = 3;
            this.handballRad.TabStop = true;
            this.handballRad.Text = "Handball";
            this.handballRad.UseVisualStyleBackColor = true;
            // 
            // ageTxtbox
            // 
            this.ageTxtbox.Location = new System.Drawing.Point(184, 155);
            this.ageTxtbox.Name = "ageTxtbox";
            this.ageTxtbox.Size = new System.Drawing.Size(100, 22);
            this.ageTxtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Membership duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fee to be paid";
            // 
            // feeLbl
            // 
            this.feeLbl.AutoSize = true;
            this.feeLbl.Location = new System.Drawing.Point(224, 363);
            this.feeLbl.Name = "feeLbl";
            this.feeLbl.Size = new System.Drawing.Size(32, 17);
            this.feeLbl.TabIndex = 1;
            this.feeLbl.Text = "--.--";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(324, 439);
            this.Controls.Add(this.handballRad);
            this.Controls.Add(this.footballRad);
            this.Controls.Add(this.ageTxtbox);
            this.Controls.Add(this.memberTxtbox);
            this.Controls.Add(this.feeLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button feeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberTxtbox;
        private System.Windows.Forms.RadioButton footballRad;
        private System.Windows.Forms.RadioButton handballRad;
        private System.Windows.Forms.TextBox ageTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label feeLbl;
    }
}

