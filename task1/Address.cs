using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private int _house;
        private int _appartment;

        public int Index
        {
            set
            {
                _index = value;
            }
            get
            {
                return _index;
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                _street = value;
            }
        }
        public int House
        {
            get
            {
                return _house;
            }
            set
            {
                _house = value;
            }
        }
        public int Appartment
        {
            get
            {
                return _appartment;
            }
            set
            {
                _appartment = value;
            }
        }
    }
}
