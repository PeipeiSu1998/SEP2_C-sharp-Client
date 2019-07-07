﻿using Client.Model;
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
        SocketRequest SocketRequest = new SocketRequest();
        JsonSerializer JsonSerializer = new JsonSerializer();

        public void assignLocationToCompany(string locationID, string companyID)
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.ASSIGN_LOCATION_TO_COMPANY;
            SocketRequest.LocationID = locationID;
            SocketRequest.CompanyID = companyID;

            //serializing to Json
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);

            //send request
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();
            bool response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            //return response;
        }

        public void editCompany(Model.Company company)
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.EDIT_COMPANY;
            SocketRequest.Obj = company;

            //serializing to Json
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);

            //send request
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();
            bool response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            //return response;
        }

        public LocationList getAvailableLocationList()
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.GET_AVAILABLE_LOCATIONS;
            //send request
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();

            LocationList tempLocationList = new LocationList();
            clientSocket.NoDelay = true;

            //deserializing
            tempLocationList = JsonConvert.DeserializeObject<LocationList>(JsonString);

            clientSocket.Close();
            return tempLocationList;
        }

        public PalletList getAvailablePalletList()
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.GET_PALLET_LIST;
            //send request
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();

            PalletList tempPalletList = new PalletList();
            clientSocket.NoDelay = true;

            //deserializing
            tempPalletList = JsonConvert.DeserializeObject<PalletList>(JsonString);

            clientSocket.Close();
            return tempPalletList;
        }

        public Model.Company getCompanyByID(string companyID)
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.GET_COMPANY_BYID;
            SocketRequest.CompanyID = companyID;

            //send request
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();

            Model.Company tempCompany = new Model.Company();
            clientSocket.NoDelay = true;

            //deserializing
            tempCompany = JsonConvert.DeserializeObject<Model.Company>(JsonString);

            clientSocket.Close();
            return tempCompany;
        }

        public CompanyList getCompanyList()
        {
            Setup();

            //create request
            SocketRequest socketRequest = new SocketRequest();
            socketRequest.Action = ACTION.GET_COMPANY_LIST;

            //seriliazing to JSON
            string requestAsJSON = JsonConvert.SerializeObject(socketRequest);

            //send request 
            SendMessage(requestAsJSON);

            //read resultset
            string JsonString = ReadReplyMessage();

            CompanyList companyList = new CompanyList();
            clientSocket.NoDelay = true;
            //deseriliasing 
            companyList = JsonConvert.DeserializeObject<CompanyList>(JsonString);


            clientSocket.Close();

            return companyList;
        }

        public Location getLocationByID(string locationID)
        {
            Setup();

            //create request
            SocketRequest socketRequest = new SocketRequest();
            socketRequest.Action = ACTION.GET_LOCATION_BYID;
            socketRequest.LocationID = locationID;

            //seriliazing to JSON
            string requestAsJSON = JsonConvert.SerializeObject(socketRequest);

            //send request 
            SendMessage(requestAsJSON);

            //read resultset
            string JsonString = ReadReplyMessage();

            Location location = new Location();
            clientSocket.NoDelay = true;
            //deseriliasing 
            location = JsonConvert.DeserializeObject<Location>(JsonString);


            clientSocket.Close();

            return location;
        }

        public Pallet getPalletByID(string palletID, string companyID)
        {
            Setup();

            //create request
            SocketRequest socketRequest = new SocketRequest();
            socketRequest.Action = ACTION.GET_PALLET_BYID;
            socketRequest.PalletID = palletID;
            socketRequest.CompanyID = companyID;

            //seriliazing to JSON
            string requestAsJSON = JsonConvert.SerializeObject(socketRequest);

            //send request 
            SendMessage(requestAsJSON);

            //read resultset
            string JsonString = ReadReplyMessage();

            Pallet pallet = new Pallet();
            clientSocket.NoDelay = true;
            //deseriliasing 
            pallet = JsonConvert.DeserializeObject<Pallet>(JsonString);


            clientSocket.Close();

            return pallet;
        }

        /// <summary>
        /// Takes a company object, converts it into JSON and sends it to the java server. Expect a server reply used for tests.
        /// </summary>
        /// <param name="company"></param>
        public void registerCompany(Model.Company company)
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.REGISTER_COMPANY;
            SocketRequest.Obj = company;
            //send request
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();
            bool response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            //return response;
        }

        public void removeLocationFromCurrentCompany(string locationID)
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.REMOVE_LOCATION_FROM_CURRENT_COMPANY;
            SocketRequest.LocationID = locationID;
            //send request
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();
            bool response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            //return response;
        }

        public void removePallet(string palletID, string companyID)
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.REMOVE_PALLET;
            SocketRequest.PalletID = palletID;
            SocketRequest.CompanyID = companyID;

            //send request
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();
            bool response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            //return response;
        }

        public void storePallet(Pallet pallet, string locationID)
        {
            //socket connection
            Setup();

            SocketRequest = new SocketRequest();
            SocketRequest.Action = ACTION.STORE_PALLET;
            SocketRequest.Obj = pallet;
            SocketRequest.LocationID = locationID;

            //send request
            string requestAsJSON = JsonConvert.SerializeObject(SocketRequest);
            SendMessage(requestAsJSON);

            // used for testing purposes
            string JsonString = ReadReplyMessage();
            bool response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            //return response;
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