namespace Klijent
{
    partial class FrmIzbor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzbor));
            this.lblPrijaviteSeKao = new System.Windows.Forms.Label();
            this.btnAdministrator = new System.Windows.Forms.Button();
            this.btnPutnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrijaviteSeKao
            // 
            this.lblPrijaviteSeKao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrijaviteSeKao.AutoSize = true;
            this.lblPrijaviteSeKao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrijaviteSeKao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrijaviteSeKao.Location = new System.Drawing.Point(145, 86);
            this.lblPrijaviteSeKao.Name = "lblPrijaviteSeKao";
            this.lblPrijaviteSeKao.Size = new System.Drawing.Size(192, 29);
            this.lblPrijaviteSeKao.TabIndex = 0;
            this.lblPrijaviteSeKao.Text = "Prijavite se kao";
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdministrator.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdministrator.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdministrator.Location = new System.Drawing.Point(121, 139);
            this.btnAdministrator.Name = "btnAdministrator";
            this.btnAdministrator.Size = new System.Drawing.Size(236, 52);
            this.btnAdministrator.TabIndex = 1;
            this.btnAdministrator.Text = "Administrator";
            this.btnAdministrator.UseVisualStyleBackColor = false;
            this.btnAdministrator.Click += new System.EventHandler(this.btnAdministrator_Click);
            // 
            // btnPutnik
            // 
            this.btnPutnik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPutnik.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnPutnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPutnik.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPutnik.Location = new System.Drawing.Point(121, 197);
            this.btnPutnik.Name = "btnPutnik";
            this.btnPutnik.Size = new System.Drawing.Size(236, 52);
            this.btnPutnik.TabIndex = 2;
            this.btnPutnik.Text = "Putnik";
            this.btnPutnik.UseVisualStyleBackColor = false;
            this.btnPutnik.Click += new System.EventHandler(this.btnPutnik_Click);
            // 
            // FrmIzbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 340);
            this.Controls.Add(this.btnPutnik);
            this.Controls.Add(this.btnAdministrator);
            this.Controls.Add(this.lblPrijaviteSeKao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIzbor";
            this.Text = "Odaberite svoju ulogu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrijaviteSeKao;
        private System.Windows.Forms.Button btnAdministrator;
        private System.Windows.Forms.Button btnPutnik;
    }
}