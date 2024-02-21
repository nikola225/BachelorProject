using Common.Klase;
using Klijent.Forme_Admin.User_kontrole;
using Klijent.Forms.User_kontrole;
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

namespace Klijent.Forme_Admin
{
    public partial class FrmGlavnaAdmin : Form
    {
        UCProfil ucProfil = new UCProfil();
        ControllerPomocni controller = new ControllerPomocni();
        ControllerAranzman controllerAranzman = new ControllerAranzman();
        ControllerRezervacije controllerRezervacije = new ControllerRezervacije();
        UCPregledajDestinacije ucPregledajDestinacije = new UCPregledajDestinacije();
        UCPregledajAranzmane ucPregledajAranzmane = new UCPregledajAranzmane(); 
        UCDodajAranzman ucDodajAranzman = new UCDodajAranzman();
        UCPregledajPutnike ucPregledajPutnike = new UCPregledajPutnike();
        UCDodajPutnika ucDodajPutnika = new UCDodajPutnika();
        UCPregledajRezervacije ucPregledajRezervacije = new UCPregledajRezervacije();
        UCDodajRezervaciju ucDodajRezervaciju = new UCDodajRezervaciju();
        public FrmGlavnaAdmin(User u)
        {
            InitializeComponent();
            controller.AdminBar(u, this);
        }
        private void pregledDestinacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelAdmin(this, ucPregledajDestinacije);
        }
        private void pregledajPonudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelAdmin(this, ucPregledajAranzmane);
            controllerAranzman.VratiSveAranzmane(ucPregledajAranzmane);
        }
        private void dodajAranžmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelAdmin(this, ucDodajAranzman);
        }
        private void izborAranžmanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelAdmin(this, ucPregledajPutnike);
        }
        private void dodajNovogPutnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelAdmin(this, ucDodajPutnika);
        }
        private void opšteInformacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelAdmin(this, ucProfil);
        }
        private void pregledajRezervacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelAdmin(this, ucPregledajRezervacije);
        }

        private void kreirajRezervacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelAdmin(this, ucDodajRezervaciju);
            controllerRezervacije.InitRezervacije(ucDodajRezervaciju);
        }
    }
}
