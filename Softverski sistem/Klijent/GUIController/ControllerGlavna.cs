using Common.Domenske_Klase;
using Common.Klase;
using Klijent.Forme_Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.GUIController
{
    public class ControllerGlavna
    {
        bool aktivna = true;
        internal void InitDataAdmin(FrmGlavnaAdmin frmGlavnaAdmin)
        {
            if (aktivna)
            {
                User u = Sesija.Instance.PrijavljeniUser;
                frmGlavnaAdmin.Text = $"Dobrodošli, {u.FirstName}";
            }
            else
            {
                frmGlavnaAdmin.Close();
            }
        }

    }
}
