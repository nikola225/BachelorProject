using System.Windows.Forms;

namespace Klijent.Forme_Putnik
{
    partial class FrmLoginPutnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginPutnik));
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.lblGreska = new System.Windows.Forms.Label();
            this.chbPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOtkazi.Location = new System.Drawing.Point(300, 271);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(159, 32);
            this.btnOtkazi.TabIndex = 17;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = false;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistracija.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistracija.Location = new System.Drawing.Point(300, 235);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(159, 32);
            this.btnRegistracija.TabIndex = 16;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrijaviSe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrijaviSe.Location = new System.Drawing.Point(300, 199);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(159, 32);
            this.btnPrijaviSe.TabIndex = 15;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // lblGreska
            // 
            this.lblGreska.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGreska.AutoSize = true;
            this.lblGreska.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGreska.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGreska.Location = new System.Drawing.Point(308, 317);
            this.lblGreska.Name = "lblGreska";
            this.lblGreska.Size = new System.Drawing.Size(141, 18);
            this.lblGreska.TabIndex = 14;
            this.lblGreska.Text = "Previše pokušaja!";
            // 
            // chbPrikaziLozinku
            // 
            this.chbPrikaziLozinku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbPrikaziLozinku.AutoSize = true;
            this.chbPrikaziLozinku.Location = new System.Drawing.Point(300, 162);
            this.chbPrikaziLozinku.Name = "chbPrikaziLozinku";
            this.chbPrikaziLozinku.Size = new System.Drawing.Size(113, 20);
            this.chbPrikaziLozinku.TabIndex = 13;
            this.chbPrikaziLozinku.Text = "Prikaži lozinku";
            this.chbPrikaziLozinku.UseVisualStyleBackColor = true;
            this.chbPrikaziLozinku.CheckedChanged += new System.EventHandler(this.chbPrikaziLozinku_CheckedChanged);
            // 
            // lblLozinka
            // 
            this.lblLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(229, 140);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(56, 16);
            this.lblLozinka.TabIndex = 12;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(188, 112);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(97, 16);
            this.lblKorisnickoIme.TabIndex = 11;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka.Location = new System.Drawing.Point(300, 134);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(159, 22);
            this.txtLozinka.TabIndex = 10;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(300, 106);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(159, 22);
            this.txtKorisnickoIme.TabIndex = 9;
            // 
            // FrmLoginPutnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.lblGreska);
            this.Controls.Add(this.chbPrikaziLozinku);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoginPutnik";
            this.Text = " Prijavi se kao putnik!";
            this.TransparencyKey = System.Drawing.SystemColors.Highlight;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Label lblGreska;
        private System.Windows.Forms.CheckBox chbPrikaziLozinku;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;

        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Button BtnRegistracija { get => btnRegistracija; set => btnRegistracija = value; }
        public Button BtnPrijaviSe { get => btnPrijaviSe; set => btnPrijaviSe = value; }
        public Label LblGreska { get => lblGreska; set => lblGreska = value; }
        public CheckBox ChbPrikaziLozinku { get => chbPrikaziLozinku; set => chbPrikaziLozinku = value; }
        public Label LblLozinka { get => lblLozinka; set => lblLozinka = value; }
        public Label LblKorisnickoIme { get => lblKorisnickoIme; set => lblKorisnickoIme = value; }
        public TextBox TxtLozinka { get => txtLozinka; set => txtLozinka = value; }
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
    }
}