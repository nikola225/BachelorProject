using Common.Domenske_Klase;
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
    public partial class UCPregledajDestinacije : UserControl
    {
        ControllerDestinacija controller = new ControllerDestinacija();
        ControllerPomocni controllerPomocni = new ControllerPomocni();
        public UCPregledajDestinacije()
        {
            InitializeComponent();
            controller.InitUCDestinacije(this);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            controller.PokreniFormuDodaj(this);
            controller.InitUCDestinacije(this);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            controller.PokreniFormuIzmeni(this);
            controller.InitUCDestinacije(this);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            controller.ObrisiDestinaciju(this);
            controller.InitUCDestinacije(this);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            controller.PretraziDestinacije(this);
        }

        private void btnResetuj_Click(object sender, EventArgs e)
        {
            controller.InitUCDestinacije(this);
        }
    }
}
