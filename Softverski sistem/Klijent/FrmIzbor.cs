using Klijent.Forme_Putnik;
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

namespace Klijent
{
    public partial class FrmIzbor : Form
    {
        ControllerIzbor controller = new ControllerIzbor();
        public FrmIzbor()
        {
            InitializeComponent();           
        }

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            controller.Connect();
            this.Visible = false;
            FrmLoginAdmin frmLoginAdmin = new FrmLoginAdmin();
            frmLoginAdmin.ShowDialog();
            this.Visible = true;
        }

        private void btnPutnik_Click(object sender, EventArgs e)
        {
            controller.Connect();
            this.Visible = false;
            FrmLoginPutnik frmLoginPutnik = new FrmLoginPutnik();
            frmLoginPutnik.ShowDialog();
            this.Visible = true;
        }
    }
}
