using Common.Domenske_Klase;
using Common.Klase;
using Klijent.Forme_Admin.User_kontrole;
using Klijent.Forme_Putnik.User_kontrole;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Klijent.GUIController
{
    public class ControllerPutnik
    {
        BindingList<Putnik> listaPutnika = new BindingList<Putnik>();
        internal void PutnikProfil(UCProfilPutnik ucProfilPutnik)
        {
            Putnik p = new Putnik();
            p = Sesija.Instance.PrijavljeniPutnik;

            ucProfilPutnik.TxtIme.Text = p.FirstName;
            ucProfilPutnik.TxtPrezime.Text = p.LastName;
            ucProfilPutnik.TxtEmail.Text = p.Email;
            ucProfilPutnik.TxtKorisnickoIme.Text = p.Username;
            ucProfilPutnik.TxtLozinka.Text = p.Password;
            ucProfilPutnik.TxtBrojPasosa.Text = p.PassportNumber;
            ucProfilPutnik.TxtJMBG.Text = p.JMBG;
            ucProfilPutnik.TxtBrojTelefona.Text = p.PhoneNumber;
            ucProfilPutnik.BtnSacuvajIzmene.Enabled = false;

            ucProfilPutnik.BtnIzmeni.Enabled = true;
            ucProfilPutnik.BtnSacuvajIzmene.Enabled = false;

            ucProfilPutnik.TxtIme.ReadOnly = true;
            ucProfilPutnik.TxtPrezime.ReadOnly = true;
            ucProfilPutnik.TxtKorisnickoIme.ReadOnly = true;
            ucProfilPutnik.TxtLozinka.ReadOnly = true;
            ucProfilPutnik.TxtEmail.ReadOnly = true;
            ucProfilPutnik.TxtJMBG.ReadOnly = true;
            ucProfilPutnik.TxtBrojPasosa.ReadOnly = true;
            ucProfilPutnik.TxtBrojTelefona.ReadOnly = true;
        }
        internal void DodajPutnika(UCDodajPutnika ucDodajPutnika)
        {
            bool postoji = false;

            Putnik putnik = new Putnik()
            {
                FirstName = ucDodajPutnika.TxtIme.Text,
                LastName = ucDodajPutnika.TxtPrezime.Text,
                Username = ucDodajPutnika.TxtKorisnickoIme.Text,
                Password = ucDodajPutnika.TxtLozinka1.Text,
                Email = ucDodajPutnika.TxtEmail.Text,
                JMBG = ucDodajPutnika.TxtJMBG.Text,
                PassportNumber = ucDodajPutnika.TxtBrojPasosa.Text,
                PhoneNumber = ucDodajPutnika.TxtBrojTelefona.Text,
            };

            postoji = ValidacijaDodaj(putnik, ucDodajPutnika);

            if (postoji == false)
            {
                if (Communication.Instance.RegistrujPutnika(putnik))
                {
                    MessageBox.Show("Uspešno ste dodali novog putnika!");
                    Reset(ucDodajPutnika);
                }
                else
                {
                    MessageBox.Show("Greška! Proverite ispravnost unetih podataka!");
                } 
            }
            
        }
        internal bool ValidacijaDodaj(Putnik putnik, UCDodajPutnika ucDodajPutnika)
        {
            BindingList<Putnik> putnici = new BindingList<Putnik>();
            putnici = Communication.Instance.VratiSvePutnike(putnici);
            bool postoji = false;

            if (ucDodajPutnika.TxtKorisnickoIme.Text == "" || ucDodajPutnika.TxtLozinka1.Text == ""
                || ucDodajPutnika.TxtLozinka2.Text == "" || ucDodajPutnika.TxtIme.Text == "" || ucDodajPutnika.TxtPrezime.Text == ""
                || ucDodajPutnika.TxtEmail.Text == "" || ucDodajPutnika.TxtBrojPasosa.Text == "" || ucDodajPutnika.TxtJMBG.Text == ""
                || ucDodajPutnika.TxtBrojTelefona.Text == "")
            {
                postoji = true;
            }

            isNull(ucDodajPutnika.TxtKorisnickoIme);
            isNull(ucDodajPutnika.TxtLozinka1);
            isNull(ucDodajPutnika.TxtLozinka2);
            isNull(ucDodajPutnika.TxtIme);
            isNull(ucDodajPutnika.TxtPrezime);
            isNull(ucDodajPutnika.TxtEmail);
            isNull(ucDodajPutnika.TxtJMBG);
            isNull(ucDodajPutnika.TxtBrojPasosa);
            isNull(ucDodajPutnika.TxtBrojTelefona);

            foreach (Putnik p in putnici)
            {

                if (p.Username.Equals(putnik.Username))
                {
                    ucDodajPutnika.TxtKorisnickoIme.Text = "";
                    ucDodajPutnika.TxtKorisnickoIme.BackColor = Color.Salmon;
                    ucDodajPutnika.LblUpozorenjeUsername.Text = "Username već postoji!";
                    postoji = true;
                }

                if (p.JMBG.Equals(putnik.JMBG))
                {
                    ucDodajPutnika.TxtJMBG.Text = "";
                    ucDodajPutnika.TxtJMBG.BackColor = Color.Salmon;
                    ucDodajPutnika.LblUpozorenjeJMBG.Text = "JMBG već postoji!";
                    postoji = true;
                }

                if (p.PassportNumber.Equals(putnik.PassportNumber))
                {
                    ucDodajPutnika.TxtBrojPasosa.Text = "";
                    ucDodajPutnika.TxtBrojPasosa.BackColor = Color.Salmon;
                    ucDodajPutnika.LblUpozorenjeBrPasosa.Text = "Broj pasoša već postoji!";
                    postoji = true;
                }

                if (p.Email.Equals(putnik.Email))
                {
                    ucDodajPutnika.TxtEmail.Text = "";
                    ucDodajPutnika.TxtEmail.BackColor = Color.Salmon;
                    ucDodajPutnika.LblUpozorenjeEmail.Text = "Email već postoji!";
                    postoji = true;
                }
            }

            if(ucDodajPutnika.TxtLozinka1.Text != ucDodajPutnika.TxtLozinka2.Text)
            {
                ucDodajPutnika.TxtLozinka1.Text = "";
                ucDodajPutnika.TxtLozinka2.Text = "";
                ucDodajPutnika.TxtLozinka2.BackColor = Color.Salmon;
                MessageBox.Show("Lozinke se ne poklapaju!");
                postoji = true;
            }

            if (ucDodajPutnika.TxtBrojPasosa.Text.Length != 9)
            {
                ucDodajPutnika.TxtBrojPasosa.Text = "";
                ucDodajPutnika.TxtBrojPasosa.BackColor = Color.Salmon;
                MessageBox.Show("Broj pasoša mora sadržati tačno 9 cifara!");
                postoji = true;
            }

            if (ucDodajPutnika.TxtJMBG.Text.Length != 13)
            {
                ucDodajPutnika.TxtJMBG.Text = "";
                ucDodajPutnika.TxtJMBG.BackColor = Color.Salmon;
                MessageBox.Show("JMBG mora sadržati tačno 13 cifara!");
                postoji = true;
            }

            return postoji;
        }
        internal bool ValidacijaIzmeni(Putnik putnik, UCPregledajPutnike ucPregledajPutnike)
        {
            BindingList<Putnik> putnici = new BindingList<Putnik>();
            putnici = Communication.Instance.VratiSvePutnike(putnici);
            bool postoji = false;

            if (ucPregledajPutnike.TxtKorisnickoIme.Text == "" || ucPregledajPutnike.TxtLozinka1.Text == ""
                || ucPregledajPutnike.TxtIme.Text == "" || ucPregledajPutnike.TxtPrezime.Text == ""
                || ucPregledajPutnike.TxtEmail.Text == "" || ucPregledajPutnike.TxtBrojPasosa.Text == "" || ucPregledajPutnike.TxtJMBG.Text == ""
                || ucPregledajPutnike.TxtBrojTelefona.Text == "")
            {
                postoji = true;
            }

            isNull(ucPregledajPutnike.TxtKorisnickoIme);
            isNull(ucPregledajPutnike.TxtLozinka1);
            isNull(ucPregledajPutnike.TxtIme);
            isNull(ucPregledajPutnike.TxtPrezime);
            isNull(ucPregledajPutnike.TxtEmail);
            isNull(ucPregledajPutnike.TxtJMBG);
            isNull(ucPregledajPutnike.TxtBrojPasosa);
            isNull(ucPregledajPutnike.TxtBrojTelefona);

            foreach (Putnik p in putnici)
            {

                if (p.Username != putnik.Username)
                {
                    if (p.JMBG.Equals(putnik.JMBG))
                    {
                        ucPregledajPutnike.TxtJMBG.Text = "JMBG već postoji!";
                        ucPregledajPutnike.TxtJMBG.BackColor = Color.Salmon;
                        postoji = true;
                    }

                    if (p.PassportNumber.Equals(putnik.PassportNumber))
                    {
                        ucPregledajPutnike.TxtBrojPasosa.Text = "Broj pasoša već postoji!";
                        ucPregledajPutnike.TxtBrojPasosa.BackColor = Color.Salmon;
                        postoji = true;
                    }

                    if (p.Email.Equals(putnik.Email))
                    {
                        ucPregledajPutnike.TxtEmail.Text = "Email već postoji!";
                        ucPregledajPutnike.TxtEmail.BackColor = Color.Salmon;
                        postoji = true;
                    }
                }
            }

            if (ucPregledajPutnike.TxtBrojPasosa.Text.Length != 9)
            {
                ucPregledajPutnike.TxtBrojPasosa.Text = "Broj pasoša mora sadržati tačno 9 cifara!";
                ucPregledajPutnike.TxtBrojPasosa.BackColor = Color.Salmon;
                postoji = true;
            }

            if (ucPregledajPutnike.TxtJMBG.Text.Length != 13)
            {
                ucPregledajPutnike.TxtJMBG.Text = "JMBG mora sadržati tačno 13 cifara!";
                ucPregledajPutnike.TxtJMBG.BackColor = Color.Salmon;
                postoji = true;
            }

            return postoji;
        }
        internal void IzmeniPutnika(UCPregledajPutnike ucPregledajPutnike)
        {
            ucPregledajPutnike.BtnPrikaziDetalje.Enabled = false;
            ucPregledajPutnike.BtnIzmeniPutnika.Enabled = false;
            ucPregledajPutnike.BtnObrisiPutnika.Enabled = true;
            ucPregledajPutnike.BtnSacuvajIzmene.Enabled = true;

            ucPregledajPutnike.TxtIme.ReadOnly = false;
            ucPregledajPutnike.TxtPrezime.ReadOnly = false;
            ucPregledajPutnike.TxtKorisnickoIme.ReadOnly = true;
            ucPregledajPutnike.TxtLozinka1.ReadOnly = false;
            ucPregledajPutnike.TxtEmail.ReadOnly = false;
            ucPregledajPutnike.TxtJMBG.ReadOnly = false;
            ucPregledajPutnike.TxtBrojPasosa.ReadOnly = false;
            ucPregledajPutnike.TxtBrojTelefona.ReadOnly = false; 
        }
        internal void IzmeniProfil(UCProfilPutnik ucProfilPutnik)
        {
            ucProfilPutnik.BtnIzmeni.Enabled = false;
            ucProfilPutnik.BtnSacuvajIzmene.Enabled = true;

            ucProfilPutnik.TxtIme.ReadOnly = false;
            ucProfilPutnik.TxtPrezime.ReadOnly = false;
            ucProfilPutnik.TxtKorisnickoIme.ReadOnly = true;
            ucProfilPutnik.TxtLozinka.ReadOnly = false;
            ucProfilPutnik.TxtEmail.ReadOnly = false;
            ucProfilPutnik.TxtJMBG.ReadOnly = false;
            ucProfilPutnik.TxtBrojPasosa.ReadOnly = false;
            ucProfilPutnik.TxtBrojTelefona.ReadOnly = false;
        }
        internal void ObrisiPutnika(UCPregledajPutnike ucPregledajPutnike)
        {
            Putnik putnik = new Putnik()
            {
                FirstName = ucPregledajPutnike.TxtIme.Text,
                LastName = ucPregledajPutnike.TxtPrezime.Text,
                Email = ucPregledajPutnike.TxtEmail.Text,
                JMBG = ucPregledajPutnike.TxtJMBG.Text,
                PassportNumber = ucPregledajPutnike.TxtBrojPasosa.Text,
                PhoneNumber = ucPregledajPutnike.TxtBrojTelefona.Text,
                Username = ucPregledajPutnike.TxtKorisnickoIme.Text,
                Password = ucPregledajPutnike.TxtLozinka1.Text
            };

            if (Communication.Instance.ObrisiPutnika(putnik))
            {
                MessageBox.Show("Uspešno ste obrisali putnika!");
                ucPregledajPutnike.DgvPrikaziPutnike.Refresh();
            }
            else
            {
                MessageBox.Show("Greška, nije moguće obrisati putnika!");
            }
        }
        internal void PretraziPutnike(UCPregledajPutnike ucPregledajPutnike)
        {
            string kriterijum = ucPregledajPutnike.TxtPretrazi.Text;
            BindingList<Putnik> pronadjeniPutnici = new BindingList<Putnik>();

            if (ucPregledajPutnike.TxtPretrazi.Text == "")
            {
                MessageBox.Show("Niste uneli kriterijuim za pretragu!");
            }
            else
            {
                pronadjeniPutnici = Communication.Instance.PronadjiPutnike(pronadjeniPutnici, kriterijum);

                if (pronadjeniPutnici.Count > 0)
                {
                    ucPregledajPutnike.DgvPrikaziPutnike.DataSource = null;
                    ucPregledajPutnike.DgvPrikaziPutnike.DataSource = new BindingList<Putnik>(pronadjeniPutnici);
                    ucPregledajPutnike.DgvPrikaziPutnike.Columns["DeleteCondition"].Visible = false;
                }
                else
                {
                    ucPregledajPutnike.TxtPretrazi.Text = "";
                    MessageBox.Show("Nije pronađen nijedan putnik!");
                }
            }
            
        }
        internal void PutnikProfilCheckPass(UCProfilPutnik ucProfilPutnik)
        {
            if (ucProfilPutnik.ChbPrikaziLozinku.Checked)
            {
                ucProfilPutnik.TxtLozinka.PasswordChar = '\0';
            }
            else
            {
                ucProfilPutnik.TxtLozinka.PasswordChar = '*';
            }
        }
        internal void PutnikCheckPass(UCDodajPutnika ucDodajPutnika)
        {
            if (ucDodajPutnika.ChbPrikaziLozinku.Checked)
            {
                ucDodajPutnika.TxtLozinka1.PasswordChar = '\0';
                ucDodajPutnika.TxtLozinka2.PasswordChar = '\0';
            }
            else
            {
                ucDodajPutnika.TxtLozinka1.PasswordChar = '*';
                ucDodajPutnika.TxtLozinka2.PasswordChar = '*';
            }
        }
        internal void Reset(UCDodajPutnika ucDodajPutnika)
        {
            ucDodajPutnika.TxtIme.Text = null;
            ucDodajPutnika.TxtPrezime.Text = null;
            ucDodajPutnika.TxtKorisnickoIme.Text = null;
            ucDodajPutnika.TxtLozinka1.Text = null;
            ucDodajPutnika.TxtLozinka2.Text = null;
            ucDodajPutnika.TxtEmail.Text = null;
            ucDodajPutnika.TxtJMBG.Text = null;
            ucDodajPutnika.TxtBrojPasosa.Text = null;
            ucDodajPutnika.TxtBrojTelefona.Text = null;

            ucDodajPutnika.TxtIme.BackColor = Color.White;
            ucDodajPutnika.TxtPrezime.BackColor = Color.White;
            ucDodajPutnika.TxtKorisnickoIme.BackColor = Color.White;
            ucDodajPutnika.TxtLozinka1.BackColor = Color.White;
            ucDodajPutnika.TxtLozinka2.BackColor = Color.White;
            ucDodajPutnika.TxtEmail.BackColor = Color.White;
            ucDodajPutnika.TxtJMBG.BackColor = Color.White;
            ucDodajPutnika.TxtBrojPasosa.BackColor = Color.White;
            ucDodajPutnika.TxtBrojTelefona.BackColor = Color.White;

        }
        internal void SacuvajIzmene(UCPregledajPutnike ucPregledajPutnike)
        {
            bool postoji = false;

            Putnik putnik = new Putnik()
            {
                FirstName = ucPregledajPutnike.TxtIme.Text,
                LastName = ucPregledajPutnike.TxtPrezime.Text,
                Email = ucPregledajPutnike.TxtEmail.Text,
                JMBG = ucPregledajPutnike.TxtJMBG.Text,
                PassportNumber = ucPregledajPutnike.TxtBrojPasosa.Text,
                PhoneNumber = ucPregledajPutnike.TxtBrojTelefona.Text,
                Username = ucPregledajPutnike.TxtKorisnickoIme.Text,
                Password = ucPregledajPutnike.TxtLozinka1.Text
            };

            postoji = ValidacijaIzmeni(putnik, ucPregledajPutnike);

            if (postoji == false)
            {
                if (Communication.Instance.SacuvajIzmenePutnika(putnik))
                {
                    MessageBox.Show("Uspešno ste sačuvali izmene!");
                    ucPregledajPutnike.BtnPrikaziDetalje.Enabled = true;
                    ucPregledajPutnike.DgvPrikaziPutnike.Refresh();
                    ResetujPrikaz(ucPregledajPutnike);
                    VratiSvePutnike(ucPregledajPutnike);
                }
                else
                {
                    MessageBox.Show("Greška, nije moguće sačuvati izmene!");
                } 
            }
        }
        internal void SacuvajIzmeneNaProfilu(UCProfilPutnik ucProfilPutnik)
        {
            Putnik putnik = new Putnik()
            {
                FirstName = ucProfilPutnik.TxtIme.Text,
                LastName = ucProfilPutnik.TxtPrezime.Text,
                Email = ucProfilPutnik.TxtEmail.Text,
                JMBG = ucProfilPutnik.TxtJMBG.Text,
                PassportNumber = ucProfilPutnik.TxtBrojPasosa.Text,
                PhoneNumber = ucProfilPutnik.TxtBrojTelefona.Text,
                Username = ucProfilPutnik.TxtKorisnickoIme.Text,
                Password = ucProfilPutnik.TxtLozinka.Text
            };

            if (Communication.Instance.SacuvajIzmenePutnika(putnik))
            {
                MessageBox.Show("Uspešno ste sačuvali izmene!");
                Sesija.Instance.PrijavljeniPutnik = putnik;
            }
            else
            {
                MessageBox.Show("Greška, nije moguće sačuvati izmene!");
            }
        }
        internal void UcitajPutnika(UCPregledajPutnike ucPregledajPutnike)
        {

            if (ucPregledajPutnike.DgvPrikaziPutnike.SelectedRows.Count > 0)
            {
                ucPregledajPutnike.BtnPrikaziDetalje.Enabled = true;
                ucPregledajPutnike.BtnIzmeniPutnika.Enabled = true;
                ucPregledajPutnike.BtnObrisiPutnika.Enabled = true;
                ucPregledajPutnike.BtnSacuvajIzmene.Enabled = false;

                Putnik putnik = (Putnik)ucPregledajPutnike.DgvPrikaziPutnike.SelectedRows[0].DataBoundItem;
                ucPregledajPutnike.TxtIme.Text = putnik.FirstName;
                ucPregledajPutnike.TxtPrezime.Text = putnik.LastName;
                ucPregledajPutnike.TxtEmail.Text = putnik.Email;
                ucPregledajPutnike.TxtJMBG.Text = putnik.JMBG;
                ucPregledajPutnike.TxtBrojPasosa.Text = putnik.PassportNumber;
                ucPregledajPutnike.TxtKorisnickoIme.Text = putnik.Username;
                ucPregledajPutnike.TxtLozinka1.Text = putnik.Password;
                ucPregledajPutnike.TxtBrojTelefona.Text = putnik.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Niste odabrali putnika!");
            }

        }
        internal void VratiSvePutnike(UCPregledajPutnike ucPregledajPutnike)
        {
            ucPregledajPutnike.TxtPretrazi.Text = null;
            ucPregledajPutnike.DgvPrikaziPutnike.DataSource = null;

            ucPregledajPutnike.TxtIme.Text = null;
            ucPregledajPutnike.TxtPrezime.Text = null;
            ucPregledajPutnike.TxtEmail.Text = null;
            ucPregledajPutnike.TxtJMBG.Text = null;
            ucPregledajPutnike.TxtBrojPasosa.Text = null;
            ucPregledajPutnike.TxtKorisnickoIme.Text = null;
            ucPregledajPutnike.TxtLozinka1.Text = null;
            ucPregledajPutnike.TxtBrojTelefona.Text = null;

            BindingList<Putnik> ucitanaLista = new BindingList<Putnik>(Communication.Instance.VratiSvePutnike(listaPutnika));
            ucPregledajPutnike.DgvPrikaziPutnike.DataSource = ucitanaLista;
            ucPregledajPutnike.DgvPrikaziPutnike.Columns["DeleteCondition"].Visible = false;
            

        }
        internal void Izvezi(UCPregledajPutnike ucPregledajPutnike)
        {
            ExcelPackage paket = Communication.Instance.Izvezi(ucPregledajPutnike.DgvPrikaziPutnike);

            bool uspesnoSacuvano = false;

            Thread novaNit = new Thread(() =>
            {
                ucPregledajPutnike.Invoke(new Action(() =>
                {
                    bool rezultat = Communication.Instance.SacuvajExcel(paket);
                    uspesnoSacuvano = rezultat;

                    if (uspesnoSacuvano)
                    {
                        MessageBox.Show("Uspešno ste eksportovali podatke!");
                    }
                    else
                    {
                        MessageBox.Show("Greška pri eksportovanju podataka!");
                    }
                }));
            });

            novaNit.IsBackground = true;
            novaNit.Start();

        }
        internal void ResetujPrikaz(UCPregledajPutnike ucPregledajPutnike)
        {
            ucPregledajPutnike.BtnPrikaziDetalje.Enabled = true;
            ucPregledajPutnike.BtnIzmeniPutnika.Enabled = false;
            ucPregledajPutnike.BtnSacuvajIzmene.Enabled = false;
            ucPregledajPutnike.BtnObrisiPutnika.Enabled = false;

            ucPregledajPutnike.TxtIme.ReadOnly = true;
            ucPregledajPutnike.TxtPrezime.ReadOnly = true;
            ucPregledajPutnike.TxtEmail.ReadOnly = true;
            ucPregledajPutnike.TxtJMBG.ReadOnly = true;
            ucPregledajPutnike.TxtBrojPasosa.ReadOnly = true;
            ucPregledajPutnike.TxtKorisnickoIme.ReadOnly = true;
            ucPregledajPutnike.TxtLozinka1.ReadOnly = true;
            ucPregledajPutnike.TxtBrojTelefona.ReadOnly = true;

            ucPregledajPutnike.TxtIme.BackColor = Color.White;
            ucPregledajPutnike.TxtPrezime.BackColor = Color.White;
            ucPregledajPutnike.TxtKorisnickoIme.BackColor = Color.White;
            ucPregledajPutnike.TxtLozinka1.BackColor = Color.White;
            ucPregledajPutnike.TxtEmail.BackColor = Color.White;
            ucPregledajPutnike.TxtJMBG.BackColor = Color.White;
            ucPregledajPutnike.TxtBrojPasosa.BackColor = Color.White;
            ucPregledajPutnike.TxtBrojTelefona.BackColor = Color.White;
        }
        internal void PromeniBoju(TextBox txt, Label lbl = null)
        {
            txt.BackColor = Color.White;
            if(lbl != null) 
                lbl.Text = "";
        }
        internal void isNull(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Text = "Obavezno polje!";
                txt.BackColor = Color.Salmon;
            }

        }
    }
}
