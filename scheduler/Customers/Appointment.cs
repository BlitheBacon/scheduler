using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.Customers
{
    internal class Appointment
    {
        public Appointment() {}
        public Appointment(int appointmentID, string title, string description, string location, string contact, 
            string type, string url, DateTime start, DateTime end, DateTime createdDate, string createdBy)
        {
            AppointmentID = appointmentID;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Url = url;
            Start = start;
            End = end;
            CreatedDate = createdDate;
            CreatedBy = createdBy;
        }

        private int? _appointmentID    = null;
        private string _title          = null;
        private string _description    = null;
        private string _location       = null;
        private string _contact        = null;
        private string _type           = null;
        private string _url            = null;
        private DateTime? _start       = null;
        private DateTime? _end         = null;
        private DateTime? _createdDate = null;
        private string _createdBy      = null;

        public int AppointmentID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

    }

}
