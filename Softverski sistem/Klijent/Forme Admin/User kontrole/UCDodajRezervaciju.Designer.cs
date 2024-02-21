using System.Windows.Forms;

namespace Klijent.Forme_Admin.User_kontrole
{
    partial class UCDodajRezervaciju
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBrojRezervacije = new System.Windows.Forms.TextBox();
            this.lblBrojRezervacije = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
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
            this.dgvOdaberiPutnika = new System.Windows.Forms.DataGridView();
            this.dgvOdaberiAranzman = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnOdaberiPutnika = new System.Windows.Forms.Button();
            this.btnOdaberiAranzman = new System.Windows.Forms.Button();
            this.btnSacuvajRezervaciju = new System.Windows.Forms.Button();
            this.btnZapamtiSve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdaberiPutnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdaberiAranzman)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtBrojRezervacije);
            this.groupBox1.Controls.Add(this.lblBrojRezervacije);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblUsername);
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
            this.groupBox1.Location = new System.Drawing.Point(42, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 389);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o putniku:";
            // 
            // txtBrojRezervacije
            // 
            this.txtBrojRezervacije.Location = new System.Drawing.Point(201, 326);
            this.txtBrojRezervacije.Name = "txtBrojRezervacije";
            this.txtBrojRezervacije.Size = new System.Drawing.Size(160, 22);
            this.txtBrojRezervacije.TabIndex = 110;
            // 
            // lblBrojRezervacije
            // 
            this.lblBrojRezervacije.AutoSize = true;
            this.lblBrojRezervacije.Location = new System.Drawing.Point(86, 332);
            this.lblBrojRezervacije.Name = "lblBrojRezervacije";
            this.lblBrojRezervacije.Size = new System.Drawing.Size(103, 16);
            this.lblBrojRezervacije.TabIndex = 109;
            this.lblBrojRezervacije.Text = "Broj rezervacije:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(201, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(160, 22);
            this.txtUsername.TabIndex = 108;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(110, 63);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 107;
            this.lblUsername.Text = "Username:";
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(201, 284);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.ReadOnly = true;
            this.txtBrojTelefona.Size = new System.Drawing.Size(160, 22);
            this.txtBrojTelefona.TabIndex = 104;
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(98, 290);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(85, 16);
            this.lblBrojTelefona.TabIndex = 103;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(201, 168);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.ReadOnly = true;
            this.txtJMBG.Size = new System.Drawing.Size(160, 22);
            this.txtJMBG.TabIndex = 102;
            // 
            // txtBrojPasosa
            // 
            this.txtBrojPasosa.Location = new System.Drawing.Point(201, 210);
            this.txtBrojPasosa.Name = "txtBrojPasosa";
            this.txtBrojPasosa.ReadOnly = true;
            this.txtBrojPasosa.Size = new System.Drawing.Size(160, 22);
            this.txtBrojPasosa.TabIndex = 101;
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(136, 174);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(47, 16);
            this.lblJMBG.TabIndex = 100;
            this.lblJMBG.Text = "JMBG:";
            // 
            // lblBrojPasosa
            // 
            this.lblBrojPasosa.AutoSize = true;
            this.lblBrojPasosa.Location = new System.Drawing.Point(99, 216);
            this.lblBrojPasosa.Name = "lblBrojPasosa";
            this.lblBrojPasosa.Size = new System.Drawing.Size(84, 16);
            this.lblBrojPasosa.TabIndex = 99;
            this.lblBrojPasosa.Text = "Broj Pasoša:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(160, 22);
            this.txtEmail.TabIndex = 98;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(201, 131);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(160, 22);
            this.txtPrezime.TabIndex = 97;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(201, 91);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(160, 22);
            this.txtIme.TabIndex = 96;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(124, 137);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(59, 16);
            this.lblPrezime.TabIndex = 95;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(151, 97);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(32, 16);
            this.lblIme.TabIndex = 94;
            this.lblIme.Text = "Ime:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(139, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 93;
            this.lblEmail.Text = "Email:";
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(76, 250);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(105, 16);
            this.lblDatumDo.TabIndex = 47;
            this.lblDatumDo.Text = "Datum povratka:";
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumDo.Location = new System.Drawing.Point(198, 244);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.ReadOnly = true;
            this.txtDatumDo.Size = new System.Drawing.Size(200, 22);
            this.txtDatumDo.TabIndex = 48;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(80, 213);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(101, 16);
            this.lblDatumOd.TabIndex = 45;
            this.lblDatumOd.Text = "Datum polaska:";
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumOd.Location = new System.Drawing.Point(198, 207);
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
            this.cbTipPrevoza.Location = new System.Drawing.Point(198, 165);
            this.cbTipPrevoza.Name = "cbTipPrevoza";
            this.cbTipPrevoza.Size = new System.Drawing.Size(200, 24);
            this.cbTipPrevoza.TabIndex = 43;
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtOpis.Location = new System.Drawing.Point(198, 284);
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
            this.lblDestinacija.Location = new System.Drawing.Point(104, 98);
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
            this.cbDestinacija.Location = new System.Drawing.Point(198, 89);
            this.cbDestinacija.Name = "cbDestinacija";
            this.cbDestinacija.Size = new System.Drawing.Size(200, 24);
            this.cbDestinacija.TabIndex = 42;
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(143, 284);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(38, 16);
            this.lblOpis.TabIndex = 35;
            this.lblOpis.Text = "Opis:";
            // 
            // lblCena
            // 
            this.lblCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(139, 134);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(42, 16);
            this.lblCena.TabIndex = 36;
            this.lblCena.Text = "Cena:";
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.Location = new System.Drawing.Point(198, 128);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(67, 22);
            this.txtCena.TabIndex = 40;
            // 
            // lblTipPrevoza
            // 
            this.lblTipPrevoza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipPrevoza.AutoSize = true;
            this.lblTipPrevoza.Location = new System.Drawing.Point(99, 173);
            this.lblTipPrevoza.Name = "lblTipPrevoza";
            this.lblTipPrevoza.Size = new System.Drawing.Size(82, 16);
            this.lblTipPrevoza.TabIndex = 38;
            this.lblTipPrevoza.Text = "Tip prevoza:";
            // 
            // dgvOdaberiPutnika
            // 
            this.dgvOdaberiPutnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOdaberiPutnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdaberiPutnika.Location = new System.Drawing.Point(42, 33);
            this.dgvOdaberiPutnika.Name = "dgvOdaberiPutnika";
            this.dgvOdaberiPutnika.RowHeadersWidth = 51;
            this.dgvOdaberiPutnika.RowTemplate.Height = 24;
            this.dgvOdaberiPutnika.Size = new System.Drawing.Size(496, 183);
            this.dgvOdaberiPutnika.TabIndex = 96;
            // 
            // dgvOdaberiAranzman
            // 
            this.dgvOdaberiAranzman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOdaberiAranzman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdaberiAranzman.Location = new System.Drawing.Point(600, 33);
            this.dgvOdaberiAranzman.Name = "dgvOdaberiAranzman";
            this.dgvOdaberiAranzman.RowHeadersWidth = 51;
            this.dgvOdaberiAranzman.RowTemplate.Height = 24;
            this.dgvOdaberiAranzman.Size = new System.Drawing.Size(496, 183);
            this.dgvOdaberiAranzman.TabIndex = 98;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.rtxtOpis);
            this.groupBox2.Controls.Add(this.lblDatumDo);
            this.groupBox2.Controls.Add(this.txtDatumDo);
            this.groupBox2.Controls.Add(this.lblDatumOd);
            this.groupBox2.Controls.Add(this.txtDatumOd);
            this.groupBox2.Controls.Add(this.lblTipPrevoza);
            this.groupBox2.Controls.Add(this.cbTipPrevoza);
            this.groupBox2.Controls.Add(this.txtCena);
            this.groupBox2.Controls.Add(this.lblDestinacija);
            this.groupBox2.Controls.Add(this.lblCena);
            this.groupBox2.Controls.Add(this.cbDestinacija);
            this.groupBox2.Controls.Add(this.lblOpis);
            this.groupBox2.Location = new System.Drawing.Point(600, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 389);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacije o aranžmanu:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(198, 57);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(160, 22);
            this.txtId.TabIndex = 110;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(160, 63);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 109;
            this.lblId.Text = "Id:";
            // 
            // btnOdaberiPutnika
            // 
            this.btnOdaberiPutnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberiPutnika.Location = new System.Drawing.Point(382, 222);
            this.btnOdaberiPutnika.Name = "btnOdaberiPutnika";
            this.btnOdaberiPutnika.Size = new System.Drawing.Size(156, 35);
            this.btnOdaberiPutnika.TabIndex = 100;
            this.btnOdaberiPutnika.Text = "Odaberi putnika";
            this.btnOdaberiPutnika.UseVisualStyleBackColor = true;
            this.btnOdaberiPutnika.Click += new System.EventHandler(this.btnOdaberiPutnika_Click);
            // 
            // btnOdaberiAranzman
            // 
            this.btnOdaberiAranzman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaberiAranzman.Location = new System.Drawing.Point(936, 222);
            this.btnOdaberiAranzman.Name = "btnOdaberiAranzman";
            this.btnOdaberiAranzman.Size = new System.Drawing.Size(160, 35);
            this.btnOdaberiAranzman.TabIndex = 101;
            this.btnOdaberiAranzman.Text = "Odaberi aranžman";
            this.btnOdaberiAranzman.UseVisualStyleBackColor = true;
            this.btnOdaberiAranzman.Click += new System.EventHandler(this.btnOdaberiAranzman_Click);
            // 
            // btnSacuvajRezervaciju
            // 
            this.btnSacuvajRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajRezervaciju.Location = new System.Drawing.Point(950, 678);
            this.btnSacuvajRezervaciju.Name = "btnSacuvajRezervaciju";
            this.btnSacuvajRezervaciju.Size = new System.Drawing.Size(146, 38);
            this.btnSacuvajRezervaciju.TabIndex = 102;
            this.btnSacuvajRezervaciju.Text = "Sačuvaj rezervaciju";
            this.btnSacuvajRezervaciju.UseVisualStyleBackColor = true;
            this.btnSacuvajRezervaciju.Click += new System.EventHandler(this.btnSacuvajRezervaciju_Click);
            // 
            // btnZapamtiSve
            // 
            this.btnZapamtiSve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnZapamtiSve.Enabled = false;
            this.btnZapamtiSve.Location = new System.Drawing.Point(950, 722);
            this.btnZapamtiSve.Name = "btnZapamtiSve";
            this.btnZapamtiSve.Size = new System.Drawing.Size(146, 38);
            this.btnZapamtiSve.TabIndex = 103;
            this.btnZapamtiSve.Text = "Zapamti sve";
            this.btnZapamtiSve.UseVisualStyleBackColor = true;
            this.btnZapamtiSve.Click += new System.EventHandler(this.btnZapamtiSve_Click);
            // 
            // UCDodajRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZapamtiSve);
            this.Controls.Add(this.btnSacuvajRezervaciju);
            this.Controls.Add(this.btnOdaberiAranzman);
            this.Controls.Add(this.btnOdaberiPutnika);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvOdaberiAranzman);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOdaberiPutnika);
            this.Name = "UCDodajRezervaciju";
            this.Size = new System.Drawing.Size(1168, 796);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdaberiPutnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdaberiAranzman)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridView dgvOdaberiPutnika;
        private System.Windows.Forms.DataGridView dgvOdaberiAranzman;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOdaberiPutnika;
        private System.Windows.Forms.Button btnOdaberiAranzman;
        private System.Windows.Forms.Button btnSacuvajRezervaciju;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtBrojRezervacije;
        private Label lblBrojRezervacije;
        private Button btnZapamtiSve;

        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
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
        public DataGridView DgvOdaberiPutnika { get => dgvOdaberiPutnika; set => dgvOdaberiPutnika = value; }
        public DataGridView DgvOdaberiAranzman { get => dgvOdaberiAranzman; set => dgvOdaberiAranzman = value; }
        public GroupBox GroupBox2 { get => groupBox2; set => groupBox2 = value; }
        public Button BtnOdaberiPutnika { get => btnOdaberiPutnika; set => btnOdaberiPutnika = value; }
        public Button BtnOdaberiAranzman { get => btnOdaberiAranzman; set => btnOdaberiAranzman = value; }
        public Button BtnSacuvajRezervaciju { get => btnSacuvajRezervaciju; set => btnSacuvajRezervaciju = value; }
        public TextBox TxtUsername { get => txtUsername; set => txtUsername = value; }
        public Label LblUsername { get => lblUsername; set => lblUsername = value; }
        public TextBox TxtId { get => txtId; set => txtId = value; }
        public Label LblId { get => lblId; set => lblId = value; }
        public TextBox TxtBrojRezervacije { get => txtBrojRezervacije; set => txtBrojRezervacije = value; }
        public Label LblBrojRezervacije { get => lblBrojRezervacije; set => lblBrojRezervacije = value; }
        public Button BtnZapamtiSve { get => btnZapamtiSve; set => btnZapamtiSve = value; }
    }
}
