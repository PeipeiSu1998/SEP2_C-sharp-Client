using Client.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static Client.Controller.SocketRequest;

namespace Client.Controller
{
    class WMEController : IWMEController
    {
        private int Port = 4400;
        IPEndPoint serverAddress;
        Socket clientSocket;

        SocketRequest Request = new SocketRequest();
        JsonSerializer JsonSerializer = new JsonSerializer();

        public void assignLocationToCompany(string locationID, string companyID)
        {
            throw new NotImplementedException();
        }

        public void editCompany(RegisterCompany company)
        {
            throw new NotImplementedException();
        }

        public LocationList getAvailableLocationList()
        {
            throw new NotImplementedException();
        }

        public PalletList getAvailablePalletList()
        {
            throw new NotImplementedException();
        }

        public Company getCompanyByID(string companyID)
        {
            throw new NotImplementedException();
        }

        public CompanyList getCompanyList()
        {
            throw new NotImplementedException();
        }

        public Location getLocationByID(string locationID)
        {
            throw new NotImplementedException();
        }

        public Pallet getPalletByID(string palletID, string companyID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Takes a company object, converts it into JSON and sends it to the java server. Expect a server reply used for tests.
        /// </summary>
        /// <param name="company"></param>
        public void registerCompany(Company company)
        {
            //socket connection
            //Setup();

            Request = new SocketRequest();
            Request.Action = ACTION.REGISTER_COMPANY;
            Request.Obj = company;
            //send request
            string requestAsJSON = JsonConvert.SerializeObject(Request);
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();
            bool response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            //return response;
        }

        public void removeLocationFromCurrentCompany(string companyID)
        {
            throw new NotImplementedException();
        }

        public void removePallet(string palletID, string companyID)
        {
            throw new NotImplementedException();
        }

        public void storePallet(Pallet pallet, string locationID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method is getting local addres from the client computer
        /// </summary>
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        /// <summary>
        /// This method creates socket connection on chosen port(in our case 4400)
        /// </summary>
        public void Setup()
        {
            serverAddress = new IPEndPoint(IPAddress.Parse(GetLocalIPAddress()), Port);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(serverAddress);
        }

        /// <summary>
        /// This method is converting ASCII bytes to string
        /// </summary>
        public string ReadReplyMessage()
        {
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            string rcv = Encoding.ASCII.GetString(rcvBytes);

            return rcv;
        }

        /// <summary>
        /// This method is sending ASCII bytes with the header byte giving the length of the message
        /// </summary>
        public void SendMessage(string Message)
        {
            int toSendLen = Encoding.ASCII.GetByteCount(Message);
            byte[] toSendBytes = Encoding.ASCII.GetBytes(Message);
            byte[] toSendLenBytes = BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
        }
    }
}
