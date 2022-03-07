using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_projekt
{
    class Custommer
    {
        private string _csname;
        private int _phoneNumber;
        private string _adress;
        public Custommer(string csname, int phoneNumber, string adress)
        {
            _csname = csname;
            _phoneNumber = phoneNumber;
            _adress = adress;
        }
        public string CSName
        {
            get { return _csname; }
        }
        public string Adress
        {
            get { return _adress; }
        }
        public int PhoneNumber
        {
            get { return _phoneNumber; }
        }
        public override string ToString()
        {
            return $"{CSName} - Phone number: {PhoneNumber} - Adress: {Adress}";
        }
    }
}
