using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.Authentication
{
    internal class ActiveUser
    {
        public ActiveUser() { }
        public ActiveUser(uint userID, string userName)
        {
            UserID = userID;
            UserName = userName;
        }

        public static ActiveUser userInformation;

        //Private Fields
        private UInt32? _userID = null;
        private string _userName = null;

        //Public Field Interface
        public UInt32 UserID { get; set; }
        public string UserName { get; set; }
    }
}
