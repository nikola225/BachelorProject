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
    public partial class UCDodajRezervaciju : UserControl
    {
        ControllerRezervacije controller = new ControllerRezervacije();
        public UCDodajRezervaciju()
        {
            InitializeComponent();
            controller.InitRezervacije(this);
        }

        private void btnOdaberiPutnika_Click(object sender, EventArgs e)
        {
            controller.OdaberiPutnika(this);
        }

        private void btnOdaberiAranzman_Click(object sender, EventArgs e)
        {
            controller.OdaberiAranzman(this);
        }

        private void btnSacuvajRezervaciju_Click(object sender, EventArgs e)
        {
            controller.SacuvajRezervaciju(this);
        }

        private void btnZapamtiSve_Click(object sender, EventArgs e)
        {
            controller.ZapamtiRezervacije(this);
            controller.InitRezervacije(this);
        }
    }
}
