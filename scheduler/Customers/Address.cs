using System.Collections.Generic;

namespace scheduler.Customers
{
    internal class Address
    {
        public Address() {}
        public Address(int addressID, int cityID, int countryID, string addressOne, string addressTwo, 
            string postalCode, string phoneNumber, string city, string country)
        {
            AddressID   = addressID;
            CityID      = cityID;
            CountryID   = countryID;
            AddressOne  = addressOne;
            AddressTwo  = addressTwo;
            PostalCode  = postalCode;
            PhoneNumber = phoneNumber;
            City        = city;
            Country     = country;
        }

        private int? _addressID     = null;
        private int? _cityID        = null;
        private int? _countryID     = null;
        private string _addressOne  = null;
        private string _addressTwo  = null;
        private string _postalCode  = null;
        private string _phoneNumber = null;
        private string _city        = null;
        private string _country     = null;

        public int AddressID { get; set; }
        public int CityID { get; set; }
        public int CountryID { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
