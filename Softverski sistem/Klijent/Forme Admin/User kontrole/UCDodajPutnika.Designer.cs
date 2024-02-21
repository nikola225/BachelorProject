using System.Windows.Forms;

namespace Klijent.Forme_Admin.User_kontrole
{
    partial class UCDodajPutnika
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
            this.lblUpozorenjeBrPasosa = new System.Windows.Forms.Label();
            this.lblUpozorenjeJMBG = new System.Windows.Forms.Label();
            this.lblBrojPasosa = new System.Windows.Forms.Label();
            this.txtBrojPasosa = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpozorenjeEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUpozorenjeBrPasosa
            // 
            this.lblUpozorenjeBrPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenjeBrPasosa.AutoSize = true;
            this.lblUpozorenjeBrPasosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenjeBrPasosa.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenjeBrPasosa.Location = new System.Drawing.Point(154, 246);
            this.lblUpozorenjeBrPasosa.Name = "lblUpozorenjeBrPasosa";
            this.lblUpozorenjeBrPasosa.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenjeBrPasosa.TabIndex = 63;
            // 
            // lblUpozorenjeJMBG
            // 
            this.lblUpozorenjeJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenjeJMBG.AutoSize = true;
            this.lblUpozorenjeJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenjeJMBG.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenjeJMBG.Location = new System.Drawing.Point(193, 201);
            this.lblUpozorenjeJMBG.Name = "lblUpozorenjeJMBG";
            this.lblUpozorenjeJMBG.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenjeJMBG.TabIndex = 62;
            // 
            // lblBrojPasosa
            // 
            this.lblBrojPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojPasosa.AutoSize = true;
            this.lblBrojPasosa.Location = new System.Drawing.Point(94, 227);
            this.lblBrojPasosa.Name = "lblBrojPasosa";
            this.lblBrojPasosa.Size = new System.Drawing.Size(83, 16);
            this.lblBrojPasosa.TabIndex = 61;
            this.lblBrojPasosa.Text = "Broj pasoša:";
            // 
            // txtBrojPasosa
            // 
            this.txtBrojPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPasosa.Location = new System.Drawing.Point(196, 221);
            this.txtBrojPasosa.Name = "txtBrojPasosa";
            this.txtBrojPasosa.Size = new System.Drawing.Size(174, 22);
            this.txtBrojPasosa.TabIndex = 60;
            this.txtBrojPasosa.TextChanged += new System.EventHandler(this.txtBrojPasosa_TextChanged);
            // 
            // lblJMBG
            // 
            this.lblJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(130, 182);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(47, 16);
            this.lblJMBG.TabIndex = 59;
            this.lblJMBG.Text = "JMBG:";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(95, 273);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(85, 16);
            this.lblBrojTelefona.TabIndex = 58;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBG.Location = new System.Drawing.Point(196, 176);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(174, 22);
            this.txtJMBG.TabIndex = 57;
            this.txtJMBG.TextChanged += new System.EventHandler(this.txtJMBG_TextChanged);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojTelefona.Location = new System.Drawing.Point(196, 267);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(174, 22);
            this.txtBrojTelefona.TabIndex = 56;
            this.txtBrojTelefona.TextChanged += new System.EventHandler(this.txtBrojTelefona_TextChanged);
            // 
            // lblUpozorenjeUsername
            // 
            this.lblUpozorenjeUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenjeUsername.AutoSize = true;
            this.lblUpozorenjeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenjeUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenjeUsername.Location = new System.Drawing.Point(244, 376);
            this.lblUpozorenjeUsername.Name = "lblUpozorenjeUsername";
            this.lblUpozorenjeUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenjeUsername.TabIndex = 55;
            // 
            // chbPrikaziLozinku
            // 
            this.chbPrikaziLozinku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbPrikaziLozinku.AutoSize = true;
            this.chbPrikaziLozinku.Location = new System.Drawing.Point(196, 459);
            this.chbPrikaziLozinku.Name = "chbPrikaziLozinku";
            this.chbPrikaziLozinku.Size = new System.Drawing.Size(113, 20);
            this.chbPrikaziLozinku.TabIndex = 54;
            this.chbPrikaziLozinku.Text = "Prikaži lozinku";
            this.chbPrikaziLozinku.UseVisualStyleBackColor = true;
            this.chbPrikaziLozinku.CheckedChanged += new System.EventHandler(this.chbPrikaziLozinku_CheckedChanged);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(196, 536);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(174, 31);
            this.btnOtkazi.TabIndex = 53;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(196, 499);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(174, 31);
            this.btnSacuvaj.TabIndex = 52;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblLozinka2
            // 
            this.lblLozinka2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka2.AutoSize = true;
            this.lblLozinka2.Location = new System.Drawing.Point(84, 437);
            this.lblLozinka2.Name = "lblLozinka2";
            this.lblLozinka2.Size = new System.Drawing.Size(96, 16);
            this.lblLozinka2.TabIndex = 51;
            this.lblLozinka2.Text = "Potvrdi lozinku:";
            // 
            // lblLozinka1
            // 
            this.lblLozinka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka1.AutoSize = true;
            this.lblLozinka1.Location = new System.Drawing.Point(121, 397);
            this.lblLozinka1.Name = "lblLozinka1";
            this.lblLozinka1.Size = new System.Drawing.Size(56, 16);
            this.lblLozinka1.TabIndex = 50;
            this.lblLozinka1.Text = "Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(80, 357);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(97, 16);
            this.lblKorisnickoIme.TabIndex = 49;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(129, 316);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 48;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(121, 136);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 47;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(145, 95);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 46;
            this.lblIme.Text = "Ime:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka2.Location = new System.Drawing.Point(196, 431);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.PasswordChar = '*';
            this.txtLozinka2.Size = new System.Drawing.Size(174, 22);
            this.txtLozinka2.TabIndex = 45;
            this.txtLozinka2.TextChanged += new System.EventHandler(this.txtLozinka2_TextChanged);
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka1.Location = new System.Drawing.Point(196, 391);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.PasswordChar = '*';
            this.txtLozinka1.Size = new System.Drawing.Size(174, 22);
            this.txtLozinka1.TabIndex = 44;
            this.txtLozinka1.TextChanged += new System.EventHandler(this.txtLozinka1_TextChanged);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(196, 351);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(174, 22);
            this.txtKorisnickoIme.TabIndex = 43;
            this.txtKorisnickoIme.TextChanged += new System.EventHandler(this.txtKorisnickoIme_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(196, 310);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 22);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(196, 130);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(174, 22);
            this.txtPrezime.TabIndex = 41;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(196, 89);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(174, 22);
            this.txtIme.TabIndex = 40;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(152, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "Dodaj novog putnika";
            // 
            // lblUpozorenjeEmail
            // 
            this.lblUpozorenjeEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpozorenjeEmail.AutoSize = true;
            this.lblUpozorenjeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUpozorenjeEmail.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenjeEmail.Location = new System.Drawing.Point(244, 335);
            this.lblUpozorenjeEmail.Name = "lblUpozorenjeEmail";
            this.lblUpozorenjeEmail.Size = new System.Drawing.Size(0, 13);
            this.lblUpozorenjeEmail.TabIndex = 65;
            // 
            // UCDodajPutnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblUpozorenjeEmail);
            this.Controls.Add(this.label1);
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
            this.Name = "UCDodajPutnika";
            this.Size = new System.Drawing.Size(523, 629);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpozorenjeBrPasosa;
        private System.Windows.Forms.Label lblUpozorenjeJMBG;
        private System.Windows.Forms.Label lblBrojPasosa;
        private System.Windows.Forms.TextBox txtBrojPasosa;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtBrojTelefona;
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
        private System.Windows.Forms.Label label1;
        private Label lblUpozorenjeEmail;

        public Label LblUpozorenjeBrPasosa { get => lblUpozorenjeBrPasosa; set => lblUpozorenjeBrPasosa = value; }
        public Label LblUpozorenjeJMBG { get => lblUpozorenjeJMBG; set => lblUpozorenjeJMBG = value; }
        public Label LblBrojPasosa { get => lblBrojPasosa; set => lblBrojPasosa = value; }
        public TextBox TxtBrojPasosa { get => txtBrojPasosa; set => txtBrojPasosa = value; }
        public Label LblJMBG { get => lblJMBG; set => lblJMBG = value; }
        public Label LblBrojTelefona { get => lblBrojTelefona; set => lblBrojTelefona = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public TextBox TxtBrojTelefona { get => txtBrojTelefona; set => txtBrojTelefona = value; }
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
        public Label Label1 { get => label1; set => label1 = value; }
        public Label LblUpozorenjeEmail { get => lblUpozorenjeEmail; set => lblUpozorenjeEmail = value; }
    }
}
