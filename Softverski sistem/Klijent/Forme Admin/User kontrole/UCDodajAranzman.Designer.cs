using System.Windows.Forms;

namespace Klijent.Forms.User_kontrole
{
    partial class UCDodajAranzman
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblDestinacija = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.lblTipPrevoza = new System.Windows.Forms.Label();
            this.txtAdministrator = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.cbDestinacija = new System.Windows.Forms.ComboBox();
            this.cbTipPrevoza = new System.Windows.Forms.ComboBox();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(192, 63);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(256, 29);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Dodaj novi aranžman";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(222, 574);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(200, 47);
            this.btnSacuvaj.TabIndex = 1;
            this.btnSacuvaj.Text = "Sačuvaj aranžman";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Location = new System.Drawing.Point(115, 177);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(88, 16);
            this.lblAdministrator.TabIndex = 2;
            this.lblAdministrator.Text = "Administrator:";
            // 
            // lblDestinacija
            // 
            this.lblDestinacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDestinacija.AutoSize = true;
            this.lblDestinacija.Location = new System.Drawing.Point(126, 221);
            this.lblDestinacija.Name = "lblDestinacija";
            this.lblDestinacija.Size = new System.Drawing.Size(77, 16);
            this.lblDestinacija.TabIndex = 3;
            this.lblDestinacija.Text = "Destinacija:";
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(165, 253);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(38, 16);
            this.lblOpis.TabIndex = 4;
            this.lblOpis.Text = "Opis:";
            // 
            // lblCena
            // 
            this.lblCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(161, 356);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(42, 16);
            this.lblCena.TabIndex = 5;
            this.lblCena.Text = "Cena:";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Location = new System.Drawing.Point(137, 394);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(66, 16);
            this.lblKapacitet.TabIndex = 6;
            this.lblKapacitet.Text = "Kapacitet:";
            // 
            // lblTipPrevoza
            // 
            this.lblTipPrevoza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipPrevoza.AutoSize = true;
            this.lblTipPrevoza.Location = new System.Drawing.Point(121, 437);
            this.lblTipPrevoza.Name = "lblTipPrevoza";
            this.lblTipPrevoza.Size = new System.Drawing.Size(82, 16);
            this.lblTipPrevoza.TabIndex = 7;
            this.lblTipPrevoza.Text = "Tip prevoza:";
            // 
            // txtAdministrator
            // 
            this.txtAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAdministrator.Location = new System.Drawing.Point(220, 170);
            this.txtAdministrator.Name = "txtAdministrator";
            this.txtAdministrator.ReadOnly = true;
            this.txtAdministrator.Size = new System.Drawing.Size(200, 22);
            this.txtAdministrator.TabIndex = 8;
            // 
            // txtCena
            // 
            this.txtCena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCena.Location = new System.Drawing.Point(220, 350);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(200, 22);
            this.txtCena.TabIndex = 9;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKapacitet.Location = new System.Drawing.Point(220, 388);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(200, 22);
            this.txtKapacitet.TabIndex = 10;
            // 
            // cbDestinacija
            // 
            this.cbDestinacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDestinacija.FormattingEnabled = true;
            this.cbDestinacija.Location = new System.Drawing.Point(220, 212);
            this.cbDestinacija.Name = "cbDestinacija";
            this.cbDestinacija.Size = new System.Drawing.Size(200, 24);
            this.cbDestinacija.TabIndex = 11;
            // 
            // cbTipPrevoza
            // 
            this.cbTipPrevoza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTipPrevoza.FormattingEnabled = true;
            this.cbTipPrevoza.Location = new System.Drawing.Point(220, 429);
            this.cbTipPrevoza.Name = "cbTipPrevoza";
            this.cbTipPrevoza.Size = new System.Drawing.Size(200, 24);
            this.cbTipPrevoza.TabIndex = 12;
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtOpis.Location = new System.Drawing.Point(220, 253);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(200, 77);
            this.rtxtOpis.TabIndex = 13;
            this.rtxtOpis.Text = "";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOtkazi.Location = new System.Drawing.Point(222, 627);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(200, 43);
            this.btnOtkazi.TabIndex = 54;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(102, 480);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(101, 16);
            this.lblDatumOd.TabIndex = 55;
            this.lblDatumOd.Text = "Datum polaska:";
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.Location = new System.Drawing.Point(98, 525);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(105, 16);
            this.lblDatumDo.TabIndex = 56;
            this.lblDatumDo.Text = "Datum povratka:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 474);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 22);
            this.dateTimePicker1.TabIndex = 57;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(220, 519);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(198, 22);
            this.dateTimePicker2.TabIndex = 58;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(220, 130);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "ID:";
            // 
            // UCDodajAranzman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.cbTipPrevoza);
            this.Controls.Add(this.cbDestinacija);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtAdministrator);
            this.Controls.Add(this.lblTipPrevoza);
            this.Controls.Add(this.lblKapacitet);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDestinacija);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblNaslov);
            this.Name = "UCDodajAranzman";
            this.Size = new System.Drawing.Size(614, 692);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblDestinacija;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.Label lblTipPrevoza;
        private System.Windows.Forms.TextBox txtAdministrator;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.ComboBox cbDestinacija;
        private System.Windows.Forms.ComboBox cbTipPrevoza;
        private System.Windows.Forms.RichTextBox rtxtOpis;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private TextBox txtId;
        private Label label1;

        public Label LblNaslov { get => lblNaslov; set => lblNaslov = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Label LblAdministrator { get => lblAdministrator; set => lblAdministrator = value; }
        public Label LblDestinacija { get => lblDestinacija; set => lblDestinacija = value; }
        public Label LblOpis { get => lblOpis; set => lblOpis = value; }
        public Label LblCena { get => lblCena; set => lblCena = value; }
        public Label LblKapacitet { get => lblKapacitet; set => lblKapacitet = value; }
        public Label LblTipPrevoza { get => lblTipPrevoza; set => lblTipPrevoza = value; }
        public TextBox TxtAdministrator { get => txtAdministrator; set => txtAdministrator = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public TextBox TxtKapacitet { get => txtKapacitet; set => txtKapacitet = value; }
        public ComboBox CbDestinacija { get => cbDestinacija; set => cbDestinacija = value; }
        public ComboBox CbTipPrevoza { get => cbTipPrevoza; set => cbTipPrevoza = value; }
        public RichTextBox RtxtOpis { get => rtxtOpis; set => rtxtOpis = value; }
        public Button BtnOtkazi { get => btnOtkazi; set => btnOtkazi = value; }
        public Label LblDatumOd { get => lblDatumOd; set => lblDatumOd = value; }
        public Label LblDatumDo { get => lblDatumDo; set => lblDatumDo = value; }
        public DateTimePicker DateTimePicker1 { get => dateTimePicker1; set => dateTimePicker1 = value; }
        public DateTimePicker DateTimePicker2 { get => dateTimePicker2; set => dateTimePicker2 = value; }
        public TextBox TxtId { get => txtId; set => txtId = value; }
        public Label Label1 { get => label1; set => label1 = value; }
    }
}
