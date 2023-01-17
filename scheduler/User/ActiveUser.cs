using scheduler.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.User
{
    internal class ActiveUser
    {
        public ActiveUser() { }
        public ActiveUser(uint userID, string userName)
        {
            UserID = userID;
            UserName = userName;
        }

        public static ActiveUser userInformation = null;
        public BindingList<int> appointments = new BindingList<int>();

        //Private Fields
        private UInt32? _userID = null;
        private string _userName = null;

        //Public Field Interface
        public UInt32 UserID { get; set; }
        public string UserName { get; set; }

    }
}
