using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.Authentication
{
    internal class ActiveUserInformation
    {
        public ActiveUserInformation() { }
        public ActiveUserInformation(uint userID, string userName, string password)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
        }

        public static ActiveUserInformation activeUser;

        //Private Fields
        private UInt32? _userID = null;
        private string _userName = null;
        private string _password = null;

        //Public Field Interface
        public UInt32 UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
