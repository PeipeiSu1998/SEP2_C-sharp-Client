using System;

namespace Client.Controller
{
    internal class SocketRequest
    {
        public ACTION Action { get; set; }
        public object Obj { get; set; } = new object();
        public string LocationID { get; set; }
        public string CompanyID { get; set; }
        public string PalletID { get; set; }

        public SocketRequest(ACTION action, Object obj, string locationID)
        {
            LocationID = locationID;
        }

        public SocketRequest(ACTION action, string ID)
        {
            if (action.Equals(ACTION.GET_COMPANY_BYID))
                CompanyID = ID;
            else if (action.Equals(ACTION.GET_PALLET_BYID))
                PalletID = ID;
            else if (action.Equals(ACTION.GET_LOCATION_BYID))
                LocationID = ID;
        }

        public SocketRequest(ACTION action, string ID1, string ID2)
        {
            if (action.Equals(ACTION.ASSIGN_LOCATION_TO_COMPANY) || action.Equals(ACTION.REMOVE_LOCATION_FROM_CURRENT_COMPANY))
            {
                LocationID = ID1;
                CompanyID = ID2;
            }

            if (action.Equals(ACTION.REMOVE_PALLET))
            {
                PalletID = ID1;
                LocationID = ID2;
            }
        }
        public SocketRequest(string palletID, string companyID)
        {

        }

        public SocketRequest(ACTION action, object obj)
        {
            Action = action;
            Obj = obj;
        }

        public SocketRequest()
        {
        }

        public enum ACTION
        {
            REGISTER_COMPANY,
            ASSIGN_LOCATION_TO_COMPANY,
            REMOVE_LOCATION_FROM_CURRENT_COMPANY,
            EDIT_COMPANY,
            GET_COMPANY_LIST,
            GET_COMPANY_BYID,
            STORE_PALLET,
            REMOVE_PALLET,
            GET_PALLET_BYID,
            GET_PALLET_LIST,
            GET_AVAILABLE_LOCATIONS,
            GET_LOCATION_BYID
        }
    }
}