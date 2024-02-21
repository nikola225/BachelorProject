using System.Windows.Forms;

namespace Klijent.Forme_Admin.User_kontrole
{
    partial class UCPregledajRezervacije
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
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdAranzmana = new System.Windows.Forms.TextBox();
            this.lblIdAranzmana = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.txtBrojRezervacije = new System.Windows.Forms.TextBox();
            this.lblBrojRezervacije = new System.Windows.Forms.Label();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtBrojPasosa = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblBrojPasosa = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.txtDatumDo = new System.Windows.Forms.TextBox();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.txtDatumOd = new System.Windows.Forms.TextBox();
            this.cbTipPrevoza = new System.Windows.Forms.ComboBox();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.lblDestinacija = new System.Windows.Forms.Label();
            this.cbDestinacija = new System.Windows.Forms.ComboBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblTipPrevoza = new System.Windows.Forms.Label();
            this.btnResetuj1 = new System.Windows.Forms.Button();
            this.btnPretrazi1 = new System.Windows.Forms.Button();
            this.dgvPregledajRezervacije = new System.Windows.Forms.DataGridView();
            this.lblPretrazi1 = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPromeniPutnika = new System.Windows.Forms.Button();
            this.btnPromeniAranzman = new System.Windows.Forms.Button();
            this.btnSacuvajPromene = new System.Windows.Forms.Button();
            this.btnObrisiRezervaciju = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledajRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziDetalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(956, 318);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(142, 37);
            this.btnPrikaziDetalje.TabIndex = 96;
            this.btnPrikaziDetalje.Text = "Prikaži detalje";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtIdAranzmana);
            this.groupBox1.Controls.Add(this.lblIdAranzmana);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.lblKorisnickoIme);
            this.groupBox1.Controls.Add(this.txtBrojRezervacije);
            this.groupBox1.Controls.Add(this.lblBrojRezervacije);
            this.groupBox1.Controls.Add(this.txtBrojTelefona);
            this.groupBox1.Controls.Add(this.lblBrojTelefona);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.txtBrojPasosa);
            this.groupBox1.Controls.Add(this.lblJMBG);
            this.groupBox1.Controls.Add(this.lblBrojPasosa);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.lblPrezime);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblDatumDo);
            this.groupBox1.Controls.Add(this.txtDatumDo);
            this.groupBox1.Controls.Add(this.lblDatumOd);
            this.groupBox1.Controls.Add(this.txtDatumOd);
            this.groupBox1.Controls.Add(this.cbTipPrevoza);
            this.groupBox1.Controls.Add(this.rtxtOpis);
            this.groupBox1.Controls.Add(this.lblDestinacija);
            this.groupBox1.Controls.Add(this.cbDestinacija);
            this.groupBox1.Controls.Add(this.lblOpis);
            this.groupBox1.Controls.Add(this.lblCena);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.lblTipPrevoza);
            this.groupBox1.Location = new System.Drawing.Point(105, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 389);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o rezervaciji:";
            // 
            // txtIdAranzmana
            // 
            this.txtIdAranzmana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdAranzmana.Location = new System.Drawing.Point(558, 51);
            this.txtIdAranzmana.Name = "txtIdAranzmana";
            this.txtIdAranzmana.PasswordChar = '*';
            this.txtIdAranzmana.ReadOnly = true;
            this.txtIdAranzmana.Size = new System.Drawing.Size(200, 22);
            this.txtIdAranzmana.TabIndex = 110;
            // 
            // lblIdAranzmana
            // 
            this.lblIdAranzmana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdAranzmana.AutoSize = true;
            this.lblIdAranzmana.Location = new System.Drawing.Point(449, 54);
            this.lblIdAranzmana.Name = "lblIdAranzmana";
            this.lblIdAranzmana.Size = new System.Drawing.Size(92, 16);
            this.lblIdAranzmana.TabIndex = 109;
            this.lblIdAranzmana.Text = "Id Aranžmana:";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(162, 54);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.PasswordChar = '*';
            this.txtKorisnickoIme.ReadOnly = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(160, 22);
            this.txtKorisnickoIme.TabIndex = 108;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(47, 57);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(97, 16);
            this.lblKorisnickoIme.TabIndex = 107;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // txtBrojRezervacije
            // 
            this.txtBrojRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojRezervacije.Location = new System.Drawing.Point(162, 91);
            this.txtBrojRezervacije.Name = "txtBrojRezervacije";
            this.txtBrojRezervacije.ReadOnly = true;
            this.txtBrojRezervacije.Size = new System.Drawing.Size(160, 22);
            this.txtBrojRezervacije.TabIndex = 106;
            // 
            // lblBrojRezervacije
            // 
            this.lblBrojRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojRezervacije.AutoSize = true;
            this.lblBrojRezervacije.Location = new System.Drawing.Point(41, 94);
            this.lblBrojRezervacije.Name = "lblBrojRezervacije";
            this.lblBrojRezervacije.Size = new System.Drawing.Size(103, 16);
            this.lblBrojRezervacije.TabIndex = 105;
            this.lblBrojRezervacije.Text = "Broj rezervacije:";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojTelefona.Location = new System.Drawing.Point(162, 323);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.ReadOnly = true;
            this.txtBrojTelefona.Size = new System.Drawing.Size(160, 22);
            this.txtBrojTelefona.TabIndex = 104;
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(59, 329);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(85, 16);
            this.lblBrojTelefona.TabIndex = 103;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJMBG.Location = new System.Drawing.Point(162, 207);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.ReadOnly = true;
            this.txtJMBG.Size = new System.Drawing.Size(160, 22);
            this.txtJMBG.TabIndex = 102;
            // 
            // txtBrojPasosa
            // 
            this.txtBrojPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrojPasosa.Location = new System.Drawing.Point(162, 249);
            this.txtBrojPasosa.Name = "txtBrojPasosa";
            this.txtBrojPasosa.ReadOnly = true;
            this.txtBrojPasosa.Size = new System.Drawing.Size(160, 22);
            this.txtBrojPasosa.TabIndex = 101;
            // 
            // lblJMBG
            // 
            this.lblJMBG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(97, 213);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(47, 16);
            this.lblJMBG.TabIndex = 100;
            this.lblJMBG.Text = "JMBG:";
            // 
            // lblBrojPasosa
            // 
            this.lblBrojPasosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBrojPasosa.AutoSize = true;
            this.lblBrojPasosa.Location = new System.Drawing.Point(60, 255);
            this.lblBrojPasosa.Name = "lblBrojPasosa";
            this.lblBrojPasosa.Size = new System.Drawing.Size(84, 16);
            this.lblBrojPasosa.TabIndex = 99;
            this.lblBrojPasosa.Text = "Broj Pasoša:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(162, 286);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(160, 22);
            this.txtEmail.TabIndex = 98;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrezime.Location = new System.Drawing.Point(162, 170);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(160, 22);
            this.txtPrezime.TabIndex = 97;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIme.Location = new System.Drawing.Point(162, 130);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(160, 22);
            this.txtIme.TabIndex = 96;
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(85, 176);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 95;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(112, 136);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 94;
            this.lblIme.Text = "Ime:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(100, 292);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 93;
            this.lblEmail.Text = "Email:";
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(436, 252);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(105, 16);
            this.lblDatumDo.TabIndex = 47;
            this.lblDatumDo.Text = "Datum povratka:";
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumDo.Location = new System.Drawing.Point(558, 246);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.ReadOnly = true;
            this.txtDatumDo.Size = new System.Drawing.Size(200, 22);
            this.txtDatumDo.TabIndex = 48;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(440, 215);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(101, 16);
            this.lblDatumOd.TabIndex = 45;
            this.lblDatumOd.Text = "Datum polaska:";
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumOd.Location = new System.Drawing.Point(558, 209);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.ReadOnly = true;
            this.txtDatumOd.Size = new System.Drawing.Size(200, 22);
            this.txtDatumOd.TabIndex = 46;
            // 
            // cbTipPrevoza
            // 
            this.cbTipPrevoza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipPrevoza.Enabled = false;
            this.cbTipPrevoza.FormattingEnabled = true;
            this.cbTipPrevoza.Location = new System.Drawing.Point(558, 167);
            this.cbTipPrevoza.Name = "cbTipPrevoza";
            this.cbTipPrevoza.Size = new System.Drawing.Size(200, 24);
            this.cbTipPrevoza.TabIndex = 43;
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtOpis.Location = new System.Drawing.Point(558, 286);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.ReadOnly = true;
            this.rtxtOpis.Size = new System.Drawing.Size(200, 77);
            this.rtxtOpis.TabIndex = 44;
            this.rtxtOpis.Text = "";
            // 
            // lblDestinacija
            // 
            this.lblDestinacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDestinacija.AutoSize = true;
            this.lblDestinacija.Location = new System.Drawing.Point(464, 95);
            this.lblDestinacija.Name = "lblDestinacija";
            this.lblDestinacija.Size = new System.Drawing.Size(77, 16);
            this.lblDestinacija.TabIndex = 34;
            this.lblDestinacija.Text = "Destinacija:";
            // 
            // cbDestinacija
            // 
            this.cbDestinacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDestinacija.Enabled = false;
            this.cbDestinacija.FormattingEnabled = true;
            this.cbDestinacija.Location = new System.Drawing.Point(558, 86);
            this.cbDestinacija.Name = "cbDestinacija";
            this.cbDestinacija.Size = new System.Drawing.Size(200, 24);
            this.cbDestinacija.TabIndex = 42;
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(503, 286);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(38, 16);
            this.lblOpis.TabIndex = 35;
            this.lblOpis.Text = "Opis:";
            // 
            // lblCena
            // 
            this.lblCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(499, 136);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(42, 16);
            this.lblCena.TabIndex = 36;
            this.lblCena.Text = "Cena:";
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.Location = new System.Drawing.Point(558, 130);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(67, 22);
            this.txtCena.TabIndex = 40;
            // 
            // lblTipPrevoza
            // 
            this.lblTipPrevoza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipPrevoza.AutoSize = true;
            this.lblTipPrevoza.Location = new System.Drawing.Point(459, 175);
            this.lblTipPrevoza.Name = "lblTipPrevoza";
            this.lblTipPrevoza.Size = new System.Drawing.Size(82, 16);
            this.lblTipPrevoza.TabIndex = 38;
            this.lblTipPrevoza.Text = "Tip prevoza:";
            // 
            // btnResetuj1
            // 
            this.btnResetuj1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetuj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetuj1.Location = new System.Drawing.Point(407, 74);
            this.btnResetuj1.Name = "btnResetuj1";
            this.btnResetuj1.Size = new System.Drawing.Size(64, 29);
            this.btnResetuj1.TabIndex = 93;
            this.btnResetuj1.Text = "Resetuj";
            this.btnResetuj1.UseVisualStyleBackColor = true;
            this.btnResetuj1.Click += new System.EventHandler(this.btnResetuj1_Click);
            // 
            // btnPretrazi1
            // 
            this.btnPretrazi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi1.Location = new System.Drawing.Point(333, 74);
            this.btnPretrazi1.Name = "btnPretrazi1";
            this.btnPretrazi1.Size = new System.Drawing.Size(68, 29);
            this.btnPretrazi1.TabIndex = 92;
            this.btnPretrazi1.Text = "Pretraži";
            this.btnPretrazi1.UseVisualStyleBackColor = true;
            this.btnPretrazi1.Click += new System.EventHandler(this.btnPretrazi1_Click);
            // 
            // dgvPregledajRezervacije
            // 
            this.dgvPregledajRezervacije.AllowUserToAddRows = false;
            this.dgvPregledajRezervacije.AllowUserToDeleteRows = false;
            this.dgvPregledajRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPregledajRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledajRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledajRezervacije.Location = new System.Drawing.Point(105, 117);
            this.dgvPregledajRezervacije.Name = "dgvPregledajRezervacije";
            this.dgvPregledajRezervacije.ReadOnly = true;
            this.dgvPregledajRezervacije.RowHeadersWidth = 51;
            this.dgvPregledajRezervacije.RowTemplate.Height = 24;
            this.dgvPregledajRezervacije.Size = new System.Drawing.Size(828, 183);
            this.dgvPregledajRezervacije.TabIndex = 90;
            // 
            // lblPretrazi1
            // 
            this.lblPretrazi1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretrazi1.AutoSize = true;
            this.lblPretrazi1.Location = new System.Drawing.Point(102, 58);
            this.lblPretrazi1.Name = "lblPretrazi1";
            this.lblPretrazi1.Size = new System.Drawing.Size(194, 16);
            this.lblPretrazi1.TabIndex = 89;
            this.lblPretrazi1.Text = "Pretraži po putniku ili destinaciji:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretrazi.Location = new System.Drawing.Point(105, 77);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(219, 22);
            this.txtPretrazi.TabIndex = 97;
            // 
            // btnPromeniPutnika
            // 
            this.btnPromeniPutnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPromeniPutnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPromeniPutnika.Location = new System.Drawing.Point(956, 483);
            this.btnPromeniPutnika.Name = "btnPromeniPutnika";
            this.btnPromeniPutnika.Size = new System.Drawing.Size(143, 40);
            this.btnPromeniPutnika.TabIndex = 102;
            this.btnPromeniPutnika.Text = "Promeni putnika";
            this.btnPromeniPutnika.UseVisualStyleBackColor = true;
            this.btnPromeniPutnika.Click += new System.EventHandler(this.btnPromeniPutnika_Click);
            // 
            // btnPromeniAranzman
            // 
            this.btnPromeniAranzman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPromeniAranzman.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPromeniAranzman.Location = new System.Drawing.Point(957, 532);
            this.btnPromeniAranzman.Name = "btnPromeniAranzman";
            this.btnPromeniAranzman.Size = new System.Drawing.Size(142, 41);
            this.btnPromeniAranzman.TabIndex = 103;
            this.btnPromeniAranzman.Text = "Promeni aranžman";
            this.btnPromeniAranzman.UseVisualStyleBackColor = true;
            this.btnPromeniAranzman.Click += new System.EventHandler(this.btnPromeniAranzman_Click);
            // 
            // btnSacuvajPromene
            // 
            this.btnSacuvajPromene.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajPromene.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSacuvajPromene.Location = new System.Drawing.Point(956, 581);
            this.btnSacuvajPromene.Name = "btnSacuvajPromene";
            this.btnSacuvajPromene.Size = new System.Drawing.Size(143, 38);
            this.btnSacuvajPromene.TabIndex = 104;
            this.btnSacuvajPromene.Text = "Sačuvaj promene";
            this.btnSacuvajPromene.UseVisualStyleBackColor = true;
            this.btnSacuvajPromene.Click += new System.EventHandler(this.btnSacuvajPromene_Click);
            // 
            // btnObrisiRezervaciju
            // 
            this.btnObrisiRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiRezervaciju.Location = new System.Drawing.Point(957, 625);
            this.btnObrisiRezervaciju.Name = "btnObrisiRezervaciju";
            this.btnObrisiRezervaciju.Size = new System.Drawing.Size(142, 38);
            this.btnObrisiRezervaciju.TabIndex = 105;
            this.btnObrisiRezervaciju.Text = "Obriši rezervaciju";
            this.btnObrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnObrisiRezervaciju.Click += new System.EventHandler(this.btnObrisiRezervaciju_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(957, 669);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(142, 38);
            this.btnOdustani.TabIndex = 106;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // UCPregledajRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnObrisiRezervaciju);
            this.Controls.Add(this.btnSacuvajPromene);
            this.Controls.Add(this.btnPromeniAranzman);
            this.Controls.Add(this.btnPromeniPutnika);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetuj1);
            this.Controls.Add(this.btnPretrazi1);
            this.Controls.Add(this.dgvPregledajRezervacije);
            this.Controls.Add(this.lblPretrazi1);
            this.Name = "UCPregledajRezervacije";
            this.Size = new System.Drawing.Size(1183, 780);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledajRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.TextBox txtDatumDo;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.TextBox txtDatumOd;
        private System.Windows.Forms.ComboBox cbTipPrevoza;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.Label lblDestinacija;
        private System.Windows.Forms.ComboBox cbDestinacija;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblTipPrevoza;
        private System.Windows.Forms.Button btnResetuj1;
        private System.Windows.Forms.Button btnPretrazi1;
        private System.Windows.Forms.DataGridView dgvPregledajRezervacije;
        private System.Windows.Forms.Label lblPretrazi1;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnPromeniPutnika;
        private System.Windows.Forms.Button btnPromeniAranzman;
        private System.Windows.Forms.Button btnSacuvajPromene;
        private System.Windows.Forms.TextBox txtBrojRezervacije;
        private System.Windows.Forms.Label lblBrojRezervacije;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtBrojPasosa;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblBrojPasosa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnObrisiRezervaciju;
        private TextBox txtIdAranzmana;
        private Label lblIdAranzmana;
        private TextBox txtKorisnickoIme;
        private Label lblKorisnickoIme;
        private Button btnOdustani;

        public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Label LblDatumDo { get => lblDatumDo; set => lblDatumDo = value; }
        public TextBox TxtDatumDo { get => txtDatumDo; set => txtDatumDo = value; }
        public Label LblDatumOd { get => lblDatumOd; set => lblDatumOd = value; }
        public TextBox TxtDatumOd { get => txtDatumOd; set => txtDatumOd = value; }
        public ComboBox CbTipPrevoza { get => cbTipPrevoza; set => cbTipPrevoza = value; }
        public RichTextBox RtxtOpis { get => rtxtOpis; set => rtxtOpis = value; }
        public Label LblDestinacija { get => lblDestinacija; set => lblDestinacija = value; }
        public ComboBox CbDestinacija { get => cbDestinacija; set => cbDestinacija = value; }
        public Label LblOpis { get => lblOpis; set => lblOpis = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public Label LblTipPrevoza { get => lblTipPrevoza; set => lblTipPrevoza = value; }
        public Button BtnResetuj1 { get => btnResetuj1; set => btnResetuj1 = value; }
        public Button BtnPretrazi1 { get => btnPretrazi1; set => btnPretrazi1 = value; }
        public DataGridView DgvPregledajRezervacije { get => dgvPregledajRezervacije; set => dgvPregledajRezervacije = value; }
        public Label LblPretrazi1 { get => lblPretrazi1; set => lblPretrazi1 = value; }
        public TextBox TxtPretrazi { get => txtPretrazi; set => txtPretrazi = value; }
        public Button BtnPromeniPutnika { get => btnPromeniPutnika; set => btnPromeniPutnika = value; }
        public Button BtnPromeniAranzman { get => btnPromeniAranzman; set => btnPromeniAranzman = value; }
        public Button BtnSacuvajPromene { get => btnSacuvajPromene; set => btnSacuvajPromene = value; }
        public TextBox TxtBrojRezervacije { get => txtBrojRezervacije; set => txtBrojRezervacije = value; }
        public Label LblBrojRezervacije { get => lblBrojRezervacije; set => lblBrojRezervacije = value; }
        public TextBox TxtBrojTelefona { get => txtBrojTelefona; set => txtBrojTelefona = value; }
        public Label LblBrojTelefona { get => lblBrojTelefona; set => lblBrojTelefona = value; }
        public TextBox TxtJMBG { get => txtJMBG; set => txtJMBG = value; }
        public TextBox TxtBrojPasosa { get => txtBrojPasosa; set => txtBrojPasosa = value; }
        public Label LblJMBG { get => lblJMBG; set => lblJMBG = value; }
        public Label LblBrojPasosa { get => lblBrojPasosa; set => lblBrojPasosa = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Button BtnObrisiRezervaciju { get => btnObrisiRezervaciju; set => btnObrisiRezervaciju = value; }
        public TextBox TxtIdAranzmana { get => txtIdAranzmana; set => txtIdAranzmana = value; }
        public Label LblIdAranzmana { get => lblIdAranzmana; set => lblIdAranzmana = value; }
        public TextBox TxtKorisnickoIme { get => txtKorisnickoIme; set => txtKorisnickoIme = value; }
        public Label LblKorisnickoIme { get => lblKorisnickoIme; set => lblKorisnickoIme = value; }
        public Button BtnOdustani { get => btnOdustani; set => btnOdustani = value; }

    }
}
