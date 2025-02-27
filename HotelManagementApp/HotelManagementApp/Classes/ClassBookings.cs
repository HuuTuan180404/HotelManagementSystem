using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp.Classes
{
    internal class ClassBookings
    {
        private int BID;
        private int RID;
        private string CID;
        private DateTime BTimeCheckIn;
        private DateTime BTimeCheckOut;
        private string BStatus;
        private DateTime BCreateAt;

        public static string TABLE_NAME = "[HotelManagementSystem_demo].[dbo].[Bookings]";
        public static string TABLE_Bookings = @"
                                    SELECT [BID]
                                          ,CONCAT('Roo',R.RFloor,'0',R.RNo) AS RooNo
                                          ,CID
                                          ,[BTimeCheckIn]
                                          ,[BTimeCheckOut]
                                          ,[BStatus]
                                          ,[BCreateAt]" +
                                    $" FROM {TABLE_NAME} B JOIN {ClassRoom.TABLE_NAME} R ON B.RID=R.RID";


        public void setBID(int a) { BID = a; }
        public void setRID(int a) { RID = a; }
        public void setCID(string a) { CID = a; }
        public void setBStatus(string a) { BStatus = a; }
        public void setBTimeCheckIn(DateTime a) { BTimeCheckIn = a; }
        public void setBTimeCheckOut(DateTime a) { BTimeCheckOut = a; }
        public void setBCreateAt(DateTime a) { BCreateAt = a; }

        public int getBID() { return BID; }
        public int getRID() { return RID; }
        public string getCID() { return CID; }
        public DateTime getBTimeCheckIn() { return BTimeCheckIn; }
        public DateTime getBTimeCheckOut() { return BTimeCheckOut; }
        public string getBStatus() { return BStatus; }
        public DateTime getBCreateAt() { return BCreateAt; }





    }
}
