using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace scheduler.Customers
{
    internal class Appointment
    {
        public Appointment() {}
        public Appointment(int appointmentId, int customerId, string name, string title, string description, string location, string contact, 
            string type, string url, DateTime start, DateTime end, DateTime createdDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AppointmentId = appointmentId;
            CustomerId = customerId;
            Name = name;
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
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        public static BindingList<Appointment> AllAppointments = new BindingList<Appointment>();
        public static BindingList<Appointment> AllAppointmentsSource = new BindingList<Appointment>();
        public static readonly BindingList<string> AppointmentTypes = new BindingList<string> {"", "Scrum", "Stand-Up", "Manager", "Department Heads", "Consultation", "Presentation", "HR"};

        public int AppointmentId { get; set; }

        public int CustomerId { get; set; }

        public string Name { get; set; }

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

        public DateTime LastUpdate { get; set; }

        public string LastUpdateBy { get; set; }

        public static int ValidAppointmentChecks(Customer customer, int appointmentId, DateTime startDate, DateTime startTime, DateTime endDate, DateTime endTime)
        {
            //Determines if appointment occurs within business hours: Mon - Fri, 10AM - 6PM
            if (startDate.DayOfWeek == DayOfWeek.Saturday || endDate.DayOfWeek == DayOfWeek.Sunday) { return -1; }
            if (startTime.Hour < 10 || endTime.Hour > 18) { return -2; }

            //Checks for valid customer
            if (customer == null) { return -3; }

            //Checks for appointment overlap
            foreach (var appointment in AllAppointments)
            {
                if (appointment.AppointmentId != appointmentId)
                {
                    if (startTime > endTime)
                    {
                        return -4;
                    }
                    else if (startDate.Day == appointment.Start.Day &&
                             startTime >= appointment.Start && startTime < appointment.End ||
                             endTime < appointment.End && endTime > appointment.Start)
                    {
                        return -5;
                    }
                }
            }
            //Returns a pass for all checks
            return 0;
        }
    }
}
