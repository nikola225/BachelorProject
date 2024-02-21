using Common.Domenske_Klase;
using Klijent.Forme_Admin;
using Klijent.Forme_Admin.User_kontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GUIController
{
    public class ControllerDestinacija
    {
        BindingList<Destinacija> listaDestinacija = new BindingList<Destinacija>();
        internal void Dodaj(FrmDodajDestinaciju frmDodajDestinaciju)
        {

            bool postoji = false;

            Destinacija d = new Destinacija()
            {
                Naziv = frmDodajDestinaciju.TxtNaziv.Text
            };

            postoji = Validacija(d);

            if (postoji == false)
            {
                if (Communication.Instance.DodajDestinaciju(d))
                {
                    MessageBox.Show("Uspešno ste dodali novu destinaciju!");
                    frmDodajDestinaciju.Close();
                }
                else
                {
                    MessageBox.Show("Greška! Proverite ispravnost unetih podataka!");
                    frmDodajDestinaciju.Close();
                }; 
            }
            else
            {
                MessageBox.Show("Destinacija sa navedenim nazivom već postoji!");
                //postoji = false;
                frmDodajDestinaciju.TxtNaziv.BackColor = Color.Salmon;
            }

        }

        internal bool Validacija(Destinacija d)
        {
            BindingList<Destinacija> destinacije = new BindingList<Destinacija>();
            destinacije = Communication.Instance.VratiSveDestinacije(destinacije);

            foreach (Destinacija dest in destinacije)
            {
                if (dest.Naziv == d.Naziv)
                {
                    return true;
                }
            }

            return false;
        }
        internal void InitUCDestinacije(UCPregledajDestinacije ucPregledajDestinacije)
        {
            ucPregledajDestinacije.DgvPrikaziDestinacije.DataSource = null;
            BindingList<Destinacija> ucitanaLista = new BindingList<Destinacija>(Communication.Instance.VratiSveDestinacije(listaDestinacija));
            ucPregledajDestinacije.DgvPrikaziDestinacije.DataSource = ucitanaLista;
            ucPregledajDestinacije.TxtPretrazi.Text = "";

            ucPregledajDestinacije.DgvPrikaziDestinacije.Columns["Self"].Visible = false;
            ucPregledajDestinacije.DgvPrikaziDestinacije.Columns["PrimaryKeyValue"].Visible = false;
        }
        internal void PokreniFormuDodaj(UCPregledajDestinacije uCPregledajDestinacije)
        {
            FrmDodajDestinaciju frmDodajDestinaciju = new FrmDodajDestinaciju();
            frmDodajDestinaciju.ShowDialog();
        }
        internal void PokreniFormuIzmeni(UCPregledajDestinacije ucPregledajDestinacije)
        {
            if (ucPregledajDestinacije.DgvPrikaziDestinacije.SelectedRows.Count > 0)
            {
                Destinacija destinacija = (Destinacija)ucPregledajDestinacije.DgvPrikaziDestinacije.SelectedRows[0].DataBoundItem;
                FrmIzmeniDestinaciju frmIzmeniDestinaciju = new FrmIzmeniDestinaciju(destinacija);
                frmIzmeniDestinaciju.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Niste odabrali destinaciju!");
            }

        }
        internal void SacuvajIzmeneDestinacija(FrmIzmeniDestinaciju frmIzmeniDestinaciju)
        {
            bool postoji = false;

            Destinacija destinacija = new Destinacija()
            {
                Id = int.Parse(frmIzmeniDestinaciju.TxtId.Text),
                Naziv = frmIzmeniDestinaciju.TxtNaziv.Text
            };

            postoji = Validacija(destinacija);

            if (postoji == false)
            {
                if (Communication.Instance.SacuvajIzmeneDestinacije(destinacija))
                {
                    MessageBox.Show("Uspešno ste sačuvali izmene!");
                    frmIzmeniDestinaciju.Close();
                }
                else
                {
                    MessageBox.Show("Greška! Nije moguće izmeniti destinaciju!");
                } 
            }
            else
            {
                MessageBox.Show("Destinacija sa navedenim nazivom već postoji!");
                frmIzmeniDestinaciju.TxtNaziv.BackColor = Color.Salmon;
            }
        }
        internal void UcitajDestinaciju(FrmIzmeniDestinaciju frmIzmeniDestinaciju, Destinacija destinacija)
        {
            frmIzmeniDestinaciju.TxtId.Text = destinacija.Id.ToString();
            frmIzmeniDestinaciju.TxtNaziv.Text = destinacija.Naziv;
        }
        internal void ObrisiDestinaciju(UCPregledajDestinacije ucPregledajDestinacije)
        {
            if (ucPregledajDestinacije.DgvPrikaziDestinacije.SelectedRows.Count > 0)
            {
                Destinacija destinacija = (Destinacija)ucPregledajDestinacije.DgvPrikaziDestinacije.SelectedRows[0].DataBoundItem;

                if (Communication.Instance.ObrisiDestinaciju(destinacija))
                {
                    MessageBox.Show("Uspešno ste obrisali destinaciju!");
                    ucPregledajDestinacije.DgvPrikaziDestinacije.Refresh();
                }
                else
                {
                    MessageBox.Show("Greška, nije moguće obrisati destinaciju!");
                } 
            }
            else
            {
                MessageBox.Show("Niste odabrali destinaciju!");
            }
        }
        internal void PretraziDestinacije(UCPregledajDestinacije ucPregledajDestinacije)
        {
            string kriterijum = ucPregledajDestinacije.TxtPretrazi.Text;

            BindingList<Destinacija> pronadjeneDestinacije = new BindingList<Destinacija>();
            pronadjeneDestinacije = Communication.Instance.PronadjiDestinacije(pronadjeneDestinacije, kriterijum);

            if (pronadjeneDestinacije.Count > 0)
            {
                ucPregledajDestinacije.DgvPrikaziDestinacije.DataSource = null;
                ucPregledajDestinacije.DgvPrikaziDestinacije.DataSource = new BindingList<Destinacija>(pronadjeneDestinacije);
                ucPregledajDestinacije.DgvPrikaziDestinacije.Columns["Self"].Visible = false;
                ucPregledajDestinacije.DgvPrikaziDestinacije.Columns["PrimaryKeyValue"].Visible = false;
            }
            else
            {
                ucPregledajDestinacije.TxtPretrazi.Text = "";
                MessageBox.Show("Nije pronađena nijedna destinacija!");
            }
        }
        internal void Init(FrmDodajDestinaciju frmDodajDestinaciju)
        {
            frmDodajDestinaciju.TxtId.Text = "****";
        }
        internal void PromeniBoju(TextBox txt)
        {
            txt.BackColor = Color.White;
        }
    }
}
