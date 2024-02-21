using System.Windows.Forms;

namespace Klijent.Forms
{
    partial class FrmRegistracijaAdmin
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka1 = new System.Windows.Forms.Label();
            this.lblLozinka2 = new System.Windows.Forms.Label();
            this.btnKreirajNalog = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.chbPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.lblUpozorenje = new System.Windows.Forms.Label();
            this.lblUpozorenjeEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(189, 61);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(130, 22);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(189, 99);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(130, 22);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(189, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(189, 186);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(130, 22);
            this.txtKorisnickoIme.TabIndex = 3;
            this.txtKorisnickoIme.TextChanged += new System.EventHandler(this.txtKorisnickoIme_TextChanged);
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka1.Location = new System.Drawing.Point(189, 244);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.PasswordChar = '*';
            this.txtLozinka1.Size = new System.Drawing.Size(130, 22);
            this.txtLozinka1.TabIndex = 4;
            this.txtLozinka1.TextChanged += new System.EventHandler(this.txtLozinka1_TextChanged);
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka2.Location = new System.Drawing.Point(189, 282);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.PasswordChar = '*';
            this.txtLozinka2.Size = new System.Drawing.Size(130, 22);
            this.txtLozinka2.TabIndex = 5;
            this.txtLozinka2.TextChanged += new System.EventHandler(this.txtLozinka2_TextChanged);
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(127, 67);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 6;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(103, 105);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 7;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(111, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(62, 192);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(97, 16);
            this.lblKorisnickoIme.TabIndex = 9;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblLozinka1
            // 
            this.lblLozinka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka1.AutoSize = true;
            this.lblLozinka1.Location = new System.Drawing.Point(103, 250);
            this.lblLozinka1.Name = "lblLozinka1";
            this.lblLozinka1.Size = new System.Drawing.Size(56, 16);
            this.lblLozinka1.TabIndex = 10;
            this.lblLozinka1.Text = "Lozinka:";
            // 
            // lblLozinka2
            // 
            this.lblLozinka2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka2.AutoSize = true;
            this.lblLozinka2.Location = new System.Drawing.Point(66, 288);
            this.lblLozinka2.Name = "lblLozinka2";
            this.lblLozinka2.Size = new System.Drawing.Size(96, 16);
            this.lblLozinka2.TabIndex = 11;
            this.lblLozinka2.Text = "Potvrdi lozinku:";
            // 
            // btnKreirajNalog
            // 
            this.btnKreirajNalog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajNalog.Location = new System.Drawing.Point(189, 353);
            this.btnKreirajNalog.Name = "btnKreirajNalog";
            this.btnKreirajNalog.Size = new System.Drawing.Size(130, 31);
            this.btnKreirajNalog.TabIndex = 12;
            this.btnKreirajNalog.Text = "Kreiraj nalog";
            this.btnKreirajNalog.UseVisualStyleBackColor = true;
            this.btnKreirajNalog.Click += new System.EventHandler(this.btnKreirajNalog_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(189, 390);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(130, 31);
            this.btnOtkazi.TabIndex = 13;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // chbPrikaziLozinku
            // 
            this.chbPrikaziLozinku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbPrikaziLozinku.AutoSize = true;
            this.chbPrikaziLozinku.Location = new System.Drawing.Point(189, 311);
            this.chbPrikaziLozinku.Name = "chbPrikaziLozinku";
            this.chbPrikaziLozinku.Size = new System.Drawing.Size(113, 20);
            this.chbPrikaziLozinku.TabIndex = 14;
            this.chbPrikaziLozinku.Text = "Prikaži lozinku";
            this.chbPrikaziLozinku.UseVisualStyleBackColor = true;
            this.chbPrikaziLozinku.CheckedChanged += new System.EventHandler(this.chbPrikaziLozinku_CheckedChanged);
            // 
            // lblUpozorenje
            // 
            this.lblUpozorenje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenje.AutoSize = true;
            this.lblUpozorenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenje.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUpozorenje.Location = new System.Drawing.Point(193, 211);
            this.lblUpozorenje.Name = "lblUpozorenje";
            this.lblUpozorenje.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenje.TabIndex = 15;
            // 
            // lblUpozorenjeEmail
            // 
            this.lblUpozorenjeEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenjeEmail.AutoSize = true;
            this.lblUpozorenjeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenjeEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.lblUpozorenjeEmail.Location = new System.Drawing.Point(193, 161);
            this.lblUpozorenjeEmail.Name = "lblUpozorenjeEmail";
            this.lblUpozorenjeEmail.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenjeEmail.TabIndex = 16;
            // 
            // FrmRegistracijaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(459, 461);
            this.Controls.Add(this.lblUpozorenjeEmail);
            this.Controls.Add(this.lblUpozorenje);
            this.Controls.Add(this.chbPrikaziLozinku);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnKreirajNalog);
            this.Controls.Add(this.lblLozinka2);
            this.Controls.Add(this.lblLozinka1);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtLozinka2);
            this.Controls.Add(this.txtLozinka1);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "FrmRegistracijaAdmin";
            this.Text = "Registruj se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtLozinka1;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka1;
        private System.Windows.Forms.Label lblLozinka2;
        private System.Windows.Forms.Button btnKreirajNalog;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.CheckBox chbPrikaziLozinku;
        private System.Windows.Forms.Label lblUpozorenje;
        private Label lblUpozorenjeEmail;

        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
        public TextBox TxtLozinka1 { get => txtLozinka1; set => txtLozinka1 = value; }
        public TextBox TxtLozinka2 { get => txtLozinka2; set => txtLozinka2 = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblKorisnickoIme { get => lblKorisnickoIme; set => lblKorisnickoIme = value; }
        public Label LblLozinka1 { get => lblLozinka1; set => lblLozinka1 = value; }
        public Label LblLozinka2 { get => lblLozinka2; set => lblLozinka2 = value; }
        public Button BtnKreirajNalog { get => btnKreirajNalog; set => btnKreirajNalog = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public CheckBox ChbPrikaziLozinku { get => chbPrikaziLozinku; set => chbPrikaziLozinku = value; }
        public Label LblUpozorenje { get => lblUpozorenje; set => lblUpozorenje = value; }
        public Label LblUpozorenjeEmail { get => lblUpozorenjeEmail; set => lblUpozorenjeEmail = value; }
    }
}