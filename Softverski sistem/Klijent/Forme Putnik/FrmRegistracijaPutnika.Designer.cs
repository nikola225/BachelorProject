using System.Windows.Forms;

namespace Klijent.Forme_Putnik
{
    partial class FrmRegistracijaPutnika
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
            this.lblUpozorenjeUsername = new System.Windows.Forms.Label();
            this.chbPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblLozinka2 = new System.Windows.Forms.Label();
            this.lblLozinka1 = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblBrojPasosa = new System.Windows.Forms.Label();
            this.txtBrojPasosa = new System.Windows.Forms.TextBox();
            this.lblUpozorenjeJMBG = new System.Windows.Forms.Label();
            this.lblUpozorenjeBrPasosa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUpozorenjeUsername
            // 
            this.lblUpozorenjeUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenjeUsername.AutoSize = true;
            this.lblUpozorenjeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenjeUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenjeUsername.Location = new System.Drawing.Point(236, 304);
            this.lblUpozorenjeUsername.Name = "lblUpozorenjeUsername";
            this.lblUpozorenjeUsername.Size = new System.Drawing.Size(126, 13);
            this.lblUpozorenjeUsername.TabIndex = 31;
            this.lblUpozorenjeUsername.Text = "Korisničko ime već postoji";
            // 
            // chbPrikaziLozinku
            // 
            this.chbPrikaziLozinku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbPrikaziLozinku.AutoSize = true;
            this.chbPrikaziLozinku.Location = new System.Drawing.Point(188, 386);
            this.chbPrikaziLozinku.Name = "chbPrikaziLozinku";
            this.chbPrikaziLozinku.Size = new System.Drawing.Size(113, 20);
            this.chbPrikaziLozinku.TabIndex = 30;
            this.chbPrikaziLozinku.Text = "Prikaži lozinku";
            this.chbPrikaziLozinku.UseVisualStyleBackColor = true;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(188, 462);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(174, 31);
            this.btnOtkazi.TabIndex = 29;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(188, 425);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(174, 31);
            this.btnSacuvaj.TabIndex = 28;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblLozinka2
            // 
            this.lblLozinka2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka2.AutoSize = true;
            this.lblLozinka2.Location = new System.Drawing.Point(86, 363);
            this.lblLozinka2.Name = "lblLozinka2";
            this.lblLozinka2.Size = new System.Drawing.Size(96, 16);
            this.lblLozinka2.TabIndex = 27;
            this.lblLozinka2.Text = "Potvrdi lozinku:";
            // 
            // lblLozinka1
            // 
            this.lblLozinka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka1.AutoSize = true;
            this.lblLozinka1.Location = new System.Drawing.Point(123, 335);
            this.lblLozinka1.Name = "lblLozinka1";
            this.lblLozinka1.Size = new System.Drawing.Size(56, 16);
            this.lblLozinka1.TabIndex = 26;
            this.lblLozinka1.Text = "Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(82, 285);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(97, 16);
            this.lblKorisnickoIme.TabIndex = 25;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(131, 257);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(123, 96);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 23;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(147, 68);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 22;
            this.lblIme.Text = "Ime:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka2.Location = new System.Drawing.Point(188, 357);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.Size = new System.Drawing.Size(174, 22);
            this.txtLozinka2.TabIndex = 21;
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka1.Location = new System.Drawing.Point(188, 329);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.Size = new System.Drawing.Size(174, 22);
            this.txtLozinka1.TabIndex = 20;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(188, 279);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(174, 22);
            this.txtKorisnickoIme.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(188, 251);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(188, 90);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(174, 22);
            this.txtPrezime.TabIndex = 17;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(188, 62);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(174, 22);
            this.txtIme.TabIndex = 16;
            // 
            // lblJMBG
            // 
            this.lblJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(132, 124);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(47, 16);
            this.lblJMBG.TabIndex = 35;
            this.lblJMBG.Text = "JMBG:";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(97, 229);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(85, 16);
            this.lblBrojTelefona.TabIndex = 34;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBG.Location = new System.Drawing.Point(188, 118);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(174, 22);
            this.txtJMBG.TabIndex = 33;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojTelefona.Location = new System.Drawing.Point(188, 223);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(174, 22);
            this.txtBrojTelefona.TabIndex = 32;
            // 
            // lblBrojPasosa
            // 
            this.lblBrojPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojPasosa.AutoSize = true;
            this.lblBrojPasosa.Location = new System.Drawing.Point(96, 175);
            this.lblBrojPasosa.Name = "lblBrojPasosa";
            this.lblBrojPasosa.Size = new System.Drawing.Size(83, 16);
            this.lblBrojPasosa.TabIndex = 37;
            this.lblBrojPasosa.Text = "Broj pasoša:";
            // 
            // txtBrojPasosa
            // 
            this.txtBrojPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPasosa.Location = new System.Drawing.Point(188, 169);
            this.txtBrojPasosa.Name = "txtBrojPasosa";
            this.txtBrojPasosa.Size = new System.Drawing.Size(174, 22);
            this.txtBrojPasosa.TabIndex = 36;
            // 
            // lblUpozorenjeJMBG
            // 
            this.lblUpozorenjeJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenjeJMBG.AutoSize = true;
            this.lblUpozorenjeJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenjeJMBG.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenjeJMBG.Location = new System.Drawing.Point(195, 143);
            this.lblUpozorenjeJMBG.Name = "lblUpozorenjeJMBG";
            this.lblUpozorenjeJMBG.Size = new System.Drawing.Size(167, 13);
            this.lblUpozorenjeJMBG.TabIndex = 38;
            this.lblUpozorenjeJMBG.Text = "Korisnik sa ovim JMBG već postoji";
            // 
            // lblUpozorenjeBrPasosa
            // 
            this.lblUpozorenjeBrPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenjeBrPasosa.AutoSize = true;
            this.lblUpozorenjeBrPasosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenjeBrPasosa.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenjeBrPasosa.Location = new System.Drawing.Point(156, 194);
            this.lblUpozorenjeBrPasosa.Name = "lblUpozorenjeBrPasosa";
            this.lblUpozorenjeBrPasosa.Size = new System.Drawing.Size(206, 13);
            this.lblUpozorenjeBrPasosa.TabIndex = 39;
            this.lblUpozorenjeBrPasosa.Text = "Korisnik sa ovim brojem pasoša već postoji";
            // 
            // FrmRegistracijaPutnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 551);
            this.Controls.Add(this.lblUpozorenjeBrPasosa);
            this.Controls.Add(this.lblUpozorenjeJMBG);
            this.Controls.Add(this.lblBrojPasosa);
            this.Controls.Add(this.txtBrojPasosa);
            this.Controls.Add(this.lblJMBG);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.lblUpozorenjeUsername);
            this.Controls.Add(this.chbPrikaziLozinku);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnSacuvaj);
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
            this.Name = "FrmRegistracijaPutnika";
            this.Text = "Registruj se!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpozorenjeUsername;
        private System.Windows.Forms.CheckBox chbPrikaziLozinku;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblLozinka2;
        private System.Windows.Forms.Label lblLozinka1;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.TextBox txtLozinka1;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblBrojPasosa;
        private System.Windows.Forms.TextBox txtBrojPasosa;
        private System.Windows.Forms.Label lblUpozorenjeJMBG;
        private System.Windows.Forms.Label lblUpozorenjeBrPasosa;

        public Label LblUpozorenjeUsername { get => lblUpozorenjeUsername; set => lblUpozorenjeUsername = value; }
        public CheckBox ChbPrikaziLozinku { get => chbPrikaziLozinku; set => chbPrikaziLozinku = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Label LblLozinka2 { get => lblLozinka2; set => lblLozinka2 = value; }
        public Label LblLozinka1 { get => lblLozinka1; set => lblLozinka1 = value; }
        public Label LblKorisnickoIme { get => lblKorisnickoIme; set => lblKorisnickoIme = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public TextBox TxtLozinka2 { get => txtLozinka2; set => txtLozinka2 = value; }
        public TextBox TxtLozinka1 { get => txtLozinka1; set => txtLozinka1 = value; }
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label LblJMBG { get => lblJMBG; set => lblJMBG = value; }
        public Label LblBrojTelefona { get => lblBrojTelefona; set => lblBrojTelefona = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public TextBox TxtBrojTelefona { get => txtBrojTelefona; set => txtBrojTelefona = value; }
        public Label LblBrojPasosa { get => lblBrojPasosa; set => lblBrojPasosa = value; }
        public TextBox TxtBrojPasosa { get => txtBrojPasosa; set => txtBrojPasosa = value; }
        public Label LblUpozorenjeJMBG { get => lblUpozorenjeJMBG; set => lblUpozorenjeJMBG = value; }
        public Label LblUpozorenjeBrPasosa { get => lblUpozorenjeBrPasosa; set => lblUpozorenjeBrPasosa = value; }
    }
}