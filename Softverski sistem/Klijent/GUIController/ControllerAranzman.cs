using Common.Domenske_Klase;
using Common.Klase;
using Klijent.Forme_Admin.User_kontrole;
using Klijent.Forms.User_kontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GUIController
{
    public class ControllerAranzman
    {
        BindingList<Aranzman> listaAranzmana = new BindingList<Aranzman>();
        BindingList<Destinacija> listaDestinacija = new BindingList<Destinacija>();
        internal void InitDodaj(UCDodajAranzman ucDodajAranzman)
        {
            User u = Sesija.Instance.PrijavljeniUser;
            ucDodajAranzman.CbTipPrevoza.DataSource = Enum.GetValues(typeof(TipPrevoza));
            ucDodajAranzman.CbDestinacija.DataSource = Communication.Instance.VratiSveDestinacije(new BindingList<Destinacija>());
            ucDodajAranzman.TxtAdministrator.Text = $"{u.FirstName} {u.LastName}";
        }
        internal void DodajAranzman(UCDodajAranzman uCDodajAranzman)
        {
            bool postoji = false;
            Aranzman aranzman = new Aranzman();
            try
            {
                aranzman.Id = int.Parse(uCDodajAranzman.TxtId.Text);
                aranzman.Administrator = Sesija.Instance.PrijavljeniUser;
                aranzman.Destinacija = (Destinacija)uCDodajAranzman.CbDestinacija.SelectedItem;
                aranzman.Opis = uCDodajAranzman.RtxtOpis.Text;
                aranzman.Cena = double.Parse(uCDodajAranzman.TxtCena.Text);
                aranzman.Kapacitet = int.Parse(uCDodajAranzman.TxtKapacitet.Text);
                aranzman.TipPrevoza = (TipPrevoza)uCDodajAranzman.CbTipPrevoza.SelectedItem;
                aranzman.DatumOd = (DateTime)uCDodajAranzman.DateTimePicker1.Value;
                aranzman.DatumDo = (DateTime)uCDodajAranzman.DateTimePicker2.Value;
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format unetih vrednosti nije ispravan!");
            }
            finally
            {
                postoji = ValidacijaDodaj(aranzman, uCDodajAranzman);

                if (postoji == false)
                {
                    if (Communication.Instance.DodajAranzman(aranzman))
                    {
                        MessageBox.Show("Uspešno ste dodali novi aranžman!");
                        ResetDodaj(uCDodajAranzman);
                    }
                    else
                    {
                        MessageBox.Show("Greška! Proverite ispravnost unetih podataka!");
                    }
                }
            }
        }

        private bool ValidacijaDodaj(Aranzman aranzman, UCDodajAranzman ucDodajAranzman)
        {
            BindingList<Aranzman> aranzmani = new BindingList<Aranzman>();
            aranzmani = Communication.Instance.VratiSveAranzmane(aranzmani);
            bool postoji = false;

            foreach (Aranzman a in aranzmani)
            {
                if (ucDodajAranzman.TxtAdministrator.Text == "" || ucDodajAranzman.TxtCena.Text == "" || ucDodajAranzman.TxtId.Text == ""
                    || ucDodajAranzman.TxtKapacitet.Text == "" || ucDodajAranzman.CbDestinacija.SelectedItem == null || ucDodajAranzman.CbTipPrevoza.SelectedItem == null)
                {
                    postoji = true;
                    MessageBox.Show("Morate uneti sve vrednosti!");
                    return true;
                }

                if(aranzman.Id == a.Id)
                {
                    postoji = true;
                    MessageBox.Show("Aranžman već postoji!");
                }
            }

            if (ucDodajAranzman.DateTimePicker1.Value > ucDodajAranzman.DateTimePicker2.Value)
            {
                postoji = true;
                MessageBox.Show("Datum povratka ne može biti pre dana polaska!");
            }

            return postoji;
        }

        internal void VratiSveAranzmane(UCPregledajAranzmane ucPregledajAranzmane)
        {
            ucPregledajAranzmane.DgvListaAranzmana.DataSource = null;
            listaAranzmana = new BindingList<Aranzman>(Communication.Instance.VratiSveAranzmane(listaAranzmana));
            ucPregledajAranzmane.DgvListaAranzmana.DataSource = listaAranzmana;
            ucPregledajAranzmane.DgvListaAranzmana.Columns[2].Visible = false;
            DataGridViewComboBoxColumn kolonaDestinacija = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Destinacija",
                DataSource = Communication.Instance.VratiSveDestinacije(listaDestinacija),
                DataPropertyName = "Destinacija",
                ValueMember = "Self",
                DisplayMember = "Naziv",
            };
            ucPregledajAranzmane.DgvListaAranzmana.Columns.Insert(2, kolonaDestinacija);
            
            ucPregledajAranzmane.DgvListaAranzmana.Columns[7].Visible = false;
            ucPregledajAranzmane.DgvListaAranzmana.Columns["Id"].Visible = false;
            ucPregledajAranzmane.DgvListaAranzmana.Columns["Administrator"].Visible = false;
            ucPregledajAranzmane.DgvListaAranzmana.Columns["PrimaryKeyPropertyName"].Visible = false;
            ucPregledajAranzmane.DgvListaAranzmana.Columns["DeleteCondition"].Visible = false;

            DataGridViewComboBoxColumn kolonaTipPrevoza = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Tip prevoza",
                DataSource = Enum.GetValues(typeof(TipPrevoza)),
                DataPropertyName = "TipPrevoza",
            };
            ucPregledajAranzmane.DgvListaAranzmana.Columns.Insert(7, kolonaTipPrevoza);
        }
        internal void UcitajAranzman(UCPregledajAranzmane ucPregledajAranzmane)
        {
            if (ucPregledajAranzmane.DgvListaAranzmana.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ucPregledajAranzmane.DgvListaAranzmana.SelectedRows[0];
                Aranzman aranzman = (Aranzman)selectedRow.DataBoundItem;
                ucPregledajAranzmane.CbDestinacija.DataSource = Communication.Instance.VratiSveDestinacije(listaDestinacija);
                ucPregledajAranzmane.CbTipPrevoza.DataSource = Enum.GetValues(typeof(TipPrevoza));

                ucPregledajAranzmane.TxtId.Text = aranzman.Id.ToString();
                ucPregledajAranzmane.TxtAdministrator.Text = aranzman.Administrator.Username;
                ucPregledajAranzmane.TxtCena.Text = aranzman.Cena.ToString();
                ucPregledajAranzmane.TxtKapacitet.Text = aranzman.Kapacitet.ToString();
                ucPregledajAranzmane.RtxtOpis.Text = aranzman.Opis;
                ucPregledajAranzmane.TxtDatumOd.Text = aranzman.DatumOd.ToString("dd.MM.yyyy");
                ucPregledajAranzmane.TxtDatumDo.Text = aranzman.DatumDo.ToString("dd.MM.yyyy");

                Destinacija odabranaDestinacija = (Destinacija)selectedRow.Cells["Destinacija"].Value;
                ucPregledajAranzmane.CbDestinacija.SelectedItem = odabranaDestinacija;

                TipPrevoza odabraniTipPrevoza = (TipPrevoza)selectedRow.Cells["TipPrevoza"].Value;
                ucPregledajAranzmane.CbTipPrevoza.SelectedItem = odabraniTipPrevoza;

                ucPregledajAranzmane.BtnIzmeniAranzman.Enabled = true;
            }
            else
            {
                MessageBox.Show("Niste odabrali aranžman!");
            }

        }
        internal void IzmeniAranzman(UCPregledajAranzmane ucPregledajAranzmane)
        {
            ucPregledajAranzmane.BtnPrikaziDetalje.Enabled = true;
            ucPregledajAranzmane.BtnIzmeniAranzman.Enabled = false;
            ucPregledajAranzmane.BtnObrisiAranzman.Enabled = true;
            ucPregledajAranzmane.BtnSacuvajIzmene.Enabled = true;

            ucPregledajAranzmane.TxtAdministrator.ReadOnly = false;
            ucPregledajAranzmane.TxtCena.ReadOnly = false;
            ucPregledajAranzmane.TxtKapacitet.ReadOnly = false;
            ucPregledajAranzmane.RtxtOpis.ReadOnly = false;
            ucPregledajAranzmane.TxtDatumOd.ReadOnly = false;
            ucPregledajAranzmane.TxtDatumDo.ReadOnly = false;
            ucPregledajAranzmane.CbDestinacija.Enabled = true;
            ucPregledajAranzmane.CbTipPrevoza.Enabled = true;
        }
        internal void SacuvajIzmene(UCPregledajAranzmane ucPregledajAranzmane)
        {
            bool postoji = false;

            Aranzman aranzman = new Aranzman()
            {
                Id = int.Parse(ucPregledajAranzmane.TxtId.Text),
                Administrator = Sesija.Instance.PrijavljeniUser,
                Destinacija = (Destinacija)ucPregledajAranzmane.CbDestinacija.SelectedItem,
                Opis = ucPregledajAranzmane.RtxtOpis.Text,
                Cena = double.Parse(ucPregledajAranzmane.TxtCena.Text),
                Kapacitet = int.Parse(ucPregledajAranzmane.TxtKapacitet.Text),
                TipPrevoza = (TipPrevoza)ucPregledajAranzmane.CbTipPrevoza.SelectedItem,
                DatumOd = DateTime.Parse(ucPregledajAranzmane.TxtDatumOd.Text),
                DatumDo = DateTime.Parse(ucPregledajAranzmane.TxtDatumDo.Text)
            };

            postoji = Validacija(aranzman, ucPregledajAranzmane);

            if (postoji == false)
            {
                if (Communication.Instance.SacuvajIzmeneAranzmana(aranzman))
                {
                    MessageBox.Show("Uspešno ste sačuvali izmene!");
                    ResetPregledaj(ucPregledajAranzmane);
                    ucPregledajAranzmane.DgvListaAranzmana.Refresh();
                }
                else
                {
                    MessageBox.Show("Greška, nije moguće sačuvati izmene!");
                } 
            }
        }
        private void ResetPregledaj(UCPregledajAranzmane ucPregledajAranzmane)
        {
            ucPregledajAranzmane.TxtId.Text = "";
            ucPregledajAranzmane.CbDestinacija.SelectedItem = null;
            ucPregledajAranzmane.RtxtOpis.Text = "";
            ucPregledajAranzmane.TxtCena.Text = "";
            ucPregledajAranzmane.TxtKapacitet.Text = "";
            ucPregledajAranzmane.CbTipPrevoza.SelectedItem = null;
            ucPregledajAranzmane.TxtDatumOd.Text = "";
            ucPregledajAranzmane.TxtDatumDo.Text = "";

            ucPregledajAranzmane.BtnPrikaziDetalje.Enabled = true;
            ucPregledajAranzmane.BtnIzmeniAranzman.Enabled = false;
            ucPregledajAranzmane.BtnSacuvajIzmene.Enabled = false;
            ucPregledajAranzmane.BtnObrisiAranzman.Enabled = false;
        }
        private void ResetDodaj(UCDodajAranzman ucDodajAranzman)
        {
            ucDodajAranzman.TxtId.Text = "";
            ucDodajAranzman.CbDestinacija.SelectedItem = null;
            ucDodajAranzman.RtxtOpis.Text = "";
            ucDodajAranzman.TxtCena.Text = "";
            ucDodajAranzman.TxtKapacitet.Text = "";
            ucDodajAranzman.CbTipPrevoza.SelectedItem = null;

        }
        internal bool Validacija(Aranzman aranzman, UCPregledajAranzmane ucPregledajAranzmane)
        {
            BindingList<Aranzman> aranzmani = new BindingList<Aranzman>();
            aranzmani = Communication.Instance.VratiSveAranzmane(aranzmani);
            bool postoji = false;

            foreach(Aranzman a in aranzmani)
            {
                if(ucPregledajAranzmane.TxtAdministrator.Text == "" || ucPregledajAranzmane.TxtCena.Text == "" || ucPregledajAranzmane.TxtId.Text == ""
                    || ucPregledajAranzmane.TxtKapacitet.Text == "" || ucPregledajAranzmane.CbDestinacija.SelectedItem == null || ucPregledajAranzmane.CbTipPrevoza.SelectedItem == null)
                {
                    postoji = true;
                    MessageBox.Show("Morate uneti sve vrednosti!");
                    return true;
                }

            }

            if (aranzman.DatumOd > aranzman.DatumDo)
            {
                postoji = true;
                MessageBox.Show("Datum povratka ne može biti pre dana polaska!");
            }

            return postoji;
        }

        internal void ObrisiAranzman(UCPregledajAranzmane ucPregledajAranzmane)
        {
            Aranzman aranzman = new Aranzman()
            {
                Id = int.Parse(ucPregledajAranzmane.TxtId.Text),
                Administrator = Sesija.Instance.PrijavljeniUser,
                Destinacija = (Destinacija)ucPregledajAranzmane.CbDestinacija.SelectedItem,
                Opis = ucPregledajAranzmane.RtxtOpis.Text,
                Cena = double.Parse(ucPregledajAranzmane.TxtCena.Text),
                Kapacitet = int.Parse(ucPregledajAranzmane.TxtKapacitet.Text),
                TipPrevoza = (TipPrevoza)ucPregledajAranzmane.CbTipPrevoza.SelectedItem,
                DatumOd = DateTime.Parse(ucPregledajAranzmane.TxtDatumOd.Text),
                DatumDo = DateTime.Parse(ucPregledajAranzmane.TxtDatumDo.Text)
            };

            if (Communication.Instance.ObrisiAranzman(aranzman))
            {
                MessageBox.Show("Uspešno ste obrisali aranžman!");
                ucPregledajAranzmane.DgvListaAranzmana.Refresh();
            }
            else
            {
                MessageBox.Show("Greška, nije moguće obrisati aranžman!");
            }
        }
    }
}
