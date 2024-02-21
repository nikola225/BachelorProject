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
    public partial class FrmZaboravljenaLozinka : Form
    {
        ControllerLogin controller = new ControllerLogin();
        public FrmZaboravljenaLozinka()
        {
            InitializeComponent();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            controller.GenerisiNoviPassword(this);
            this.Close();
        }
    }
}
