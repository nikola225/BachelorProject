using Klijent.Forme_Putnik;
using Klijent.Forms;
using Klijent.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class FrmLoginAdmin : Form
    {
        private ControllerLogin controller = new ControllerLogin();
        public FrmLoginAdmin()
        {
            InitializeComponent();
            controller.Connect();
        }
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            controller.LoginAdmin(this);
        }
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            controller.Registracija(this);
        }

        private void chbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            controller.CheckAdminPass(this);
        }

        private void lblZaboravljenPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controller.ZaboravljenaLozinka(this);
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.Zatvori(this);
        }
    }
}
