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
        public ActiveUser(uint userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }

        public static ActiveUser UserInformation = null;
        public BindingList<int> Appointments = new BindingList<int>();

        //Private Fields
        private uint? _userId = null;
        private string _userName = null;

        //Public Field Interface
        public uint? UserId { get => _userId; set => _userId = value; }
        public string UserName { get; set; }

    }
}
