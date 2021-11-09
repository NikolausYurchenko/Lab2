using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    class User
    {
        private string _login;
        private string _firstName;
        private string _lastName;
        private int _age;
        private DateTime _date = new DateTime(2021, 08, 7, 15, 4, 54);
        
        public string Login
        {
            set
            {
                _login = value;
            }
            get
            {
                return _login;
            }
        }
        public string FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }
        public int Age
        {
            set
            {
                if((value >=1) && (value <= 130)) //Проверка возраста 
                {
                    _age = value;
                }
                else
                {
                    _age = 0;
                }
            }
            get
            {
                return _age;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }
    }
}
