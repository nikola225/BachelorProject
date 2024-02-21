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

namespace Klijent.Forme_Admin
{
    public partial class FrmIzmeniDestinaciju : Form
    {
        ControllerDestinacija controller = new ControllerDestinacija();
        public FrmIzmeniDestinaciju(Destinacija destinacija)
        {
            InitializeComponent();
            controller.UcitajDestinaciju(this, destinacija);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controller.SacuvajIzmeneDestinacija(this);
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            controller.PromeniBoju(this.txtNaziv);
        }
    }
}
