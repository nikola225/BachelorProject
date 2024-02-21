using Common.Domenske_Klase;
using Common.Klase;
using Klijent.Forme_Admin.User_kontrole;
using Klijent.Forme_Putnik.User_kontrole;
using Klijent.Forms.User_kontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GUIController
{
    public class ControllerRezervacije
    {
        BindingList<Putnik> putnici = new BindingList<Putnik>();
        BindingList<Aranzman> listaAranzmana = new BindingList<Aranzman>();
        BindingList<Destinacija> listaDestinacija = new BindingList<Destinacija>();
        BindingList<Rezervacija> listaRezervacija = new BindingList<Rezervacija>();
        BindingList<Rezervacija> rezervacijeZaDodavanje = new BindingList<Rezervacija>();
        int Id = 0;
        internal void InitRezervacije(UCDodajRezervaciju ucRezervacije)
        {
            User u = Sesija.Instance.PrijavljeniUser;
            ucRezervacije.DgvOdaberiPutnika.DataSource = new BindingList<Putnik>(Communication.Instance.VratiSvePutnike(putnici));
            ucRezervacije.DgvOdaberiPutnika.Columns["DeleteCondition"].Visible = false;

            ucRezervacije.DgvOdaberiAranzman.DataSource = null;
            listaAranzmana = new BindingList<Aranzman>(Communication.Instance.VratiSveAranzmane(listaAranzmana));
            ucRezervacije.DgvOdaberiAranzman.DataSource = listaAranzmana;
            ucRezervacije.DgvOdaberiAranzman.Columns["Destinacija"].Visible = false;
            ucRezervacije.DgvOdaberiAranzman.Columns["DeleteCondition"].Visible = false;
            ucRezervacije.DgvOdaberiAranzman.Columns["PrimaryKeyPropertyName"].Visible = false;
            ucRezervacije.DgvOdaberiAranzman.Columns["Administrator"].Visible = false;
            DataGridViewComboBoxColumn kolonaDestinacija = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Destinacija",
                DataSource = Communication.Instance.VratiSveDestinacije(listaDestinacija),
                DataPropertyName = "Destinacija",
                ValueMember = "Self",
                DisplayMember = "Naziv",
            };
            ucRezervacije.DgvOdaberiAranzman.Columns.Insert(1, kolonaDestinacija);

            ucRezervacije.DgvOdaberiAranzman.Columns["TipPrevoza"].Visible = false;
            DataGridViewComboBoxColumn kolonaTipPrevoza = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Tip prevoza",
                DataSource = Enum.GetValues(typeof(TipPrevoza)),
                DataPropertyName = "TipPrevoza",
            };
            ucRezervacije.DgvOdaberiAranzman.Columns.Insert(6, kolonaTipPrevoza);
        }
        internal void OdaberiPutnika(UCDodajRezervaciju ucDodajRezervaciju)
        {
            if (ucDodajRezervaciju.DgvOdaberiPutnika.SelectedRows.Count > 0)
            {
                Putnik putnik = (Putnik)ucDodajRezervaciju.DgvOdaberiPutnika.SelectedRows[0].DataBoundItem;
                ucDodajRezervaciju.TxtUsername.Text = putnik.Username;
                ucDodajRezervaciju.TxtIme.Text = putnik.FirstName;
                ucDodajRezervaciju.TxtPrezime.Text = putnik.LastName;
                ucDodajRezervaciju.TxtEmail.Text = putnik.Email;
                ucDodajRezervaciju.TxtJMBG.Text = putnik.JMBG;
                ucDodajRezervaciju.TxtBrojPasosa.Text = putnik.PassportNumber;
                ucDodajRezervaciju.TxtBrojTelefona.Text = putnik.PhoneNumber;
            }
            else
            {
                MessageBox.Show("Niste odabrali putnika!");
            }
        }
        internal void OdaberiAranzman(UCDodajRezervaciju ucDodajRezervaciju)
        {
            if (ucDodajRezervaciju.DgvOdaberiAranzman.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ucDodajRezervaciju.DgvOdaberiAranzman.SelectedRows[0];
                Aranzman aranzman = (Aranzman)selectedRow.DataBoundItem;
                
                ucDodajRezervaciju.CbDestinacija.DataSource = Communication.Instance.VratiSveDestinacije(listaDestinacija);
                ucDodajRezervaciju.CbTipPrevoza.DataSource = Enum.GetValues(typeof(TipPrevoza));

                ucDodajRezervaciju.TxtId.Text = aranzman.Id.ToString();
                ucDodajRezervaciju.TxtCena.Text = aranzman.Cena.ToString();
                //ucDodajRezervaciju.TxtKapacitet.Text = aranzman.Kapacitet.ToString();
                ucDodajRezervaciju.RtxtOpis.Text = aranzman.Opis;
                ucDodajRezervaciju.TxtDatumOd.Text = aranzman.DatumOd.ToString();
                ucDodajRezervaciju.TxtDatumDo.Text = aranzman.DatumDo.ToString();

                Destinacija odabranaDestinacija = (Destinacija)selectedRow.Cells["Destinacija"].Value;
                ucDodajRezervaciju.CbDestinacija.SelectedItem = odabranaDestinacija;

                TipPrevoza odabraniTipPrevoza = (TipPrevoza)selectedRow.Cells["TipPrevoza"].Value;
                ucDodajRezervaciju.CbTipPrevoza.SelectedItem = odabraniTipPrevoza;
                
            }
            else
            {
                MessageBox.Show("Niste odabrali aranžman!");
            }
        }
        internal void SacuvajRezervaciju(UCDodajRezervaciju ucDodajRezervaciju)
        {
            bool postoji = false;
            int broj;
            bool validno = (int.TryParse(ucDodajRezervaciju.TxtBrojRezervacije.Text, out broj));


            if (ucDodajRezervaciju.TxtUsername.Text != ""
                && ucDodajRezervaciju.TxtId.Text != ""
                && ucDodajRezervaciju.TxtBrojRezervacije.Text != ""
                && validno == true)
            {

                Putnik putnik = new Putnik()
                {
                    Username = ucDodajRezervaciju.TxtUsername.Text
                };

                Aranzman aranzman = new Aranzman()
                {
                    Id = int.Parse(ucDodajRezervaciju.TxtId.Text)
                };

                Rezervacija rezervacija = new Rezervacija()
                {
                    Putnik = putnik,
                    Aranzman = aranzman,
                    BrojRezervacije = int.Parse(ucDodajRezervaciju.TxtBrojRezervacije.Text)
                };

                postoji = ValidacijaDodaj(rezervacija, ucDodajRezervaciju);

                if (postoji == false)
                {
                    if (Communication.Instance.DodajRezervaciju(rezervacija))
                    {
                        MessageBox.Show("Uspešno ste dodali rezervaciju!\nNastavite sa dodavanjem ili zapamtite sve rezervacije");
                        ucDodajRezervaciju.BtnZapamtiSve.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Greška pri dodavanju rezervacije! Proverite ispravnost unetih podataka!");
                    }
                } 
            }
            else
            {
                MessageBox.Show("Morate odabrati i putnika i aranžman kako biste kreirali rezervaciju!");
            }

        }
        private bool ValidacijaDodaj(Rezervacija rezervacija, UCDodajRezervaciju ucDodajRezervaciju)
        {
            BindingList<Rezervacija> rezervacije = new BindingList<Rezervacija>();
            rezervacije = Communication.Instance.VratiSveRezervacije(rezervacije);

            foreach(Rezervacija r in rezervacije)
            {
                if(rezervacija.Putnik.Username == r.Putnik.Username && rezervacija.Aranzman.Id == r.Aranzman.Id)
                {
                    MessageBox.Show("Za odabranog putnika već je kreirana rezervacija za odabranu destinaciju!");
                    return true;
                }

                if(rezervacija.BrojRezervacije == r.BrojRezervacije)
                {
                    MessageBox.Show("Broj rezervacije već postoji!");
                    return true;
                }
            }

            if (ucDodajRezervaciju.TxtUsername.Text == "" || ucDodajRezervaciju.TxtId.Text == "" || ucDodajRezervaciju.TxtBrojRezervacije.Text == "")
            {
                MessageBox.Show("Popunite sva obavezna polja!");
                return true;
            }

            return false;
        }
        internal void UcitajRezervacije(UCPregledajRezervacije ucPregledajRezervacije)
        {
            listaRezervacija = Communication.Instance.VratiSveRezervacije(listaRezervacija);
            ucPregledajRezervacije.DgvPregledajRezervacije.DataSource = new BindingList<Rezervacija>(listaRezervacija);

            foreach (Rezervacija rezervacija in listaRezervacija)
            {
                rezervacija.Destinacija = Communication.Instance.GetDestinacija(rezervacija.Aranzman.Destinacija.Id).ToString();
                rezervacija.Aranzman.Destinacija.Naziv = rezervacija.Destinacija;
            }

            ucPregledajRezervacije.DgvPregledajRezervacije.Columns["TableName"].Visible = false;
            ucPregledajRezervacije.DgvPregledajRezervacije.Columns["InsertValues"].Visible = false;
            ucPregledajRezervacije.DgvPregledajRezervacije.Columns["UpdateSetStatement"].Visible = false;
            ucPregledajRezervacije.DgvPregledajRezervacije.Columns["PrimaryKeyPropertyName"].Visible = false;
            ucPregledajRezervacije.DgvPregledajRezervacije.Columns["PrimaryKeyValue"].Visible = false;
            ucPregledajRezervacije.DgvPregledajRezervacije.Columns["DeleteCondition"].Visible = false;
            ucPregledajRezervacije.DgvPregledajRezervacije.Columns["Aranzman"].Visible = false;

            
        }
        internal void OdaberiRezervaciju(UCPregledajRezervacije ucPregledajRezervacije)
        {
            BindingList<Destinacija> destinacije = new BindingList<Destinacija>();
            Rezervacija r = (Rezervacija)ucPregledajRezervacije.DgvPregledajRezervacije.SelectedRows[0].DataBoundItem;
            
            int IdAranzmana = r.Aranzman.Id;
            ucPregledajRezervacije.CbDestinacija.DataSource = Communication.Instance.VratiSveDestinacije(destinacije);
            ucPregledajRezervacije.CbTipPrevoza.DataSource = Enum.GetValues(typeof(TipPrevoza));

            ucPregledajRezervacije.TxtBrojRezervacije.Text = r.BrojRezervacije.ToString();
            
            ucPregledajRezervacije.TxtIme.Text = r.Putnik.FirstName;
            ucPregledajRezervacije.TxtPrezime.Text = r.Putnik.LastName;
            ucPregledajRezervacije.TxtJMBG.Text = r.Putnik.JMBG;
            ucPregledajRezervacije.TxtBrojPasosa.Text = r.Putnik.PassportNumber;
            ucPregledajRezervacije.TxtEmail.Text = r.Putnik.Email;
            ucPregledajRezervacije.TxtBrojTelefona.Text = r.Putnik.PhoneNumber;
            ucPregledajRezervacije.TxtKorisnickoIme.Text = r.Putnik.Username;

            Aranzman a = GetAranzman(IdAranzmana);
            r.Aranzman = a;

            ucPregledajRezervacije.TxtCena.Text = a.Cena.ToString();
            ucPregledajRezervacije.RtxtOpis.Text = a.Opis;
            ucPregledajRezervacije.TxtDatumOd.Text = a.DatumOd.ToString();
            ucPregledajRezervacije.TxtDatumDo.Text = a.DatumDo.ToString();
            ucPregledajRezervacije.CbDestinacija.SelectedItem = a.Destinacija;
            ucPregledajRezervacije.CbTipPrevoza.SelectedItem = a.TipPrevoza;
            ucPregledajRezervacije.TxtIdAranzmana.Text = a.Id.ToString();

        }
        internal Aranzman GetAranzman(int IdAranzmana)
        {
            Aranzman a = Communication.Instance.GetAranzman(IdAranzmana);
            return a;
        }
        internal void PromeniPutnika(UCPregledajRezervacije ucPregledajRezervacije)
        {
            ucPregledajRezervacije.TxtKorisnickoIme.ReadOnly = false;
            ucPregledajRezervacije.TxtKorisnickoIme.PasswordChar = '\0';
            ucPregledajRezervacije.BtnSacuvajPromene.Enabled = true;
        }
        internal void PromeniAranzman(UCPregledajRezervacije ucPregledajRezervacije)
        {
            ucPregledajRezervacije.TxtIdAranzmana.ReadOnly = false;
            ucPregledajRezervacije.TxtIdAranzmana.PasswordChar = '\0';
            ucPregledajRezervacije.BtnSacuvajPromene.Enabled = true;
        }
        internal void Odustani(UCPregledajRezervacije ucPregledajRezervacije)
        {
            ucPregledajRezervacije.TxtKorisnickoIme.ReadOnly = true;
            ucPregledajRezervacije.TxtKorisnickoIme.PasswordChar = '*';
            ucPregledajRezervacije.TxtIdAranzmana.ReadOnly = true;
            ucPregledajRezervacije.TxtIdAranzmana.PasswordChar = '*';
            ucPregledajRezervacije.BtnSacuvajPromene.Enabled = false;
        }
        internal void Reset(UCPregledajRezervacije ucPregledajRezervacije)
        {
            ucPregledajRezervacije.TxtKorisnickoIme.ReadOnly = true;
            ucPregledajRezervacije.TxtKorisnickoIme.PasswordChar = '*';
            ucPregledajRezervacije.TxtIdAranzmana.ReadOnly = true;
            ucPregledajRezervacije.TxtIdAranzmana.PasswordChar = '*';
            ucPregledajRezervacije.BtnSacuvajPromene.Enabled = false;

            ucPregledajRezervacije.TxtIdAranzmana.Text = null;
            ucPregledajRezervacije.CbDestinacija.SelectedItem = null;
            ucPregledajRezervacije.CbTipPrevoza.SelectedItem = null;
            ucPregledajRezervacije.TxtCena.Text = null;
            ucPregledajRezervacije.TxtDatumDo.Text = null;
            ucPregledajRezervacije.TxtDatumOd.Text = null;
            ucPregledajRezervacije.RtxtOpis.Text = null;

            ucPregledajRezervacije.TxtKorisnickoIme.Text = null;
            ucPregledajRezervacije.TxtBrojPasosa.Text = null;
            ucPregledajRezervacije.TxtBrojRezervacije.Text = null;
            ucPregledajRezervacije.TxtBrojTelefona.Text = null;
            ucPregledajRezervacije.TxtIme.Text = null;
            ucPregledajRezervacije.TxtPrezime.Text = null;
            ucPregledajRezervacije.TxtJMBG.Text = null;

            ucPregledajRezervacije.TxtPretrazi.Text = null;
            ucPregledajRezervacije.TxtPretrazi.Text = null;
            ucPregledajRezervacije.TxtEmail.Text = null;

        }
        internal void SacuvajPromene(UCPregledajRezervacije ucPregledajRezervacije)
        {
            Putnik putnik = new Putnik()
            {
                Username = ucPregledajRezervacije.TxtKorisnickoIme.Text
            };
            Aranzman aranzman = new Aranzman()
            {
                Id = int.Parse(ucPregledajRezervacije.TxtIdAranzmana.Text)
            };
            Rezervacija rezervacija = new Rezervacija()
            {
                BrojRezervacije = int.Parse(ucPregledajRezervacije.TxtBrojRezervacije.Text),
                Putnik = putnik,
                Aranzman = aranzman,
            };
            if (Communication.Instance.IzmeniRezervaciju(rezervacija))
            {
                MessageBox.Show("Uspešno ste sačuvali izmene!");
            }
            else
            {
                MessageBox.Show("Greška! Proverite ispravnost unetih podataka!");
            }
        }
        internal void ObrisiRezervaciju(UCPregledajRezervacije ucPregledajRezervacije)
        {
            Putnik putnik = new Putnik()
            {
                Username = ucPregledajRezervacije.TxtKorisnickoIme.Text
            };
            Aranzman aranzman = new Aranzman()
            {
                Id = int.Parse(ucPregledajRezervacije.TxtIdAranzmana.Text)
            };
            Rezervacija rezervacija = new Rezervacija()
            {
                BrojRezervacije = int.Parse(ucPregledajRezervacije.TxtBrojRezervacije.Text),
                Putnik = putnik,
                Aranzman = aranzman,
            };
            if (Communication.Instance.ObrisiRezervaciju(rezervacija))
            {
                MessageBox.Show("Uspešno ste obrisali rezervaciju!");
            }
            else
            {
                MessageBox.Show("Greška! Nije moguće obrisati rezervaciju!");
            }
        }
        internal void Pretrazi(UCPregledajRezervacije ucPregledajRezervacije)
        {
            string kriterijum = ucPregledajRezervacije.TxtPretrazi.Text;
            BindingList<Rezervacija> pronadjeneRezervacije = new BindingList<Rezervacija>();

            if (ucPregledajRezervacije.TxtPretrazi.Text == "")
            {
                MessageBox.Show("Niste uneli kriterijuim za pretragu!");
            }
            else
            {
                pronadjeneRezervacije = Communication.Instance.PronadjiRezervacije(pronadjeneRezervacije, kriterijum);

                foreach (Rezervacija rezervacija in pronadjeneRezervacije)
                {
                    rezervacija.Destinacija = Communication.Instance.GetDestinacija(rezervacija.Aranzman.Destinacija.Id).ToString();
                    rezervacija.Aranzman.Destinacija.Naziv = rezervacija.Destinacija;
                }

                if (pronadjeneRezervacije.Count > 0)
                {
                    ucPregledajRezervacije.DgvPregledajRezervacije.DataSource = new BindingList<Rezervacija>(pronadjeneRezervacije);
                    ucPregledajRezervacije.DgvPregledajRezervacije.Columns["TableName"].Visible = false;
                    ucPregledajRezervacije.DgvPregledajRezervacije.Columns["InsertValues"].Visible = false;
                    ucPregledajRezervacije.DgvPregledajRezervacije.Columns["UpdateSetStatement"].Visible = false;
                    ucPregledajRezervacije.DgvPregledajRezervacije.Columns["PrimaryKeyPropertyName"].Visible = false;
                    ucPregledajRezervacije.DgvPregledajRezervacije.Columns["PrimaryKeyValue"].Visible = false;
                    ucPregledajRezervacije.DgvPregledajRezervacije.Columns["DeleteCondition"].Visible = false;
                    ucPregledajRezervacije.DgvPregledajRezervacije.Columns["Aranzman"].Visible = false;
                    ucPregledajRezervacije.DgvPregledajRezervacije.Refresh();
                }
                else
                {
                    ucPregledajRezervacije.TxtPretrazi.Text = "";
                    MessageBox.Show("Nije pronađena nijedna rezervacija!");
                }
            }
        }
        internal void ZapamtiRezervacije(UCDodajRezervaciju ucDodajRezervaciju)
        {
            if (Communication.Instance.ZapamtiRezervacije())
            {
                MessageBox.Show("Uspešno ste sačuvali sve rezervacije!");

                ucDodajRezervaciju.CbDestinacija.SelectedItem = null;
                ucDodajRezervaciju.CbTipPrevoza.SelectedItem = null;
                ucDodajRezervaciju.TxtCena.Text = null;
                ucDodajRezervaciju.TxtDatumDo.Text = null;
                ucDodajRezervaciju.TxtDatumOd.Text = null;
                ucDodajRezervaciju.RtxtOpis.Text = null;

                ucDodajRezervaciju.TxtBrojPasosa.Text = null;
                ucDodajRezervaciju.TxtBrojRezervacije.Text = null;
                ucDodajRezervaciju.TxtBrojTelefona.Text = null;
                ucDodajRezervaciju.TxtIme.Text = null;
                ucDodajRezervaciju.TxtPrezime.Text = null;
                ucDodajRezervaciju.TxtJMBG.Text = null;
                ucDodajRezervaciju.TxtEmail.Text = null;

                ucDodajRezervaciju.BtnZapamtiSve.Enabled = false;
            }
            else
            {
                MessageBox.Show("Greška pri čuvanju rezervacija!");
                
                ucDodajRezervaciju.CbDestinacija.SelectedItem = null;
                ucDodajRezervaciju.CbTipPrevoza.SelectedItem = null;
                ucDodajRezervaciju.TxtCena.Text = null;
                ucDodajRezervaciju.TxtDatumDo.Text = null;
                ucDodajRezervaciju.TxtDatumOd.Text = null;
                ucDodajRezervaciju.RtxtOpis.Text = null;

                ucDodajRezervaciju.TxtBrojPasosa.Text = null;
                ucDodajRezervaciju.TxtBrojRezervacije.Text = null;
                ucDodajRezervaciju.TxtBrojTelefona.Text = null;
                ucDodajRezervaciju.TxtIme.Text = null;
                ucDodajRezervaciju.TxtPrezime.Text = null;
                ucDodajRezervaciju.TxtJMBG.Text = null;
                ucDodajRezervaciju.TxtEmail.Text = null;

                ucDodajRezervaciju.BtnZapamtiSve.Enabled = false;
            }
        }
    }
}
