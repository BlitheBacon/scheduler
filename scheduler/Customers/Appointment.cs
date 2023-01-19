using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace scheduler.Customers
{
    internal class Appointment
    {
        public Appointment() {}
        public Appointment(int appointmentId, int customerId, string name, string title, string description, string location, string contact, 
            string type, string url, DateTime start, DateTime end, DateTime createdDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            this.AppointmentId = appointmentId;
            this.CustomerId = customerId;
            this.Name = name;
            this.Title = title;
            this.Description = description;
            this.Location = location;
            this.Contact = contact;
            this.Type = type;
            this.Url = url;
            this.Start = start;
            this.End = end;
            this.CreatedDate = createdDate;
            this.CreatedBy = createdBy;
            this.LastUpdate = lastUpdate;
            this.LastUpdateBy = lastUpdateBy;
        }

        public static BindingList<Appointment> AllAppointments = new BindingList<Appointment>();

        public int AppointmentId 
        { 
            get => _appointmentId; 
            set => _appointmentId = value; 
        }
        public int CustomerId 
        { 
            get => _customerId; 
            set => _customerId = value; 
        }
        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
        public string Title 
        { 
            get => _title; 
            set => _title = value; 
        }
        public string Description 
        { 
            get => _description; 
            set => _description = value; 
        }
        public string Location 
        { 
            get => _location; 
            set => _location = value; 
        }
        public string Contact 
        { 
            get => _contact; 
            set => _contact = value; 
        }
        public string Type 
        { 
            get => _type;
            set => _type = value; 
        }
        public string Url 
        { 
            get => _url; 
            set=> _url = value; 
        }
        public DateTime Start 
        { 
            get => _start; 
            set => _start = value; 
        }
        public DateTime End 
        {
            get => _end;
            set => _end = value;
        }
        public DateTime CreatedDate 
        {
            get => _createdDate;
            set => _createdDate = value;
        }
        public string CreatedBy 
        {
            get => _createdBy;
            set => _createdBy = value;
        }
        public DateTime LastUpdate 
        {
            get => _lastUpdate;
            set => _lastUpdate = value;
        }
        public string LastUpdateBy 
        {
            get => _lastUpdateBy;
            set => _lastUpdateBy = value;
        }

        private int _appointmentId;
        private int _customerId;
        private string _name;
        private string _title = null;
        private string _description = null;
        private string _location;
        private string _contact;
        private string _type;
        private string _url = null;
        private DateTime _start;
        private DateTime _end;
        private string _createdBy;
        private DateTime _createdDate;
        private DateTime _lastUpdate;
        private string _lastUpdateBy;


    }

}
