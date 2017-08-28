namespace GoogleDomainHashCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDomainHash = new System.Windows.Forms.TextBox();
            this.btnCopyCB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExplanation
            // 
            this.lblExplanation.Location = new System.Drawing.Point(13, 13);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(539, 80);
            this.lblExplanation.TabIndex = 0;
            this.lblExplanation.Text = resources.GetString("lblExplanation.Text");
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(13, 102);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(72, 13);
            this.lblDomain.TabIndex = 1;
            this.lblDomain.Text = "Enter domain:";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(89, 95);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(463, 20);
            this.txtDomain.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 155);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(142, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Domain Hash";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtDomainHash
            // 
            this.txtDomainHash.Enabled = false;
            this.txtDomainHash.Location = new System.Drawing.Point(184, 158);
            this.txtDomainHash.Name = "txtDomainHash";
            this.txtDomainHash.Size = new System.Drawing.Size(221, 20);
            this.txtDomainHash.TabIndex = 4;
            // 
            // btnCopyCB
            // 
            this.btnCopyCB.Location = new System.Drawing.Point(429, 155);
            this.btnCopyCB.Name = "btnCopyCB";
            this.btnCopyCB.Size = new System.Drawing.Size(123, 23);
            this.btnCopyCB.TabIndex = 5;
            this.btnCopyCB.Text = "Copy to Clipboard";
            this.btnCopyCB.UseVisualStyleBackColor = true;
            this.btnCopyCB.Click += new System.EventHandler(this.btnCopyCB_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 199);
            this.Controls.Add(this.btnCopyCB);
            this.Controls.Add(this.txtDomainHash);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblExplanation);
            this.Name = "frmMain";
            this.Text = "Google Analytics Domain Hash Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDomainHash;
        private System.Windows.Forms.Button btnCopyCB;
    }
}

