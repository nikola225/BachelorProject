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
    public partial class UCPregledajRezervacije : UserControl
    {
        ControllerRezervacije controller = new ControllerRezervacije();
        public UCPregledajRezervacije()
        {
            InitializeComponent();
            controller.UcitajRezervacije(this);
        }

        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            controller.OdaberiRezervaciju(this);
        }

        private void btnPromeniPutnika_Click(object sender, EventArgs e)
        {
            controller.PromeniPutnika(this);
        }

        private void btnPromeniAranzman_Click(object sender, EventArgs e)
        {
            controller.PromeniAranzman(this);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            controller.Odustani(this);
            controller.UcitajRezervacije(this);
            controller.Reset(this);
        }

        private void btnSacuvajPromene_Click(object sender, EventArgs e)
        {
            controller.SacuvajPromene(this);
            controller.UcitajRezervacije(this);
            controller.Reset(this);
        }

        private void btnObrisiRezervaciju_Click(object sender, EventArgs e)
        {
            controller.ObrisiRezervaciju(this);
            controller.UcitajRezervacije(this);
            controller.Reset(this);
        }

        private void btnPretrazi1_Click(object sender, EventArgs e)
        {
            controller.Pretrazi(this);
        }

        private void btnResetuj1_Click(object sender, EventArgs e)
        {
            controller.Reset(this);
            controller.UcitajRezervacije(this);
        }

    }
}
