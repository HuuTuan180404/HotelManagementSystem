using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp.Classes
{
    public class ClassRoom
    {
        private int rooID;
        private string rooNo;
        private string rooType;
        private int rooBed;
        private int rooFloor;
        private int rooCustomer;
        private int rooPrice;
        private string rooStatus;
        private string rooNote;

        public ClassRoom() { }

        public ClassRoom(int rooID, string rooNo, string rooType, int rooBed, int rooFloor,
            int rooCustomer, int rooPrice, string rooStatus, string rooNote)
        {
            this.rooID = rooID;
            this.rooNo = rooNo;
            this.rooType = rooType;
            this.rooBed = rooBed;
            this.rooFloor = rooFloor;
            this.rooCustomer = rooCustomer;
            this.rooPrice = rooPrice;
            this.rooStatus = rooStatus;
            this.rooNote = rooNote;
        }       

        public override string ToString()
        {
            return $"Room ID: {RooID}, Room No: {RooNo}, Type: {RooType}, Beds: {RooBed}, " +
                   $"Floor: {RooFloor}, Max Customers: {RooCustomer}, Price: {RooPrice}, " +
                   $"Status: {RooStatus}, Note: {RooNote}";
        }

        // Getter & Setter
        public int RooID
        {
            get { return rooID; }
            set { rooID = value; }
        }

        public string RooNo
        {
            get { return rooNo; }
            set { rooNo = value; }
        }

        public string RooType
        {
            get { return rooType; }
            set { rooType = value; }
        }

        public int RooBed
        {
            get { return rooBed; }
            set { rooBed = value; }
        }

        public int RooFloor
        {
            get { return rooFloor; }
            set { rooFloor = value; }
        }

        public int RooCustomer
        {
            get { return rooCustomer; }
            set { rooCustomer = value; }
        }

        public int RooPrice
        {
            get { return rooPrice; }
            set { rooPrice = value; }
        }

        public string RooStatus
        {
            get { return rooStatus; }
            set { rooStatus = value; }
        }

        public string RooNote
        {
            get { return rooNote; }
            set { rooNote = value; }
        }

    }
}
