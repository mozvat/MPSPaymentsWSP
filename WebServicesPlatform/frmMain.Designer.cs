namespace WebServicesPlatform
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreditSale = new System.Windows.Forms.Button();
            this.btnGiftSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreditSale
            // 
            this.btnCreditSale.Location = new System.Drawing.Point(28, 22);
            this.btnCreditSale.Name = "btnCreditSale";
            this.btnCreditSale.Size = new System.Drawing.Size(103, 53);
            this.btnCreditSale.TabIndex = 0;
            this.btnCreditSale.Text = "Credit Sale";
            this.btnCreditSale.UseVisualStyleBackColor = true;
            this.btnCreditSale.Click += new System.EventHandler(this.btnCreditSale_Click);
            // 
            // btnGiftSale
            // 
            this.btnGiftSale.Location = new System.Drawing.Point(28, 81);
            this.btnGiftSale.Name = "btnGiftSale";
            this.btnGiftSale.Size = new System.Drawing.Size(103, 53);
            this.btnGiftSale.TabIndex = 1;
            this.btnGiftSale.Text = "Gift Sale";
            this.btnGiftSale.UseVisualStyleBackColor = true;
            this.btnGiftSale.Click += new System.EventHandler(this.btnGiftSale_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 195);
            this.Controls.Add(this.btnGiftSale);
            this.Controls.Add(this.btnCreditSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Transactions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreditSale;
        private System.Windows.Forms.Button btnGiftSale;
    }
}

