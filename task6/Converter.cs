using System;
using System.Collections.Generic;
using System.Text;

namespace task6
{
    class Converter
    {
        private double _usd;
        private double _eur;
        private double _rub;
        private double _amount;
        private double _result;

        public double Result
        {
            get
            {
                return _result;
            }
        }
        public double Amount
        {
            set
            {
                if(value >= 0)
                {
                    _amount = value;
                }
                else
                {
                    _amount = 0;
                }
            }
        }

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }


        // Методы, которые имеют в себе формулы для вычисления курса
        public void ConvertToUsd()
        {
            _result = _amount / _usd;
        }
        public void ConvertToEur()
        {
            _result = _amount / _eur;
        }
        public void ConvertToRub()
        {
            _result = _amount / _rub;
        }
        public void ConvertToUah(double currency)
        {
            _result = currency * _amount;
        }
    }
}
