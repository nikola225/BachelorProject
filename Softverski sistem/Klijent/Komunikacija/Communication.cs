using Common;
using Common.Domenske_Klase;
using Common.Klase;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Klijent.GUIController
{
    public class Communication
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();
   
        private static Communication instance;
        private Communication()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }    
        public void Connect()
        {
            socket.Connect("127.0.0.1", 9999);
            stream = new NetworkStream(socket);
        }      
        public User LoginAdmin(User u)
        {
            Request request = new Request()
            {
                Argument = u,
                Operation = Operation.LoginAdmin
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (User)response.Result;

        }
        public Putnik LoginPutnik(Putnik p)
        {
            Request request = new Request()
            {
                Argument = p,
                Operation = Operation.LoginPutnik
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (Putnik)response.Result;
        }  
        public bool RegistrujPutnika(Putnik p)
        {
            Request request = new Request()
            {
                Argument = p,
                Operation = Operation.RegistracijaPutnika
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        public bool RegistrujAdministratora(User u)
        {
            Request request = new Request()
            {
                Argument = u,
                Operation = Operation.RegistracijaAdministratora
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        } 
        internal bool DodajDestinaciju(Destinacija d)
        {
            Request request = new Request()
            {
                Argument = d,
                Operation = Operation.DodajDestinaciju
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal BindingList<Destinacija> VratiSveDestinacije(BindingList<Destinacija> listaDestinacija)
        {
            Request request = new Request()
            {
                Argument = listaDestinacija,
                Operation = Operation.VratiSveDestinacije
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (BindingList<Destinacija>)response.Result;
        }
        internal bool DodajAranzman(Aranzman a)
        {
            Request request = new Request()
            {
                Argument = a,
                Operation = Operation.DodajAranzman
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal BindingList<Aranzman> VratiSveAranzmane(BindingList<Aranzman> listaAranzmana)
        {
            Request request = new Request()
            {
                Argument = listaAranzmana,
                Operation = Operation.VratiSveAranzmane
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (BindingList<Aranzman>)response.Result;
        }
        internal BindingList<Putnik> VratiSvePutnike(BindingList<Putnik> listaPutnika)
        {
            Request request = new Request()
            {
                Argument = listaPutnika,
                Operation = Operation.VratiSvePutnike
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (BindingList<Putnik>)response.Result;
        }
        internal bool SacuvajIzmenePutnika(Putnik p)
        {
            Request request = new Request()
            {
                Argument = p,
                Operation = Operation.SacuvajIzmenePutnika
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal bool ObrisiPutnika(Putnik p)
        {
            Request request = new Request()
            {
                Argument = p,
                Operation = Operation.ObrisiPutnika
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal BindingList<Putnik> PronadjiPutnike(BindingList<Putnik> pronadjeniPutnici, string kriterijum)
        {
            Request request = new Request()
            {
                Argument = kriterijum,
                Operation = Operation.PronadjiPutnike
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (BindingList<Putnik>)response.Result;
        }
        internal bool SacuvajIzmeneDestinacije(Destinacija d)
        {
            Request request = new Request()
            {
                Argument = d,
                Operation = Operation.SacuvajIzmeneDestinacije
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal bool ObrisiDestinaciju(Destinacija d)
        {
            Request request = new Request()
            {
                Argument = d,
                Operation = Operation.ObrisiDestinaciju
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal bool SacuvajIzmeneAdmina(User a)
        {
            Request request = new Request()
            {
                Argument = a,
                Operation = Operation.SacuvajIzmeneAdmina
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal BindingList<Destinacija> PronadjiDestinacije(BindingList<Destinacija> pronadjeneDestinacije, string kriterijum)
        {
            Request request = new Request()
            {
                Argument = kriterijum,
                Operation = Operation.PronadjiDestinacije
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (BindingList<Destinacija>)response.Result;
        }
        internal bool SacuvajIzmeneAranzmana(Aranzman a)
        {
            Request request = new Request()
            {
                Argument = a,
                Operation = Operation.SacuvajIzmeneAranzmana
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal bool ObrisiAranzman(Aranzman a)
        {
            Request request = new Request()
            {
                Argument = a,
                Operation = Operation.ObrisiAranzman
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal bool DodajRezervaciju(Rezervacija r)
        {
            Request request = new Request()
            {
                Argument = r,
                Operation = Operation.DodajRezervaciju
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        public string GenerisiPassword(int length)
        {
            Request request = new Request()
            {
                Argument = length,
                Operation = Operation.GenerisiPassword
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (string)response.Result;
        }
        public bool SendEmail(string toEmail, string newPassword)
        {
            Request request = new Request()
            {
                Argument = toEmail,
                Argument2 = newPassword,
                Operation = Operation.SendEmail
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal BindingList<Rezervacija> VratiSveRezervacije(BindingList<Rezervacija> listaRezervacija)
        {
            Request request = new Request()
            {
                Argument = listaRezervacija,
                Operation = Operation.VratiSveRezervacije
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (BindingList<Rezervacija>)response.Result;
        }
        internal Aranzman GetAranzman(int idAranzmana)
        {
            Request request = new Request()
            {
                Argument = idAranzmana,
                Operation = Operation.UcitajAranzman
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (Aranzman)response.Result;
        }
        internal string GetDestinacija(int idDestinacija)
        {
            Request request = new Request()
            {
                Argument = idDestinacija,
                Operation = Operation.UcitajDestinaciju
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (string)response.Result;
        }
        internal bool IzmeniRezervaciju(Rezervacija rezervacija)
        {
            Request request = new Request()
            {
                Argument = rezervacija,
                Operation = Operation.IzmeniRezervaciju
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal bool ObrisiRezervaciju(Rezervacija rezervacija)
        {
            Request request = new Request()
            {
                Argument = rezervacija,
                Operation = Operation.ObrisiRezervaciju
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal BindingList<Rezervacija> PronadjiRezervacije(BindingList<Rezervacija> pronadjeneRezervacije, string kriterijum)
        {
            Request request = new Request()
            {
                Argument = kriterijum,
                Operation = Operation.PronadjiRezervacije
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (BindingList<Rezervacija>)response.Result;
        }
        internal bool ZapamtiRezervacije()
        {
            Request request = new Request()
            {
                Operation = Operation.ZapamtiRezervacije
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (bool)response.Result;
        }
        internal ExcelPackage Izvezi(DataGridView dgv)
        {
            
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var paket = new ExcelPackage(new FileInfo("Putnici.xlsx"));

            ExcelWorksheet ws = paket.Workbook.Worksheets.Add("Putnici");
            int pocetniRed = 1;

            for (int kolona = 0; kolona < dgv.Columns.Count; kolona++)
            {
                if (dgv.Columns[kolona].Visible)
                {
                    ws.Cells[pocetniRed, kolona + 1].Value = dgv.Columns[kolona].HeaderText;
                }
            }

            pocetniRed++;

            for (int red = 0; red < dgv.Rows.Count; red++)
            {
                for (int kolona = 0; kolona < dgv.Columns.Count; kolona++)
                {
                    if (dgv.Columns[kolona].Visible)
                    {
                        ws.Cells[pocetniRed + red, kolona + 1].Value = dgv.Rows[red].Cells[kolona].Value;
                    }
                }
            }

            return paket;
        }
        internal bool SacuvajExcel(ExcelPackage paket)
        {
            SaveFileDialog cuvaj = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FileName = "Putnici.xlsx"
            };

            if (cuvaj.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(cuvaj.FileName, paket.GetAsByteArray());
                return true;
            }

            return false;
        }

        internal void ZatvoriAplikaciju()
        {
            Request request = new Request()
            {
                Operation = Operation.ZatvoriAplikaciju
            };

            formatter.Serialize(stream, request);
        }

        internal BindingList<User> VratiSveAdministratore(BindingList<User> listaAdministratora)
        {
            Request request = new Request()
            {
                Argument = listaAdministratora,
                Operation = Operation.VratiSveAdmine
            };

            formatter.Serialize(stream, request);

            Response response = (Response)formatter.Deserialize(stream);
            return (BindingList<User>)response.Result;
        }
    }
}