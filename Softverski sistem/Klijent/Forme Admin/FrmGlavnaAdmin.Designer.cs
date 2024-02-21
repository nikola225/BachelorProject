using System.Windows.Forms;

namespace Klijent.Forme_Admin
{
    partial class FrmGlavnaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavnaAdmin));
            this.menuGlavniMeni = new System.Windows.Forms.MenuStrip();
            this.aranžmaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opšteInformacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledDestinacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aranžmaniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajPonudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajAranžmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izborAranžmanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovogPutnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPocetak = new System.Windows.Forms.Panel();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.kreirajRezervacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGlavniMeni.SuspendLayout();
            this.pnlPocetak.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGlavniMeni
            // 
            this.menuGlavniMeni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGlavniMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aranžmaniToolStripMenuItem,
            this.destinacijeToolStripMenuItem,
            this.aranžmaniToolStripMenuItem1,
            this.pomoćToolStripMenuItem,
            this.rezervacijaToolStripMenuItem});
            this.menuGlavniMeni.Location = new System.Drawing.Point(0, 0);
            this.menuGlavniMeni.Name = "menuGlavniMeni";
            this.menuGlavniMeni.Size = new System.Drawing.Size(1004, 28);
            this.menuGlavniMeni.TabIndex = 6;
            this.menuGlavniMeni.Text = "menuStrip1";
            // 
            // aranžmaniToolStripMenuItem
            // 
            this.aranžmaniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opšteInformacijeToolStripMenuItem});
            this.aranžmaniToolStripMenuItem.Name = "aranžmaniToolStripMenuItem";
            this.aranžmaniToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.aranžmaniToolStripMenuItem.Text = "Moj profil";
            // 
            // opšteInformacijeToolStripMenuItem
            // 
            this.opšteInformacijeToolStripMenuItem.Name = "opšteInformacijeToolStripMenuItem";
            this.opšteInformacijeToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.opšteInformacijeToolStripMenuItem.Text = "Opšte informacije";
            this.opšteInformacijeToolStripMenuItem.Click += new System.EventHandler(this.opšteInformacijeToolStripMenuItem_Click);
            // 
            // destinacijeToolStripMenuItem
            // 
            this.destinacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledDestinacijaToolStripMenuItem});
            this.destinacijeToolStripMenuItem.Name = "destinacijeToolStripMenuItem";
            this.destinacijeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.destinacijeToolStripMenuItem.Text = "Destinacije";
            // 
            // pregledDestinacijaToolStripMenuItem
            // 
            this.pregledDestinacijaToolStripMenuItem.Name = "pregledDestinacijaToolStripMenuItem";
            this.pregledDestinacijaToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.pregledDestinacijaToolStripMenuItem.Text = "Pregledaj destinacije";
            this.pregledDestinacijaToolStripMenuItem.Click += new System.EventHandler(this.pregledDestinacijaToolStripMenuItem_Click);
            // 
            // aranžmaniToolStripMenuItem1
            // 
            this.aranžmaniToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajPonudeToolStripMenuItem,
            this.dodajAranžmanToolStripMenuItem});
            this.aranžmaniToolStripMenuItem1.Name = "aranžmaniToolStripMenuItem1";
            this.aranžmaniToolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.aranžmaniToolStripMenuItem1.Text = "Aranžmani";
            // 
            // pregledajPonudeToolStripMenuItem
            // 
            this.pregledajPonudeToolStripMenuItem.Name = "pregledajPonudeToolStripMenuItem";
            this.pregledajPonudeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.pregledajPonudeToolStripMenuItem.Text = "Pregledaj aranžmane";
            this.pregledajPonudeToolStripMenuItem.Click += new System.EventHandler(this.pregledajPonudeToolStripMenuItem_Click);
            // 
            // dodajAranžmanToolStripMenuItem
            // 
            this.dodajAranžmanToolStripMenuItem.Name = "dodajAranžmanToolStripMenuItem";
            this.dodajAranžmanToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.dodajAranžmanToolStripMenuItem.Text = "Dodaj novi aranžman";
            this.dodajAranžmanToolStripMenuItem.Click += new System.EventHandler(this.dodajAranžmanToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izborAranžmanaToolStripMenuItem,
            this.dodajNovogPutnikaToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.pomoćToolStripMenuItem.Text = "Putnici";
            // 
            // izborAranžmanaToolStripMenuItem
            // 
            this.izborAranžmanaToolStripMenuItem.Name = "izborAranžmanaToolStripMenuItem";
            this.izborAranžmanaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.izborAranžmanaToolStripMenuItem.Text = "Pregledaj putnike";
            this.izborAranžmanaToolStripMenuItem.Click += new System.EventHandler(this.izborAranžmanaToolStripMenuItem_Click);
            // 
            // dodajNovogPutnikaToolStripMenuItem
            // 
            this.dodajNovogPutnikaToolStripMenuItem.Name = "dodajNovogPutnikaToolStripMenuItem";
            this.dodajNovogPutnikaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.dodajNovogPutnikaToolStripMenuItem.Text = "Dodaj novog putnika";
            this.dodajNovogPutnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovogPutnikaToolStripMenuItem_Click);
            // 
            // rezervacijaToolStripMenuItem
            // 
            this.rezervacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajRezervacijeToolStripMenuItem,
            this.kreirajRezervacijuToolStripMenuItem});
            this.rezervacijaToolStripMenuItem.Name = "rezervacijaToolStripMenuItem";
            this.rezervacijaToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.rezervacijaToolStripMenuItem.Text = "Rezervacije";
            // 
            // pregledajRezervacijeToolStripMenuItem
            // 
            this.pregledajRezervacijeToolStripMenuItem.Name = "pregledajRezervacijeToolStripMenuItem";
            this.pregledajRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.pregledajRezervacijeToolStripMenuItem.Text = "Pregledaj rezervacije";
            this.pregledajRezervacijeToolStripMenuItem.Click += new System.EventHandler(this.pregledajRezervacijeToolStripMenuItem_Click);
            // 
            // pnlPocetak
            // 
            this.pnlPocetak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPocetak.BackgroundImage")));
            this.pnlPocetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPocetak.Controls.Add(this.lblDobrodosli);
            this.pnlPocetak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPocetak.Location = new System.Drawing.Point(0, 28);
            this.pnlPocetak.Name = "pnlPocetak";
            this.pnlPocetak.Size = new System.Drawing.Size(1004, 597);
            this.pnlPocetak.TabIndex = 7;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(331, 223);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(0, 79);
            this.lblDobrodosli.TabIndex = 0;
            // 
            // kreirajRezervacijuToolStripMenuItem
            // 
            this.kreirajRezervacijuToolStripMenuItem.Name = "kreirajRezervacijuToolStripMenuItem";
            this.kreirajRezervacijuToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.kreirajRezervacijuToolStripMenuItem.Text = "Kreiraj rezervaciju";
            this.kreirajRezervacijuToolStripMenuItem.Click += new System.EventHandler(this.kreirajRezervacijuToolStripMenuItem_Click);
            // 
            // FrmGlavnaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 625);
            this.Controls.Add(this.pnlPocetak);
            this.Controls.Add(this.menuGlavniMeni);
            this.Name = "FrmGlavnaAdmin";
            this.Text = "Dobrodošli, ";
            this.menuGlavniMeni.ResumeLayout(false);
            this.menuGlavniMeni.PerformLayout();
            this.pnlPocetak.ResumeLayout(false);
            this.pnlPocetak.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGlavniMeni;
        private System.Windows.Forms.ToolStripMenuItem aranžmaniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opšteInformacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aranžmaniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pregledajPonudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izborAranžmanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajAranžmanToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPocetak;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.ToolStripMenuItem dodajNovogPutnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledDestinacijaToolStripMenuItem;
        private ToolStripMenuItem kreirajRezervacijuToolStripMenuItem;

        public MenuStrip MenuGlavniMeni { get => menuGlavniMeni; set => menuGlavniMeni = value; }
        public ToolStripMenuItem AranžmaniToolStripMenuItem { get => aranžmaniToolStripMenuItem; set => aranžmaniToolStripMenuItem = value; }
        public ToolStripMenuItem OpšteInformacijeToolStripMenuItem { get => opšteInformacijeToolStripMenuItem; set => opšteInformacijeToolStripMenuItem = value; }
        public ToolStripMenuItem AranžmaniToolStripMenuItem1 { get => aranžmaniToolStripMenuItem1; set => aranžmaniToolStripMenuItem1 = value; }
        public ToolStripMenuItem PregledajPonudeToolStripMenuItem { get => pregledajPonudeToolStripMenuItem; set => pregledajPonudeToolStripMenuItem = value; }
        public ToolStripMenuItem RezervacijaToolStripMenuItem { get => rezervacijaToolStripMenuItem; set => rezervacijaToolStripMenuItem = value; }
        public ToolStripMenuItem PregledajRezervacijeToolStripMenuItem { get => pregledajRezervacijeToolStripMenuItem; set => pregledajRezervacijeToolStripMenuItem = value; }
        public ToolStripMenuItem PomoćToolStripMenuItem { get => pomoćToolStripMenuItem; set => pomoćToolStripMenuItem = value; }
        public ToolStripMenuItem IzborAranžmanaToolStripMenuItem { get => izborAranžmanaToolStripMenuItem; set => izborAranžmanaToolStripMenuItem = value; }
        public ToolStripMenuItem DodajAranžmanToolStripMenuItem { get => dodajAranžmanToolStripMenuItem; set => dodajAranžmanToolStripMenuItem = value; }
        public Panel PnlPocetak { get => pnlPocetak; set => pnlPocetak = value; }
        public Label LblDobrodosli { get => lblDobrodosli; set => lblDobrodosli = value; }
        public ToolStripMenuItem DodajNovogPutnikaToolStripMenuItem { get => dodajNovogPutnikaToolStripMenuItem; set => dodajNovogPutnikaToolStripMenuItem = value; }
        public ToolStripMenuItem DestinacijeToolStripMenuItem { get => destinacijeToolStripMenuItem; set => destinacijeToolStripMenuItem = value; }
        public ToolStripMenuItem PregledDestinacijaToolStripMenuItem { get => pregledDestinacijaToolStripMenuItem; set => pregledDestinacijaToolStripMenuItem = value; }
    }
}