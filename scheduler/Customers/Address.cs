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
