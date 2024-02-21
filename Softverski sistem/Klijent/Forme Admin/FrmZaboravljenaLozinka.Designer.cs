using System.Windows.Forms;

namespace Klijent.Forme_Admin
{
    partial class FrmZaboravljenaLozinka
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
            this.lblPoruka1 = new System.Windows.Forms.Label();
            this.lblPoruka2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoruka1
            // 
            this.lblPoruka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPoruka1.AutoSize = true;
            this.lblPoruka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoruka1.Location = new System.Drawing.Point(85, 77);
            this.lblPoruka1.Name = "lblPoruka1";
            this.lblPoruka1.Size = new System.Drawing.Size(320, 32);
            this.lblPoruka1.TabIndex = 0;
            this.lblPoruka1.Text = "Zaboravili ste lozinku?";
            // 
            // lblPoruka2
            // 
            this.lblPoruka2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPoruka2.AutoSize = true;
            this.lblPoruka2.Location = new System.Drawing.Point(64, 125);
            this.lblPoruka2.Name = "lblPoruka2";
            this.lblPoruka2.Size = new System.Drawing.Size(361, 16);
            this.lblPoruka2.TabIndex = 1;
            this.lblPoruka2.Text = "Unesite email na koji želite da Vam pošaljemo novu lozinku!";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(116, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // btnPosalji
            // 
            this.btnPosalji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPosalji.Location = new System.Drawing.Point(173, 195);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(140, 32);
            this.btnPosalji.TabIndex = 3;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // FrmZaboravljenaLozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 283);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPoruka2);
            this.Controls.Add(this.lblPoruka1);
            this.Name = "FrmZaboravljenaLozinka";
            this.Text = "Zaboravili ste lozinku?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoruka1;
        private System.Windows.Forms.Label lblPoruka2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnPosalji;

        public Label LblPoruka1 { get => lblPoruka1; set => lblPoruka1 = value; }
        public Label LblPoruka2 { get => lblPoruka2; set => lblPoruka2 = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public Button BtnPosalji { get => btnPosalji; set => btnPosalji = value; }
    }
}