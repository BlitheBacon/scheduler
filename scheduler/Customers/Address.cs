using System.Collections.Generic;

namespace scheduler.Customers
{
    internal class Address
    {
        public Address() {}
        public Address(int addressId, int cityId, int countryId, string addressOne, string addressTwo, 
            string postalCode, string phoneNumber, string city, string country)
        {
            AddressId   = addressId;
            CityId      = cityId;
            CountryId   = countryId;
            AddressOne  = addressOne;
            AddressTwo  = addressTwo;
            PostalCode  = postalCode;
            PhoneNumber = phoneNumber;
            City        = city;
            Country     = country;
        }

        private static int? _addressId     = null;
        private static int? _cityId        = null;
        private static int? _countryId     = null;
        private static string _addressOne  = null;
        private static string _addressTwo  = null;
        private static string _postalCode  = null;
        private static string _phoneNumber = null;
        private static string _city        = null;
        private static string _country     = null;

        public int AddressId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string AddressOne { get; set; }
        public string AddressTwo { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
