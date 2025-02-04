using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Address
    { 
        private string _street;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string street, string city, string stateProvince, string country)
        {
            _street = street;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }
        public bool IsInUSA()
        {
            return _country.ToUpper() == "USA";
        }
        public string GetFullAddress()
        {
            return $"{_street}, {_city}, {_stateProvince}, {_country}";
        }
    


    }
}