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

namespace Klijent.Forme_Putnik.User_kontrole
{
    public partial class UCProfilPutnik : UserControl
    {
        ControllerPutnik controller = new ControllerPutnik();
        public UCProfilPutnik()
        {
            InitializeComponent();
            controller.PutnikProfil(this);
        }

        private void chbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            controller.PutnikProfilCheckPass(this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controller.IzmeniProfil(this);
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            controller.SacuvajIzmeneNaProfilu(this);
            controller.PutnikProfil(this);
        }
    }
}
