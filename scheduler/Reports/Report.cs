using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using scheduler.Customers;

namespace scheduler.Reports
{
    internal class Report
    {
        public static Dictionary<string, int> GenerateAppointmentByType(string month, string type)
        {
            //Temporary dict to return
            Dictionary<string, int> typePairs = new Dictionary<string, int>();

            //LINQ command with lambdas to more efficiently select specified appointments by type and month
            var groupByType = 
                Appointment.AllAppointments.Where(appointment => appointment.Start.ToString("MMMM", CultureInfo.InvariantCulture) == month && 
                                                 (string.IsNullOrEmpty(type)) || appointment.Type == type) //Allows all type report if empty
                                           .GroupBy(appointment => appointment.Type)
                                           .Select(g => new
                                           {
                                               Type = g.Key,
                                               Count = g.Count()
                                           });

            //Adds the grouped values to the dictionary and returns it
            foreach (var grp in groupByType)
            {
                typePairs.Add(grp.Type, grp.Count);
            }
            return typePairs;
        }
        public static Dictionary<string, int> GenerateAppointmentByCustomer()
        {
            //Temporary List to return
            Dictionary<string, int> appointmentByCustomer = new Dictionary<string, int>();

            //Adds the grouped values to the dictionary and returns it, using lambdas to shorten query length
            var groupByType = Appointment.AllAppointments.GroupBy(customer => customer.CustomerId)
                .Select(g => new
                {
                    Name = Customer.CustomerLookup(g.Key).CustomerName,
                    AppointmentCount = g.Select(c => c.AppointmentId).Count()
                });

            foreach (var grp in groupByType)
            {
                appointmentByCustomer.Add(grp.Name, grp.AppointmentCount);
            }

            return appointmentByCustomer;
        }
    }
}
