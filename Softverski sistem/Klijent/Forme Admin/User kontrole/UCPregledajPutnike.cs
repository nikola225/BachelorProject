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
    public partial class UCPregledajPutnike : UserControl
    {
        ControllerPutnik controller = new ControllerPutnik();
        public UCPregledajPutnike()
        {
            InitializeComponent();
            controller.VratiSvePutnike(this);
        }

        private void UCPregledajPutnike_Load(object sender, EventArgs e)
        {
            controller.VratiSvePutnike(this);
        }

        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            controller.UcitajPutnika(this);
        }

        private void btnIzmeniPutnika_Click(object sender, EventArgs e)
        {
            controller.IzmeniPutnika(this);
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            controller.SacuvajIzmene(this);
        }

        private void btnObrisiPutnika_Click(object sender, EventArgs e)
        {
            controller.ObrisiPutnika(this);
            controller.VratiSvePutnike(this);
            controller.ResetujPrikaz(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.PretraziPutnike(this);
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            controller.VratiSvePutnike(this);
            controller.ResetujPrikaz(this);
        }

        private void btnIzvezi_Click(object sender, EventArgs e)
        {
            controller.Izvezi(this);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtIme);
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtPrezime);
        }

        private void txtJMBG_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtJMBG);
        }

        private void txtBrojPasosa_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtBrojPasosa);
        }

        private void txtBrojTelefona_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtBrojTelefona);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtEmail);
        }

        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtKorisnickoIme);
        }

        private void txtLozinka1_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtLozinka1);
        }
    }
}
