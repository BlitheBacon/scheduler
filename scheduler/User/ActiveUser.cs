using System.ComponentModel;

namespace scheduler.User
{
    internal class ActiveUser
    {
        public ActiveUser() { }
        public ActiveUser(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }

        public static ActiveUser UserInformation = null;
        public BindingList<int> Appointments = new BindingList<int>();

        //Private Fields
        private int _userId;
        private string _userName;

        //Public Field Interface
        public int UserId { get => _userId; set => _userId = value; }
        public string UserName { get => _userName; set => _userName = value; }

    }
}
