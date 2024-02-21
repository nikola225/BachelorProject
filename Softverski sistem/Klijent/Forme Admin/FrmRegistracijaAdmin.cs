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

namespace Klijent.Forms
{
    public partial class FrmRegistracijaAdmin : Form
    {
        ControllerRegistracija controller = new ControllerRegistracija();
        public FrmRegistracijaAdmin()
        {
            InitializeComponent();            
        }
        private void btnKreirajNalog_Click(object sender, EventArgs e)
        {
            controller.RegistrujAdministratora(this);
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            controller.ZatvoriFormu(this);
        }
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtIme);
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtPrezime);
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtEmail, this.LblUpozorenjeEmail);
        }
        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtKorisnickoIme, this.lblUpozorenje);
        }
        private void txtLozinka1_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtLozinka1);
        }
        private void txtLozinka2_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtLozinka2);
        }
        private void chbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            controller.PasswordCheck(this);
        }
    }
}
