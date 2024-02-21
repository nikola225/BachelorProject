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

namespace Klijent.Forme_Admin.User_kontrole
{
    public partial class UCPregledajAranzmane : UserControl
    {
        ControllerAranzman controller = new ControllerAranzman();
        public UCPregledajAranzmane()
        {
            InitializeComponent();
            controller.VratiSveAranzmane(this);
        }

        private void UCPregledajAranzmane_Load(object sender, EventArgs e)
        {
            controller.VratiSveAranzmane(this);
        }

        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            controller.UcitajAranzman(this);
        }

        private void btnIzmeniAranzman_Click(object sender, EventArgs e)
        {
            controller.IzmeniAranzman(this);
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            controller.SacuvajIzmene(this);
            controller.VratiSveAranzmane(this);
        }

        private void btnObrisiAranzman_Click(object sender, EventArgs e)
        {
            controller.ObrisiAranzman(this);
            controller.VratiSveAranzmane(this);
        }
    }
}
