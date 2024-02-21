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
    public partial class UCDodajPutnika : UserControl
    {
        private UCPregledajPutnike ucPregledajPutnike = new UCPregledajPutnike();
        ControllerPutnik controller = new ControllerPutnik();
        public UCDodajPutnika()
        {
            InitializeComponent();
        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controller.DodajPutnika(this);
        }
        private void txtJMBG_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtJMBG, this.LblUpozorenjeJMBG);
        }
        private void txtBrojPasosa_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtBrojPasosa, this.LblUpozorenjeBrPasosa);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtEmail, this.LblUpozorenjeEmail);
        }
        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtKorisnickoIme, this.LblUpozorenjeUsername);
        }
        private void txtLozinka2_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtLozinka2);
        }
        private void chbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            controller.PutnikCheckPass(this);
        }
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtIme);
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtPrezime);
        }
        private void txtBrojTelefona_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtBrojTelefona);
        }
        private void txtLozinka1_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtLozinka1);
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.Reset(this);
        }
    }
}
