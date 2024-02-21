namespace Klijent.Forms.User_kontrole
{
    partial class UCPocetna
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(172, 147);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(343, 79);
            this.lblDobrodosli.TabIndex = 2;
            this.lblDobrodosli.Text = "Dobrodošli!";
            // 
            // lblVreme
            // 
            this.lblVreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVreme.AutoSize = true;
            this.lblVreme.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.Location = new System.Drawing.Point(215, 226);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(236, 55);
            this.lblVreme.TabIndex = 3;
            this.lblVreme.Text = "HH:mm:ss";
            // 
            // UCPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.lblVreme);
            this.Name = "UCPocetna";
            this.Size = new System.Drawing.Size(689, 428);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Label lblVreme;
    }
}
