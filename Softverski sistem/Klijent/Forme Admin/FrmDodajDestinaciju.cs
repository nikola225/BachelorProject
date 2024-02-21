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
    public partial class FrmDodajDestinaciju : Form
    {
        ControllerDestinacija controller = new ControllerDestinacija();
        public FrmDodajDestinaciju()
        {
            InitializeComponent();
            controller.Init(this);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controller.Dodaj(this);
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.TxtNaziv);
        }
    }
}
