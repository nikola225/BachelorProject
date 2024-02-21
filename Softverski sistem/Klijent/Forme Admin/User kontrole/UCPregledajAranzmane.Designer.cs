using System.Windows.Forms;

namespace Klijent.Forme_Admin.User_kontrole
{
    partial class UCPregledajAranzmane
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
            this.dgvListaAranzmana = new System.Windows.Forms.DataGridView();
            this.btnIzmeniAranzman = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnObrisiAranzman = new System.Windows.Forms.Button();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.cbTipPrevoza = new System.Windows.Forms.ComboBox();
            this.cbDestinacija = new System.Windows.Forms.ComboBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtAdministrator = new System.Windows.Forms.TextBox();
            this.lblTipPrevoza = new System.Windows.Forms.Label();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblDestinacija = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.txtDatumDo = new System.Windows.Forms.TextBox();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.txtDatumOd = new System.Windows.Forms.TextBox();
            this.btnSacuvajIzmene = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAranzmana)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(680, 313);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(200, 37);
            this.btnPrikaziDetalje.TabIndex = 15;
            this.btnPrikaziDetalje.Text = "Prikaži detalje";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = true;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // dgvListaAranzmana
            // 
            this.dgvListaAranzmana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListaAranzmana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAranzmana.Location = new System.Drawing.Point(76, 97);
            this.dgvListaAranzmana.Name = "dgvListaAranzmana";
            this.dgvListaAranzmana.RowHeadersWidth = 51;
            this.dgvListaAranzmana.RowTemplate.Height = 24;
            this.dgvListaAranzmana.Size = new System.Drawing.Size(804, 199);
            this.dgvListaAranzmana.TabIndex = 28;
            // 
            // btnIzmeniAranzman
            // 
            this.btnIzmeniAranzman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeniAranzman.Enabled = false;
            this.btnIzmeniAranzman.Location = new System.Drawing.Point(680, 641);
            this.btnIzmeniAranzman.Name = "btnIzmeniAranzman";
            this.btnIzmeniAranzman.Size = new System.Drawing.Size(200, 37);
            this.btnIzmeniAranzman.TabIndex = 29;
            this.btnIzmeniAranzman.Text = "Izmeni aranžman";
            this.btnIzmeniAranzman.UseVisualStyleBackColor = true;
            this.btnIzmeniAranzman.Click += new System.EventHandler(this.btnIzmeniAranzman_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretrazi.Location = new System.Drawing.Point(76, 60);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(374, 22);
            this.txtPretrazi.TabIndex = 30;
            // 
            // btnObrisiAranzman
            // 
            this.btnObrisiAranzman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisiAranzman.Enabled = false;
            this.btnObrisiAranzman.Location = new System.Drawing.Point(680, 727);
            this.btnObrisiAranzman.Name = "btnObrisiAranzman";
            this.btnObrisiAranzman.Size = new System.Drawing.Size(200, 37);
            this.btnObrisiAranzman.TabIndex = 31;
            this.btnObrisiAranzman.Text = "Obriši aranžman";
            this.btnObrisiAranzman.UseVisualStyleBackColor = true;
            this.btnObrisiAranzman.Click += new System.EventHandler(this.btnObrisiAranzman_Click);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(73, 41);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(125, 16);
            this.lblPretrazi.TabIndex = 32;
            this.lblPretrazi.Text = "Pretraži aranžmane:";
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtOpis.Location = new System.Drawing.Point(152, 149);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.ReadOnly = true;
            this.rtxtOpis.Size = new System.Drawing.Size(200, 77);
            this.rtxtOpis.TabIndex = 44;
            this.rtxtOpis.Text = "";
            // 
            // cbTipPrevoza
            // 
            this.cbTipPrevoza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipPrevoza.Enabled = false;
            this.cbTipPrevoza.FormattingEnabled = true;
            this.cbTipPrevoza.Location = new System.Drawing.Point(152, 325);
            this.cbTipPrevoza.Name = "cbTipPrevoza";
            this.cbTipPrevoza.Size = new System.Drawing.Size(200, 24);
            this.cbTipPrevoza.TabIndex = 43;
            // 
            // cbDestinacija
            // 
            this.cbDestinacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDestinacija.Enabled = false;
            this.cbDestinacija.FormattingEnabled = true;
            this.cbDestinacija.Location = new System.Drawing.Point(152, 108);
            this.cbDestinacija.Name = "cbDestinacija";
            this.cbDestinacija.Size = new System.Drawing.Size(200, 24);
            this.cbDestinacija.TabIndex = 42;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKapacitet.Location = new System.Drawing.Point(152, 284);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.ReadOnly = true;
            this.txtKapacitet.Size = new System.Drawing.Size(200, 22);
            this.txtKapacitet.TabIndex = 41;
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.Location = new System.Drawing.Point(152, 246);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(200, 22);
            this.txtCena.TabIndex = 40;
            // 
            // txtAdministrator
            // 
            this.txtAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdministrator.Location = new System.Drawing.Point(152, 71);
            this.txtAdministrator.Name = "txtAdministrator";
            this.txtAdministrator.ReadOnly = true;
            this.txtAdministrator.Size = new System.Drawing.Size(200, 22);
            this.txtAdministrator.TabIndex = 39;
            // 
            // lblTipPrevoza
            // 
            this.lblTipPrevoza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipPrevoza.AutoSize = true;
            this.lblTipPrevoza.Location = new System.Drawing.Point(53, 333);
            this.lblTipPrevoza.Name = "lblTipPrevoza";
            this.lblTipPrevoza.Size = new System.Drawing.Size(82, 16);
            this.lblTipPrevoza.TabIndex = 38;
            this.lblTipPrevoza.Text = "Tip prevoza:";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Location = new System.Drawing.Point(69, 290);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(66, 16);
            this.lblKapacitet.TabIndex = 37;
            this.lblKapacitet.Text = "Kapacitet:";
            // 
            // lblCena
            // 
            this.lblCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(93, 252);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(42, 16);
            this.lblCena.TabIndex = 36;
            this.lblCena.Text = "Cena:";
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(97, 149);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(38, 16);
            this.lblOpis.TabIndex = 35;
            this.lblOpis.Text = "Opis:";
            // 
            // lblDestinacija
            // 
            this.lblDestinacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDestinacija.AutoSize = true;
            this.lblDestinacija.Location = new System.Drawing.Point(58, 117);
            this.lblDestinacija.Name = "lblDestinacija";
            this.lblDestinacija.Size = new System.Drawing.Size(77, 16);
            this.lblDestinacija.TabIndex = 34;
            this.lblDestinacija.Text = "Destinacija:";
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Location = new System.Drawing.Point(47, 78);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(88, 16);
            this.lblAdministrator.TabIndex = 33;
            this.lblAdministrator.Text = "Administrator:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.lblDatumDo);
            this.groupBox1.Controls.Add(this.txtDatumDo);
            this.groupBox1.Controls.Add(this.lblDatumOd);
            this.groupBox1.Controls.Add(this.txtDatumOd);
            this.groupBox1.Controls.Add(this.cbTipPrevoza);
            this.groupBox1.Controls.Add(this.rtxtOpis);
            this.groupBox1.Controls.Add(this.lblAdministrator);
            this.groupBox1.Controls.Add(this.lblDestinacija);
            this.groupBox1.Controls.Add(this.cbDestinacija);
            this.groupBox1.Controls.Add(this.lblOpis);
            this.groupBox1.Controls.Add(this.txtKapacitet);
            this.groupBox1.Controls.Add(this.lblCena);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.lblKapacitet);
            this.groupBox1.Controls.Add(this.txtAdministrator);
            this.groupBox1.Controls.Add(this.lblTipPrevoza);
            this.groupBox1.Location = new System.Drawing.Point(76, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 451);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacije o aranžmanu";
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(114, 40);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 49;
            this.lblId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(152, 34);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.TabIndex = 50;
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(30, 406);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(105, 16);
            this.lblDatumDo.TabIndex = 47;
            this.lblDatumDo.Text = "Datum povratka:";
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumDo.Location = new System.Drawing.Point(152, 400);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.ReadOnly = true;
            this.txtDatumDo.Size = new System.Drawing.Size(200, 22);
            this.txtDatumDo.TabIndex = 48;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(34, 370);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(101, 16);
            this.lblDatumOd.TabIndex = 45;
            this.lblDatumOd.Text = "Datum polaska:";
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatumOd.Location = new System.Drawing.Point(152, 364);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.ReadOnly = true;
            this.txtDatumOd.Size = new System.Drawing.Size(200, 22);
            this.txtDatumOd.TabIndex = 46;
            // 
            // btnSacuvajIzmene
            // 
            this.btnSacuvajIzmene.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvajIzmene.Enabled = false;
            this.btnSacuvajIzmene.Location = new System.Drawing.Point(680, 684);
            this.btnSacuvajIzmene.Name = "btnSacuvajIzmene";
            this.btnSacuvajIzmene.Size = new System.Drawing.Size(200, 37);
            this.btnSacuvajIzmene.TabIndex = 70;
            this.btnSacuvajIzmene.Text = "Sačuvaj izmene";
            this.btnSacuvajIzmene.UseVisualStyleBackColor = true;
            this.btnSacuvajIzmene.Click += new System.EventHandler(this.btnSacuvajIzmene_Click);
            // 
            // btnResetuj
            // 
            this.btnResetuj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetuj.Location = new System.Drawing.Point(535, 57);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(64, 29);
            this.btnResetuj.TabIndex = 79;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(459, 57);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(70, 29);
            this.btnPretrazi.TabIndex = 78;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // UCPregledajAranzmane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnSacuvajIzmene);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.btnObrisiAranzman);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnIzmeniAranzman);
            this.Controls.Add(this.dgvListaAranzmana);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Name = "UCPregledajAranzmane";
            this.Size = new System.Drawing.Size(988, 790);
            this.Load += new System.EventHandler(this.UCPregledajAranzmane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAranzmana)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.DataGridView dgvListaAranzmana;
        private System.Windows.Forms.Button btnIzmeniAranzman;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnObrisiAranzman;
        private System.Windows.Forms.Label lblPretrazi;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.ComboBox cbTipPrevoza;
        private System.Windows.Forms.ComboBox cbDestinacija;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtAdministrator;
        private System.Windows.Forms.Label lblTipPrevoza;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblDestinacija;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.GroupBox groupBox1;
        private Label lblDatumDo;
        private TextBox txtDatumDo;
        private Label lblDatumOd;
        private TextBox txtDatumOd;
        private Button btnSacuvajIzmene;
        private Label lblId;
        private TextBox txtId;
        private Button btnResetuj;
        private Button btnPretrazi;

        public Button BtnPrikaziDetalje { get => btnPrikaziDetalje; set => btnPrikaziDetalje = value; }
        public DataGridView DgvListaAranzmana { get => dgvListaAranzmana; set => dgvListaAranzmana = value; }
        public Button BtnIzmeniAranzman { get => btnIzmeniAranzman; set => btnIzmeniAranzman = value; }
        public TextBox TxtPretrazi { get => txtPretrazi; set => txtPretrazi = value; }
        public Button BtnObrisiAranzman { get => btnObrisiAranzman; set => btnObrisiAranzman = value; }
        public Label LblPretrazi { get => lblPretrazi; set => lblPretrazi = value; }
        public RichTextBox RtxtOpis { get => rtxtOpis; set => rtxtOpis = value; }
        public ComboBox CbTipPrevoza { get => cbTipPrevoza; set => cbTipPrevoza = value; }
        public ComboBox CbDestinacija { get => cbDestinacija; set => cbDestinacija = value; }
        public TextBox TxtKapacitet { get => txtKapacitet; set => txtKapacitet = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public TextBox TxtAdministrator { get => txtAdministrator; set => txtAdministrator = value; }
        public Label LblTipPrevoza { get => lblTipPrevoza; set => lblTipPrevoza = value; }
        public Label LblKapacitet { get => lblKapacitet; set => lblKapacitet = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Label LblOpis { get => lblOpis; set => lblOpis = value; }
        public Label LblDestinacija { get => lblDestinacija; set => lblDestinacija = value; }
        public Label LblAdministrator { get => lblAdministrator; set => lblAdministrator = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Label LblDatumDo { get => lblDatumDo; set => lblDatumDo = value; }
        public TextBox TxtDatumDo { get => txtDatumDo; set => txtDatumDo = value; }
        public Label LblDatumOd { get => lblDatumOd; set => lblDatumOd = value; }
        public TextBox TxtDatumOd { get => txtDatumOd; set => txtDatumOd = value; }
        public Button BtnSacuvajIzmene { get => btnSacuvajIzmene; set => btnSacuvajIzmene = value; }
        public Label LblId { get => lblId; set => lblId = value; }
        public TextBox TxtId { get => txtId; set => txtId = value; }
    }
}
