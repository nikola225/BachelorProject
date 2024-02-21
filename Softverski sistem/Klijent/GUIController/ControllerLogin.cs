using Common.Domenske_Klase;
using Common.Klase;
using Klijent.Forme_Admin;
using Klijent.Forme_Putnik;
using Klijent.Forms;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GUIController
{
    public class ControllerLogin
    {
        static int brojPokusaja = 2;
        static int brojSekundi = 30;
        public void Connect()
        {
            Communication.Instance.Connect();
        }
        internal void LoginAdmin(FrmLoginAdmin frmLogin)
        {
            User u = new User()
            {
                Username = frmLogin.TxtKorisnickoIme.Text,
                Password = frmLogin.TxtLozinka.Text,
            };

            if (brojPokusaja > 0)
            {
                User user = Communication.Instance.LoginAdmin(u);
                if (user != null)
                {
                    Sesija.Instance.PrijavljeniUser = user;
                    MessageBox.Show("Uspešno ste se prijavili!");
                    frmLogin.LblGreska.Text = "";
                    frmLogin.Visible = false;
                    FrmGlavnaAdmin frmGlavnaAdmin = new FrmGlavnaAdmin(user);
                    frmGlavnaAdmin.ShowDialog();
                    MessageBox.Show("Doviđenja!");
                    frmLogin.TxtKorisnickoIme.Text = "";
                    frmLogin.TxtLozinka.Text = "";
                    frmLogin.Visible = true;
                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji! Preostali broj pokušaja je: " + brojPokusaja);
                    brojPokusaja--;
                }
            }
            else
            {
                MessageBox.Show("Previše pokušaja!");
                frmLogin.TxtKorisnickoIme.Enabled = false;
                frmLogin.TxtLozinka.Enabled = false;
                frmLogin.ChbPrikaziLozinku.Enabled = false;
                frmLogin.BtnPrijaviSe.Enabled = false;

                Thread nitVreme = new Thread(() => PokreniTimerAdmin(frmLogin));
                nitVreme.IsBackground = true;
                nitVreme.Start();
                brojPokusaja = 2;
                brojSekundi = 30;
            }
 
        }
        private void AzurirajLabeluAdmin(FrmLoginAdmin frmLoginAdmin)
        {
            frmLoginAdmin.LblGreska.Text = "Pokušajte ponovo za " + brojSekundi + " sekundi";
        }
        private void PokreniTimerAdmin(FrmLoginAdmin frmLoginAdmin)
        {
            Task.Run(() =>
            {
                while (brojSekundi > 0)
                {
                    frmLoginAdmin.Invoke(new Action(() => AzurirajLabeluAdmin(frmLoginAdmin)));
                    brojSekundi--;
                    Thread.Sleep(1000);
                }

                frmLoginAdmin.Invoke(new Action(() =>
                {
                    frmLoginAdmin.TxtKorisnickoIme.Enabled = true;
                    frmLoginAdmin.TxtLozinka.Enabled = true;
                    frmLoginAdmin.ChbPrikaziLozinku.Enabled = true;
                    frmLoginAdmin.BtnPrijaviSe.Enabled = true;
                    frmLoginAdmin.LblGreska.Text = "";
                    
                }));
            });
        }
        internal void LoginPutnik(FrmLoginPutnik frmLogin)
        {
            Putnik p = new Putnik
            {
                Username = frmLogin.TxtKorisnickoIme.Text,
                Password = frmLogin.TxtLozinka.Text,
            };

            if (brojPokusaja > 0)
            {
                Putnik putnik = Communication.Instance.LoginPutnik(p);
                if (putnik != null)
                {
                    Sesija.Instance.PrijavljeniPutnik = putnik;
                    frmLogin.LblGreska.Text = "";
                    frmLogin.Visible = false;
                    MessageBox.Show("Uspešno ste se prijavili!");
                    FrmGlavnaPutnik frmGlavnaPutnik = new FrmGlavnaPutnik(putnik);
                    frmGlavnaPutnik.ShowDialog();
                    frmLogin.Visible = true;
                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji! Preostali broj pokušaja je: " + brojPokusaja);
                    brojPokusaja--;
                }
            }
            else
            {
                MessageBox.Show("Previše pokušaja!");
                frmLogin.TxtKorisnickoIme.Enabled = false;
                frmLogin.TxtLozinka.Enabled = false;
                frmLogin.ChbPrikaziLozinku.Enabled = false;
                frmLogin.BtnPrijaviSe.Enabled = false;

                Thread nitVreme = new Thread(() => PokreniTimerPutnik(frmLogin));
                nitVreme.IsBackground = true;
                nitVreme.Start();
                brojPokusaja = 2;
                brojSekundi = 30;
            }
        }
        private void AzurirajLabeluPutnik(FrmLoginPutnik frmLoginPutnik)
        {
            frmLoginPutnik.LblGreska.Text = "Pokušajte ponovo za " + brojSekundi + " sekundi";
        }
        private void PokreniTimerPutnik(FrmLoginPutnik frmLoginPutnik)
        {
            Task.Run(() =>
            {
                while (brojSekundi > 0)
                {
                    frmLoginPutnik.Invoke(new Action(() => AzurirajLabeluPutnik(frmLoginPutnik)));
                    brojSekundi--;
                    Thread.Sleep(1000);
                }

                frmLoginPutnik.Invoke(new Action(() =>
                {
                    frmLoginPutnik.TxtKorisnickoIme.Enabled = true;
                    frmLoginPutnik.TxtLozinka.Enabled = true;
                    frmLoginPutnik.ChbPrikaziLozinku.Enabled = true;
                    frmLoginPutnik.BtnPrijaviSe.Enabled = true;
                    frmLoginPutnik.LblGreska.Text = "";

                }));
            });
        }
        internal void CheckAdminPass(FrmLoginAdmin frmLoginAdmin)
        {
            if (frmLoginAdmin.ChbPrikaziLozinku.Checked)
            {
                frmLoginAdmin.TxtLozinka.PasswordChar = '\0';
            }
            else
            {
                frmLoginAdmin.TxtLozinka.PasswordChar = '*';
            }

        }
        internal void CheckPutnikPass(FrmLoginPutnik frmLoginPutnik)
        {
            if (frmLoginPutnik.ChbPrikaziLozinku.Checked)
            {
                frmLoginPutnik.TxtLozinka.PasswordChar = '\0';
            }
            else
            {
                frmLoginPutnik.TxtLozinka.PasswordChar = '*';
            }
        }
        internal void Registracija(FrmLoginAdmin frmLoginAdmin)
        {
            frmLoginAdmin.Visible = false;
            FrmRegistracijaAdmin frmRegistracijaAdmin = new FrmRegistracijaAdmin();
            frmRegistracijaAdmin.ShowDialog();
            frmLoginAdmin.Visible = true;
        }
        internal void ZaboravljenaLozinka(FrmLoginAdmin frmLoginAdmin)
        {
            frmLoginAdmin.Visible = false;
            FrmZaboravljenaLozinka frmZaboravljenaLozinka = new FrmZaboravljenaLozinka();
            frmZaboravljenaLozinka.ShowDialog();
            frmLoginAdmin.Visible = true;
        }
        internal void GenerisiNoviPassword(FrmZaboravljenaLozinka frmZaboravljenaLozinka)
        {
            string mail = frmZaboravljenaLozinka.TxtEmail.Text;
            string noviPassword = Communication.Instance.GenerisiPassword(7);
            if (Communication.Instance.SendEmail(mail, noviPassword))
            {
                MessageBox.Show("Nova lozinka poslata je na Vaš email: " + mail);
            }
            else
            {
                MessageBox.Show("Nije pronađena Vaša email adresa u sistemu.\nProverite da li ste uneli ispravnu email adresu.");
            }
        }
        internal void Zatvori(FrmLoginAdmin frmLoginAdmin)
        {
            Communication.Instance.ZatvoriAplikaciju();
            Application.Exit();
        }
    }
}
