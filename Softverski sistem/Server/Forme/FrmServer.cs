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

namespace Server
{
    public partial class FrmServer : Form
    {
        Server s;
        public FrmServer()
        {
            InitializeComponent();
        }     

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            btnPokreni.Enabled = false;
            btnZaustavi.Enabled = true;
            btnSignal.BackColor = Color.Green;
         
            s = new Server();
            Thread thread = new Thread(s.Start);
            thread.IsBackground = true;
            thread.Start();
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
            btnSignal.BackColor = Color.Red;
            s.Stop();
        }

        private void AzurirajLabelu()
        {
            lblVreme.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void PokreniPrikazVremena()
        {
            try
            {
                while (true)
                {
                    this.Invoke(new Action(AzurirajLabelu));
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doviđenja!");
            }
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            Thread nitVreme = new Thread(this.PokreniPrikazVremena);
            nitVreme.Start();
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
