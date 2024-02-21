using Common.Domenske_Klase;
using Klijent.Forms;
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

namespace Klijent.Forme_Putnik
{
    public partial class FrmRegistracijaPutnika : Form
    {
        ControllerRegistracija controller;
        public FrmRegistracijaPutnika()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controller = new ControllerRegistracija();
            controller.RegistrujPutnika(this);
        }
    }
}
