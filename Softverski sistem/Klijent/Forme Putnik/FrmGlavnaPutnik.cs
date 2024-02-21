using Common.Domenske_Klase;
using Klijent.Forme_Admin.User_kontrole;
using Klijent.Forme_Putnik.User_kontrole;
using Klijent.Forms.User_kontrole;
using Klijent.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.Forme_Putnik
{
    public partial class FrmGlavnaPutnik : Form
    {
        UCProfilPutnik ucProfilPutnik = new UCProfilPutnik();
        ControllerPomocni controller = new ControllerPomocni();
        UCRezervacije ucRezervacije = new UCRezervacije();

        public FrmGlavnaPutnik(Putnik p)
        {
            InitializeComponent();
        }

        private void opšteInformacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelPutnik(this, ucProfilPutnik);
        }

        private void rezervišiPutovanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.ChangePanelPutnik(this, ucRezervacije);
        }
    }
}
