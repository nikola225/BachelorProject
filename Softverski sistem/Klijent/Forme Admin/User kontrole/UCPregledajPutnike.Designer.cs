using System.Windows.Forms;

namespace Klijent.Forme_Admin.User_kontrole
{
    partial class UCPregledajPutnike
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
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.btnObrisiPutnika = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnIzmeniPutnika = new System.Windows.Forms.Button();
            this.dgvPrikaziPutnike = new System.Windows.Forms.DataGridView();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.lblBrojPasosa = new System.Windows.Forms.Label();
            this.txtBrojPasosa = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblLozinka1 = new System.Windows.Forms.Label();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnIzvezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaziPutnike)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(142, 73);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(101, 16);
            this.lblPretrazi.TabIndex = 50;
            this.lblPretrazi.Text = "Pretraži putnike:";
            // 
            // btnObrisiPutnika
            // 
            this.btnObrisiPutnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiPutnika.Enabled = false;
            this.btnObrisiPutnika.Location = new System.Drawing.Point(749, 626);
            this.btnObrisiPutnika.Name = "btnObrisiPutnika";
            this.btnObrisiPutnika.Size = new System.Drawing.Size(200, 37);
            this.btnObrisiPutnika.TabIndex = 49;
            this.btnObrisiPutnika.Text = "Obriši putnika";
            this.btnObrisiPutnika.UseVisualStyleBackColor = true;
            this.btnObrisiPutnika.Click += new System.EventHandler(this.btnObrisiPutnika_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretrazi.Location = new System.Drawing.Point(145, 92);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(374, 22);
            this.txtPretrazi.TabIndex = 48;
            // 
            // btnIzmeniPutnika
            // 
            this.btnIzmeniPutnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniPutnika.Enabled = false;
            this.btnIzmeniPutnika.Location = new System.Drawing.Point(749, 583);
            this.btnIzmeniPutnika.Name = "btnIzmeniPutnika";
            this.btnIzmeniPutnika.Size = new System.Drawing.Size(200, 37);
            this.btnIzmeniPutnika.TabIndex = 47;
            this.btnIzmeniPutnika.Text = "Izmeni putnika";
            this.btnIzmeniPutnika.UseVisualStyleBackColor = true;
            this.btnIzmeniPutnika.Click += new System.EventHandler(this.btnIzmeniPutnika_Click);
            // 
            // dgvPrikaziPutnike
            // 
            this.dgvPrikaziPutnike.AllowUserToAddRows = false;
            this.dgvPrikaziPutnike.AllowUserToDeleteRows = false;
            this.dgvPrikaziPutnike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrikaziPutnike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaziPutnike.Location = new System.Drawing.Point(145, 131);
            this.dgvPrikaziPutnike.Name = "dgvPrikaziPutnike";
            this.dgvPrikaziPutnike.ReadOnly = true;
            this.dgvPrikaziPutnike.RowHeadersWidth = 51;
            this.dgvPrikaziPutnike.RowTemplate.Height = 24;
            this.dgvPrikaziPutnike.Size = new System.Drawing.Size(804, 214);
            this.dgvPrikaziPutnike.TabIndex = 46;
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(749, 366);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(200, 37);
            this.btnPrikaziDetalje.TabIndex = 45;
            this.btnPrikaziDetalje.Text = "Prikaži detalje";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // lblBrojPasosa
            // 
            this.lblBrojPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojPasosa.AutoSize = true;
            this.lblBrojPasosa.Location = new System.Drawing.Point(71, 132);
            this.lblBrojPasosa.Name = "lblBrojPasosa";
            this.lblBrojPasosa.Size = new System.Drawing.Size(83, 16);
            this.lblBrojPasosa.TabIndex = 67;
            this.lblBrojPasosa.Text = "Broj pasoša:";
            // 
            // txtBrojPasosa
            // 
            this.txtBrojPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPasosa.Location = new System.Drawing.Point(173, 126);
            this.txtBrojPasosa.Name = "txtBrojPasosa";
            this.txtBrojPasosa.ReadOnly = true;
            this.txtBrojPasosa.Size = new System.Drawing.Size(211, 22);
            this.txtBrojPasosa.TabIndex = 66;
            this.txtBrojPasosa.TextChanged += new System.EventHandler(this.txtBrojPasosa_TextChanged);
            // 
            // lblJMBG
            // 
            this.lblJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(107, 104);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(47, 16);
            this.lblJMBG.TabIndex = 65;
            this.lblJMBG.Text = "JMBG:";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(72, 160);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(85, 16);
            this.lblBrojTelefona.TabIndex = 64;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBG.Location = new System.Drawing.Point(173, 98);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.ReadOnly = true;
            this.txtJMBG.Size = new System.Drawing.Size(211, 22);
            this.txtJMBG.TabIndex = 63;
            this.txtJMBG.TextChanged += new System.EventHandler(this.txtJMBG_TextChanged);
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojTelefona.Location = new System.Drawing.Point(173, 154);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.ReadOnly = true;
            this.txtBrojTelefona.Size = new System.Drawing.Size(211, 22);
            this.txtBrojTelefona.TabIndex = 62;
            this.txtBrojTelefona.TextChanged += new System.EventHandler(this.txtBrojTelefona_TextChanged);
            // 
            // lblLozinka1
            // 
            this.lblLozinka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLozinka1.AutoSize = true;
            this.lblLozinka1.Location = new System.Drawing.Point(98, 246);
            this.lblLozinka1.Name = "lblLozinka1";
            this.lblLozinka1.Size = new System.Drawing.Size(56, 16);
            this.lblLozinka1.TabIndex = 60;
            this.lblLozinka1.Text = "Lozinka:";
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(57, 216);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(97, 16);
            this.lblKorisnickoIme.TabIndex = 59;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(106, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(98, 76);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 57;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(122, 48);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 56;
            this.lblIme.Text = "Ime:";
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLozinka1.Location = new System.Drawing.Point(173, 240);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.PasswordChar = '*';
            this.txtLozinka1.ReadOnly = true;
            this.txtLozinka1.Size = new System.Drawing.Size(211, 22);
            this.txtLozinka1.TabIndex = 55;
            this.txtLozinka1.TextChanged += new System.EventHandler(this.txtLozinka1_TextChanged);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(173, 210);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.ReadOnly = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(211, 22);
            this.txtKorisnickoIme.TabIndex = 54;
            this.txtKorisnickoIme.TextChanged += new System.EventHandler(this.txtKorisnickoIme_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(173, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(211, 22);
            this.txtEmail.TabIndex = 53;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(173, 70);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(211, 22);
            this.txtPrezime.TabIndex = 52;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(173, 42);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(211, 22);
            this.txtIme.TabIndex = 51;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.lblBrojPasosa);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtBrojPasosa);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblJMBG);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.lblBrojTelefona);
            this.groupBox1.Controls.Add(this.txtLozinka1);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.txtBrojTelefona);
            this.groupBox1.Controls.Add(this.lblPrezime);
            this.groupBox1.Controls.Add(this.lblLozinka1);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblKorisnickoIme);
            this.groupBox1.Location = new System.Drawing.Point(147, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 297);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o putniku";
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajIzmene.Enabled = false;
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(749, 540);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(200, 37);
            this.btnSacuvajIzmene.TabIndex = 71;
            this.btnSacuvajIzmene.Text = "Sačuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(533, 89);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(78, 29);
            this.btnPretrazi.TabIndex = 72;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetuj.Location = new System.Drawing.Point(617, 89);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(72, 29);
            this.btnResetuj.TabIndex = 73;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // btnIzvezi
            // 
            this.btnIzvezi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzvezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvezi.Location = new System.Drawing.Point(885, 89);
            this.btnIzvezi.Name = "btnIzvezi";
            this.btnIzvezi.Size = new System.Drawing.Size(64, 29);
            this.btnIzvezi.TabIndex = 108;
            this.btnIzvezi.Text = "Izvezi";
            this.btnIzvezi.UseVisualStyleBackColor = true;
            this.btnIzvezi.Click += new System.EventHandler(this.btnIzvezi_Click);
            // 
            // UCPregledajPutnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnIzvezi);
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.btnObrisiPutnika);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnIzmeniPutnika);
            this.Controls.Add(this.dgvPrikaziPutnike);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Name = "UCPregledajPutnike";
            this.Size = new System.Drawing.Size(1113, 734);
            this.Load += new System.EventHandler(this.UCPregledajPutnike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaziPutnike)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.Button btnObrisiPutnika;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnIzmeniPutnika;
        private System.Windows.Forms.DataGridView dgvPrikaziPutnike;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.Label lblBrojPasosa;
        private System.Windows.Forms.TextBox txtBrojPasosa;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblLozinka1;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtLozinka1;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.GroupBox groupBox1;
        private Button btnSacuvajIzmene;
        private Button btnPretrazi;
        private Button btnResetuj;
        private Button btnIzvezi;

        public Label LblPretrazi { get => lblPretrazi; set => lblPretrazi = value; }
        public Button BtnObrisiPutnika { get => btnObrisiPutnika; set => btnObrisiPutnika = value; }
        public TextBox TxtPretrazi { get => txtPretrazi; set => txtPretrazi = value; }
        public Button BtnIzmeniPutnika { get => btnIzmeniPutnika; set => btnIzmeniPutnika = value; }
        public DataGridView DgvPrikaziPutnike { get => dgvPrikaziPutnike; set => dgvPrikaziPutnike = value; }
        public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
        public Label LblBrojPasosa { get => lblBrojPasosa; set => lblBrojPasosa = value; }
        public TextBox TxtBrojPasosa { get => txtBrojPasosa; set => txtBrojPasosa = value; }
        public Label LblJMBG { get => lblJMBG; set => lblJMBG = value; }
        public Label LblBrojTelefona { get => lblBrojTelefona; set => lblBrojTelefona = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public TextBox TxtBrojTelefona { get => txtBrojTelefona; set => txtBrojTelefona = value; }
        public Label LblLozinka1 { get => lblLozinka1; set => lblLozinka1 = value; }
        public Label LblKorisnickoIme { get => lblKorisnickoIme; set => lblKorisnickoIme = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public TextBox TxtLozinka1 { get => txtLozinka1; set => txtLozinka1 = value; }
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Button BtnSacuvajIzmene { get => btnSacuvajIzmene; set => btnSacuvajIzmene = value; }
        public Button BtnIzvezi { get => btnIzvezi; set => btnIzvezi = value; }
    }
}
