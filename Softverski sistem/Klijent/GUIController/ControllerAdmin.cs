using Common.Domenske_Klase;
using Common.Klase;
using Klijent.Forme_Admin.User_kontrole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent.GUIController
{
    public class ControllerAdmin
    {
        ControllerGlavna controller = new ControllerGlavna();
        internal void AdminProfil(UCProfil uCProfil)
        {
            User u = new User();
            u = Sesija.Instance.PrijavljeniUser;

            uCProfil.TxtIme.Text = u.FirstName;
            uCProfil.TxtPrezime.Text = u.LastName;
            uCProfil.TxtEmail.Text = u.Email;
            uCProfil.TxtKorisnickoIme.Text = u.Username;
            uCProfil.TxtLozinka.Text = u.Password;
            uCProfil.BtnSacuvajIzmene.Enabled = false;
        }
        internal void AdminProfilCheckPass(UCProfil uCProfil)
        {
            if (uCProfil.ChbPrikaziLozinku.Checked)
            {
                uCProfil.TxtLozinka.PasswordChar = '\0';
            }
            else
            {
                uCProfil.TxtLozinka.PasswordChar = '*';
            }
        }
        internal void IzmeniProfil(UCProfil ucProfil)
        {
            ucProfil.TxtIme.ReadOnly = false;
            ucProfil.TxtPrezime.ReadOnly = false;
            ucProfil.TxtEmail.ReadOnly = false;
            ucProfil.TxtLozinka.ReadOnly = false;
            
            ucProfil.BtnSacuvajIzmene.Enabled = true;
            ucProfil.BtnOtkazi.Enabled = true;
            ucProfil.BtnIzmeni.Enabled = false;
        }
        internal void SacuvajIzmene(UCProfil ucProfil)
        {
            bool postoji = false;

            User admin = new User()
            {
                FirstName = ucProfil.TxtIme.Text,
                LastName = ucProfil.TxtPrezime.Text,
                Email = ucProfil.TxtEmail.Text,
                Username = ucProfil.TxtKorisnickoIme.Text,
                Password = ucProfil.TxtLozinka.Text
            };

            postoji = Validacija(admin, ucProfil.TxtIme, ucProfil.TxtPrezime, ucProfil.TxtKorisnickoIme, ucProfil.TxtLozinka, ucProfil.TxtEmail);

            if (postoji == false)
            {
                if (Communication.Instance.SacuvajIzmeneAdmina(admin))
                {
                    MessageBox.Show("Uspešno ste sačuvali izmene!");
                    Sesija.Instance.PrijavljeniUser = admin;
                    ucProfil.BtnIzmeni.Enabled = true;
                    ucProfil.BtnSacuvajIzmene.Enabled = false;
                    Reset(ucProfil);
                    AdminProfil(ucProfil);
                }
                else
                {
                    MessageBox.Show("Greška, nije moguće sačuvati izmene!");
                }

                ucProfil.TxtIme.ReadOnly = true;
                ucProfil.TxtPrezime.ReadOnly = true;
                ucProfil.TxtEmail.ReadOnly = true;
                ucProfil.BtnIzmeni.Enabled = true;
                ucProfil.BtnSacuvajIzmene.Enabled = false;
                ucProfil.BtnOtkazi.Enabled = false;
            }
        }
        internal bool Validacija(User u, TextBox txtIme, TextBox txtPrezime, TextBox txtUsername, TextBox txtPassword1, TextBox txtEmail, Label lblError1 = null, Label lblError2 = null)
        {
            bool postoji = false;
            BindingList<User> users = new BindingList<User>();
            users = Communication.Instance.VratiSveAdministratore(users);
            if (txtIme.Text == "")
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
            if (txtEmail.Text == "")
            {
                txtEmail.BackColor = Color.Salmon;
                postoji = true;
            }

            foreach (User user in users)
            {
                if (user.Username != u.Username && user.Email == u.Email)
                {
                    txtEmail.Text = "Email već postoji!";
                    txtEmail.BackColor = Color.Salmon;
                    postoji = true;
                }
            }

            return postoji;
        }
        internal void Reset(UCProfil ucProfil)
        {
            ucProfil.TxtIme.ReadOnly = true;
            ucProfil.TxtPrezime.ReadOnly = true;
            ucProfil.TxtEmail.ReadOnly = true;
            ucProfil.TxtLozinka.ReadOnly = true;

            ucProfil.BtnSacuvajIzmene.Enabled = false;
            ucProfil.BtnIzmeni.Enabled = true;
        }
        internal void PromeniBoju(TextBox txt, Label lbl = null)
        {
            txt.BackColor = Color.White;
            if (lbl != null)
                lbl.Text = "";
        }
    }
}
