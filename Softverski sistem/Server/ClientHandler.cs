using Common;
using Common.Domenske_Klase;
using Common.Klase;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Server
{
    internal class ClientHandler
    {
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();
        private Server server;
        private List<ClientHandler> clients;
        bool radi = true;

        public ClientHandler(Socket socket, Server server, List<ClientHandler> clients)
        {
            this.socket = socket;
            this.stream = new NetworkStream(socket);
            this.server = server;
            this.clients = clients;
        }
        internal void StartHandler()
        {
            try
            {
                while (radi)
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    ProcessRequest(request);
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(ex);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void ProcessRequest(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {
                    case Operation.LoginAdmin:
                        {
                            response.Result = (User)Controller.Instance.LoginAdmin((User)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.LoginPutnik:
                        {
                            response.Result = (Putnik)Controller.Instance.LoginPutnik((Putnik)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.RegistracijaPutnika:
                        {
                            response.Result = (bool)Controller.Instance.RegistracijaPutnika((Putnik)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.RegistracijaAdministratora:
                        {
                            response.Result = (bool)Controller.Instance.RegistracijaAdministratora((User)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.DodajDestinaciju:
                        {
                            response.Result = (bool)Controller.Instance.DodajDestinaciju((Destinacija)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.VratiSveDestinacije:
                        {
                            response.Result = (BindingList<Destinacija>)Controller.Instance.VratiSveDestinacije((BindingList<Destinacija>)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.DodajAranzman:
                        {
                            response.Result = (bool)Controller.Instance.DodajAranzman((Aranzman)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.VratiSveAranzmane:
                        {
                            response.Result = (BindingList<Aranzman>)Controller.Instance.VratiSveAranzmane((BindingList<Aranzman>)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.VratiSvePutnike:
                        {
                            response.Result = (BindingList<Putnik>)Controller.Instance.VratiSvePutnike((BindingList<Putnik>)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.SacuvajIzmenePutnika:
                        {
                            response.Result = (bool)Controller.Instance.SacuvajIzmenePutnika((Putnik)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.ObrisiPutnika:
                        {
                            response.Result = (bool)Controller.Instance.ObrisiPutnika((Putnik)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                     case Operation.PronadjiPutnike:
                        {
                            response.Result = (BindingList<Putnik>)Controller.Instance.PronadjiPutnike((string)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.SacuvajIzmeneDestinacije:
                        {
                            response.Result = (bool)Controller.Instance.SacuvajIzmeneDestinacije((Destinacija)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                     case Operation.ObrisiDestinaciju:
                        {
                            response.Result = (bool)Controller.Instance.ObrisiDestinaciju((Destinacija)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.SacuvajIzmeneAdmina:
                        {
                            response.Result = (bool)Controller.Instance.SacuvajIzmeneAdmina((User)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.PronadjiDestinacije:
                        {
                            response.Result = (BindingList<Destinacija>)Controller.Instance.PronadjiDestinacije((string)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.SacuvajIzmeneAranzmana:
                        {
                            response.Result = (bool)Controller.Instance.SacuvajIzmeneAranzmana((Aranzman)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.ObrisiAranzman:
                        {
                            response.Result = (bool)Controller.Instance.ObrisiAranzman((Aranzman)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.DodajRezervaciju:
                        {
                            response.Result = (bool)Controller.Instance.DodajRezervaciju((Rezervacija)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.ZapamtiRezervacije:
                        {
                            response.Result = (bool)Controller.Instance.ZapamtiRezervacije();
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.GenerisiPassword:
                        {
                            response.Result = (string)Controller.Instance.GenerisiPassword((int)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.SendEmail:
                        {
                            response.Result = (bool)Controller.Instance.SendEmail((string)request.Argument, (string)request.Argument2);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.VratiSveRezervacije:
                        {
                            response.Result = (BindingList<Rezervacija>)Controller.Instance.VratiSveRezervacije((BindingList<Rezervacija>)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                      case Operation.UcitajAranzman:
                        {
                            response.Result = (Aranzman)Controller.Instance.UcitajAranzman((int)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.UcitajDestinaciju:
                        {
                            response.Result = (string)Controller.Instance.UcitajDestinaciju((int)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.IzmeniRezervaciju:
                        {
                            response.Result = (bool)Controller.Instance.IzmeniRezervaciju((Rezervacija)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.ObrisiRezervaciju:
                        {
                            response.Result = (bool)Controller.Instance.ObrisiRezervaciju((Rezervacija)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.PronadjiRezervacije:
                        {
                            response.Result = (BindingList<Rezervacija>)Controller.Instance.PronadjiRezervacije((string)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                    case Operation.ZatvoriAplikaciju:
                        {
                            radi = false;
                            socket.Shutdown(SocketShutdown.Both);
                            break;
                        }
                    case Operation.VratiSveAdmine:
                        {
                            response.Result = (BindingList<User>)Controller.Instance.VratiSveAdministratore((BindingList<User>)request.Argument);
                            formatter.Serialize(stream, response);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                response.Exception = new Exception(ex.Message);
            }
        }
    }
}