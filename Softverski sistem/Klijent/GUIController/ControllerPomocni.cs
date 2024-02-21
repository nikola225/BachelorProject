using Common.Domenske_Klase;
using Common.Klase;
using Klijent.Forme_Admin;
using Klijent.Forme_Admin.User_kontrole;
using Klijent.Forme_Putnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GUIController
{
    public class ControllerPomocni
    {
        internal void AdminBar(User u, FrmGlavnaAdmin frmGlavnaAdmin)
        {
            u = Sesija.Instance.PrijavljeniUser;
            frmGlavnaAdmin.Text = $"Dobrodošli, {u.FirstName} {u.LastName}";
        }

        internal void ChangePanelAdmin(FrmGlavnaAdmin frmGlavnaAdmin, UserControl userControl)
        {
            frmGlavnaAdmin.PnlPocetak.Controls.Clear();
            frmGlavnaAdmin.PnlPocetak.BackgroundImage = null;
            userControl.Dock = DockStyle.Fill;
            frmGlavnaAdmin.PnlPocetak.Controls.Add(userControl);
        }

        internal void ChangePanelPutnik(FrmGlavnaPutnik frmGlavnaPutnik, UserControl userControl)
        {
            frmGlavnaPutnik.PnlPocetak.Controls.Clear();
            frmGlavnaPutnik.PnlPocetak.BackgroundImage = null;
            userControl.Dock = DockStyle.Fill;
            frmGlavnaPutnik.PnlPocetak.Controls.Add(userControl);
        }

    }
}
