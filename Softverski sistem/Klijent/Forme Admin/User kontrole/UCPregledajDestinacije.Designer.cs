using System.Windows.Forms;

namespace Klijent.Forme_Admin.User_kontrole
{
    partial class UCPregledajDestinacije
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
            this.dgvPrikaziDestinacije = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblDestinacije = new System.Windows.Forms.Label();
            this.btnResetuj = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblPretrazi = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaziDestinacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikaziDestinacije
            // 
            this.dgvPrikaziDestinacije.AllowUserToAddRows = false;
            this.dgvPrikaziDestinacije.AllowUserToDeleteRows = false;
            this.dgvPrikaziDestinacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrikaziDestinacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrikaziDestinacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaziDestinacije.Location = new System.Drawing.Point(45, 332);
            this.dgvPrikaziDestinacije.Name = "dgvPrikaziDestinacije";
            this.dgvPrikaziDestinacije.ReadOnly = true;
            this.dgvPrikaziDestinacije.RowHeadersWidth = 51;
            this.dgvPrikaziDestinacije.RowTemplate.Height = 24;
            this.dgvPrikaziDestinacije.Size = new System.Drawing.Size(383, 150);
            this.dgvPrikaziDestinacije.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(190, 121);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(128, 36);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzmeni.Location = new System.Drawing.Point(190, 163);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(128, 36);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObrisi.Location = new System.Drawing.Point(190, 205);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(128, 36);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblDestinacije
            // 
            this.lblDestinacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDestinacije.AutoSize = true;
            this.lblDestinacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDestinacije.Location = new System.Drawing.Point(172, 54);
            this.lblDestinacije.Name = "lblDestinacije";
            this.lblDestinacije.Size = new System.Drawing.Size(166, 32);
            this.lblDestinacije.TabIndex = 4;
            this.lblDestinacije.Text = "Destinacije";
            // 
            // btnResetuj
            // 
            this.btnResetuj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetuj.Location = new System.Drawing.Point(333, 287);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(72, 29);
            this.btnResetuj.TabIndex = 77;
            this.btnResetuj.Text = "Resetuj";
            this.btnResetuj.UseVisualStyleBackColor = true;
            this.btnResetuj.Click += new System.EventHandler(this.btnResetuj_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(249, 287);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(78, 29);
            this.btnPretrazi.TabIndex = 76;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblPretrazi
            // 
            this.lblPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPretrazi.AutoSize = true;
            this.lblPretrazi.Location = new System.Drawing.Point(59, 271);
            this.lblPretrazi.Name = "lblPretrazi";
            this.lblPretrazi.Size = new System.Drawing.Size(123, 16);
            this.lblPretrazi.TabIndex = 75;
            this.lblPretrazi.Text = "Pretraži destinacije:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPretrazi.Location = new System.Drawing.Point(62, 290);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(174, 22);
            this.txtPretrazi.TabIndex = 74;
            // 
            // UCPregledajDestinacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblDestinacije);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPrikaziDestinacije);
            this.Name = "UCPregledajDestinacije";
            this.Size = new System.Drawing.Size(508, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaziDestinacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikaziDestinacije;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblDestinacije;
        private Button btnResetuj;
        private Button btnPretrazi;
        private Label lblPretrazi;
        private TextBox txtPretrazi;

        public DataGridView DgvPrikaziDestinacije { get => dgvPrikaziDestinacije; set => dgvPrikaziDestinacije = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Label LblDestinacije { get => lblDestinacije; set => lblDestinacije = value; }
        public Button BtnResetuj { get => btnResetuj; set => btnResetuj = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public Label LblPretrazi { get => lblPretrazi; set => lblPretrazi = value; }
        public TextBox TxtPretrazi { get => txtPretrazi; set => txtPretrazi = value; }
    }
}
