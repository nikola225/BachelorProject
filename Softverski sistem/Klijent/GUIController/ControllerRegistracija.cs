using Common.Domenske_Klase;
using Common.Klase;
using Klijent.Forme_Admin.User_kontrole;
using Klijent.Forme_Putnik;
using Klijent.GUIController;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Klijent.Forms
{
    internal class ControllerRegistracija
    {
        internal void PromeniBoju(TextBox txt, Label lbl = null)
        {
            txt.BackColor = Color.White;
            if (lbl != null)
                lbl.Text = "";
        }
        public void InitData(FrmRegistracijaAdmin frmRegistracija)
        {         

        }
        public void RegistrujAdministratora(FrmRegistracijaAdmin frmRegistracijaAdministratora)
        {
            bool postoji = false;

            User u = new User()
            {
                FirstName = frmRegistracijaAdministratora.TxtIme.Text,
                LastName = frmRegistracijaAdministratora.TxtPrezime.Text,
                Email = frmRegistracijaAdministratora.TxtEmail.Text,
                Username = frmRegistracijaAdministratora.TxtKorisnickoIme.Text,
                Password = frmRegistracijaAdministratora.TxtLozinka1.Text
            };

            postoji = Validacija(u, frmRegistracijaAdministratora.TxtIme, frmRegistracijaAdministratora.TxtPrezime, frmRegistracijaAdministratora.TxtKorisnickoIme,
                frmRegistracijaAdministratora.TxtLozinka1, frmRegistracijaAdministratora.TxtLozinka2, frmRegistracijaAdministratora.TxtEmail, frmRegistracijaAdministratora.LblUpozorenje,
                frmRegistracijaAdministratora.LblUpozorenjeEmail);

            if (postoji == false)
            {
                if (Communication.Instance.RegistrujAdministratora(u))
                {
                    MessageBox.Show("Uspešno ste kreirali nalog!");
                    frmRegistracijaAdministratora.Close();
                }
                else
                {
                    MessageBox.Show("Greška pri registraciji!");
                } 
            }
        }
        internal bool Validacija(User u, TextBox txtIme, TextBox txtPrezime, TextBox txtUsername, TextBox txtPassword1, TextBox txtPassword2, TextBox txtEmail, Label lblError1 = null, Label lblError2 = null)
        {
            bool postoji = false;
            BindingList<User> users = new BindingList<User>();
            users = Communication.Instance.VratiSveAdministratore(users);
            if(txtIme.Text == "")
            {
                txtIme.BackColor = Color.Salmon;
                postoji = true;
            }
            if (txtPrezime.Text == "")
            {
                txtPrezime.BackColor = Color.Salmon;
                postoji = true;
            }
            if (txtUsername.Text == "")
            {
                txtUsername.BackColor = Color.Salmon;
                postoji = true;
            }
            if (txtPassword1.Text == "")
            {
                txtPassword1.BackColor = Color.Salmon;
                postoji = true;
            }
            if (txtPassword2.Text == "")
            {
                txtPassword2.BackColor = Color.Salmon;
                postoji = true;
            }
            if (txtEmail.Text == "")
            {
                txtEmail.BackColor = Color.Salmon;
                postoji = true;
            }

            foreach(User user in users)
            {
                if (user.Username == u.Username)
                {
                    lblError1.Text = "Username već postoji!";
                    postoji = true;
                }

                if(user.Email  == u.Email)
                {
                    lblError2.Text = "Email već postoji!";
                    postoji = true;
                }
            }

            if(txtPassword1.Text != txtPassword2.Text)
            {
                MessageBox.Show("Lozinke moraju da se poklapaju!");
                txtPassword2.BackColor = Color.Salmon;
                postoji = true;
            }

            return postoji;
        }
        public void RegistrujPutnika(FrmRegistracijaPutnika frmRegistracijaPutnika)
        {
            Putnik p = new Putnik()
            {
                FirstName = frmRegistracijaPutnika.TxtIme.Text,
                LastName = frmRegistracijaPutnika.TxtPrezime.Text,
                JMBG = frmRegistracijaPutnika.TxtJMBG.Text,
                PassportNumber = frmRegistracijaPutnika.TxtBrojPasosa.Text,
                PhoneNumber = frmRegistracijaPutnika.TxtBrojTelefona.Text,
                Email = frmRegistracijaPutnika.TxtEmail.Text,
                Username = frmRegistracijaPutnika.TxtKorisnickoIme.Text,
                Password = frmRegistracijaPutnika.TxtLozinka1.Text
            };

            bool isSuccessful = Communication.Instance.RegistrujPutnika(p);
            if (isSuccessful)
            {
                MessageBox.Show("Uspešno ste se registrovali!");
            }
            else
            {
                MessageBox.Show("Greška pri registraciji!");
            }
        }
        internal void ZatvoriFormu(FrmRegistracijaAdmin frmRegistracijaAdmin)
        {
            frmRegistracijaAdmin.Close();
        }
        internal void PasswordCheck(FrmRegistracijaAdmin frmRegistracijaAdmin)
        {
            if (frmRegistracijaAdmin.ChbPrikaziLozinku.Checked)
            {
                frmRegistracijaAdmin.TxtLozinka1.PasswordChar = '\0';
                frmRegistracijaAdmin.TxtLozinka2.PasswordChar = '\0';
            }
            else
            {
                frmRegistracijaAdmin.TxtLozinka1.PasswordChar = '*';
                frmRegistracijaAdmin.TxtLozinka2.PasswordChar = '*';
            }
        }
    }
}