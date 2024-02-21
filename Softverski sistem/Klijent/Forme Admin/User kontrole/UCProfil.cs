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

namespace Klijent.Forme_Admin.User_kontrole
{
    public partial class UCProfil : UserControl
    {
        ControllerAdmin controller = new ControllerAdmin();
        public UCProfil()
        {
            InitializeComponent();
            controller.AdminProfil(this);
        }
        private void chbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            controller.AdminProfilCheckPass(this);
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controller.IzmeniProfil(this);
        }
        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            controller.SacuvajIzmene(this);
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.Reset(this);
            controller.AdminProfil(this);
        }
        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.txtLozinka);
        }
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.txtIme);
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.txtPrezime);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.txtEmail);
        }
    }
}
