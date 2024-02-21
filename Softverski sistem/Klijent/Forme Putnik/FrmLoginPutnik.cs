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
    public partial class FrmLoginPutnik : Form
    {
        private ControllerLogin controller = new ControllerLogin();
        public FrmLoginPutnik()
        {
            InitializeComponent();            
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            controller.LoginPutnik(this);
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmRegistracijaPutnika frmRegistracijaPutnika = new FrmRegistracijaPutnika();
            frmRegistracijaPutnika.ShowDialog();
            this.Visible = true;
        }

        private void chbPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            controller.CheckPutnikPass(this);
        }
    }
}
