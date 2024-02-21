using System.Windows.Forms;

namespace Klijent.Forme_Putnik
{
    partial class FrmGlavnaPutnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavnaPutnik));
            this.pnlPocetak = new System.Windows.Forms.Panel();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.menuGlavniMeni = new System.Windows.Forms.MenuStrip();
            this.aranžmaniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opšteInformacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervišiPutovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izborAranžmanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPocetak.SuspendLayout();
            this.menuGlavniMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPocetak
            // 
            this.pnlPocetak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPocetak.BackgroundImage")));
            this.pnlPocetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPocetak.Controls.Add(this.lblDobrodosli);
            this.pnlPocetak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPocetak.Location = new System.Drawing.Point(0, 28);
            this.pnlPocetak.Name = "pnlPocetak";
            this.pnlPocetak.Size = new System.Drawing.Size(800, 422);
            this.pnlPocetak.TabIndex = 6;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(229, 136);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(0, 79);
            this.lblDobrodosli.TabIndex = 0;
            // 
            // menuGlavniMeni
            // 
            this.menuGlavniMeni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGlavniMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aranžmaniToolStripMenuItem,
            this.rezervacijaToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuGlavniMeni.Location = new System.Drawing.Point(0, 0);
            this.menuGlavniMeni.Name = "menuGlavniMeni";
            this.menuGlavniMeni.Size = new System.Drawing.Size(800, 28);
            this.menuGlavniMeni.TabIndex = 5;
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
            this.opšteInformacijeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.opšteInformacijeToolStripMenuItem.Text = "Opšte informacije";
            this.opšteInformacijeToolStripMenuItem.Click += new System.EventHandler(this.opšteInformacijeToolStripMenuItem_Click);
            // 
            // rezervacijaToolStripMenuItem
            // 
            this.rezervacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervišiPutovanjeToolStripMenuItem,
            this.pregledajRezervacijeToolStripMenuItem});
            this.rezervacijaToolStripMenuItem.Name = "rezervacijaToolStripMenuItem";
            this.rezervacijaToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.rezervacijaToolStripMenuItem.Text = "Rezervacija";
            // 
            // rezervišiPutovanjeToolStripMenuItem
            // 
            this.rezervišiPutovanjeToolStripMenuItem.Name = "rezervišiPutovanjeToolStripMenuItem";
            this.rezervišiPutovanjeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rezervišiPutovanjeToolStripMenuItem.Text = "Rezerviši putovanje";
            this.rezervišiPutovanjeToolStripMenuItem.Click += new System.EventHandler(this.rezervišiPutovanjeToolStripMenuItem_Click);
            // 
            // pregledajRezervacijeToolStripMenuItem
            // 
            this.pregledajRezervacijeToolStripMenuItem.Name = "pregledajRezervacijeToolStripMenuItem";
            this.pregledajRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledajRezervacijeToolStripMenuItem.Text = "Moje rezervacije";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izborAranžmanaToolStripMenuItem});
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // izborAranžmanaToolStripMenuItem
            // 
            this.izborAranžmanaToolStripMenuItem.Name = "izborAranžmanaToolStripMenuItem";
            this.izborAranžmanaToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.izborAranžmanaToolStripMenuItem.Text = "Preporuka aranžmana";
            // 
            // FrmGlavnaPutnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPocetak);
            this.Controls.Add(this.menuGlavniMeni);
            this.Name = "FrmGlavnaPutnik";
            this.Text = "Dobrodošli, ";
            this.pnlPocetak.ResumeLayout(false);
            this.pnlPocetak.PerformLayout();
            this.menuGlavniMeni.ResumeLayout(false);
            this.menuGlavniMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPocetak;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.MenuStrip menuGlavniMeni;
        private System.Windows.Forms.ToolStripMenuItem aranžmaniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opšteInformacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervišiPutovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izborAranžmanaToolStripMenuItem;
        public Panel PnlPocetak { get => pnlPocetak; set => pnlPocetak = value; }
        public Label LblDobrodosli { get => lblDobrodosli; set => lblDobrodosli = value; }
        public MenuStrip MenuGlavniMeni { get => menuGlavniMeni; set => menuGlavniMeni = value; }
        public ToolStripMenuItem AranžmaniToolStripMenuItem { get => aranžmaniToolStripMenuItem; set => aranžmaniToolStripMenuItem = value; }
        public ToolStripMenuItem OpšteInformacijeToolStripMenuItem { get => opšteInformacijeToolStripMenuItem; set => opšteInformacijeToolStripMenuItem = value; }
        public ToolStripMenuItem RezervacijaToolStripMenuItem { get => rezervacijaToolStripMenuItem; set => rezervacijaToolStripMenuItem = value; }
        public ToolStripMenuItem RezervišiPutovanjeToolStripMenuItem { get => rezervišiPutovanjeToolStripMenuItem; set => rezervišiPutovanjeToolStripMenuItem = value; }
        public ToolStripMenuItem PregledajRezervacijeToolStripMenuItem { get => pregledajRezervacijeToolStripMenuItem; set => pregledajRezervacijeToolStripMenuItem = value; }
        public ToolStripMenuItem PomoćToolStripMenuItem { get => pomoćToolStripMenuItem; set => pomoćToolStripMenuItem = value; }
        public ToolStripMenuItem IzborAranžmanaToolStripMenuItem { get => izborAranžmanaToolStripMenuItem; set => izborAranžmanaToolStripMenuItem = value; }
    }
}