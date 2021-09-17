namespace Assignment7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startTxtbox = new System.Windows.Forms.TextBox();
            this.endTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.priceTxtbox = new System.Windows.Forms.TextBox();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.startLbl = new System.Windows.Forms.Label();
            this.endLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vatLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTxtbox
            // 
            this.startTxtbox.Location = new System.Drawing.Point(161, 55);
            this.startTxtbox.Name = "startTxtbox";
            this.startTxtbox.Size = new System.Drawing.Size(100, 22);
            this.startTxtbox.TabIndex = 0;
            // 
            // endTxtbox
            // 
            this.endTxtbox.Location = new System.Drawing.Point(161, 119);
            this.endTxtbox.Name = "endTxtbox";
            this.endTxtbox.Size = new System.Drawing.Size(100, 22);
            this.endTxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-47, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1018, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(171, 265);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(90, 33);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // priceTxtbox
            // 
            this.priceTxtbox.Location = new System.Drawing.Point(161, 181);
            this.priceTxtbox.Name = "priceTxtbox";
            this.priceTxtbox.Size = new System.Drawing.Size(100, 22);
            this.priceTxtbox.TabIndex = 0;
            // 
            // eraseBtn
            // 
            this.eraseBtn.Location = new System.Drawing.Point(41, 265);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(83, 33);
            this.eraseBtn.TabIndex = 2;
            this.eraseBtn.Text = "Erase";
            this.eraseBtn.UseVisualStyleBackColor = true;
            this.eraseBtn.Click += new System.EventHandler(this.eraseBtn_Click);
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Location = new System.Drawing.Point(38, 60);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(60, 17);
            this.startLbl.TabIndex = 3;
            this.startLbl.Text = "Start km";
            // 
            // endLbl
            // 
            this.endLbl.AutoSize = true;
            this.endLbl.Location = new System.Drawing.Point(38, 122);
            this.endLbl.Name = "endLbl";
            this.endLbl.Size = new System.Drawing.Size(55, 17);
            this.endLbl.TabIndex = 3;
            this.endLbl.Text = "End km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price / km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price ";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(38, 405);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(32, 17);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "--.--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "VAT";
            // 
            // vatLbl
            // 
            this.vatLbl.AutoSize = true;
            this.vatLbl.Location = new System.Drawing.Point(130, 405);
            this.vatLbl.Name = "vatLbl";
            this.vatLbl.Size = new System.Drawing.Size(32, 17);
            this.vatLbl.TabIndex = 3;
            this.vatLbl.Text = "--.--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(221, 405);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(32, 17);
            this.totalLbl.TabIndex = 3;
            this.totalLbl.Text = "--.--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 462);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vatLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.eraseBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTxtbox);
            this.Controls.Add(this.endTxtbox);
            this.Controls.Add(this.startTxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startTxtbox;
        private System.Windows.Forms.TextBox endTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox priceTxtbox;
        private System.Windows.Forms.Button eraseBtn;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Label endLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label vatLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalLbl;
    }
}

