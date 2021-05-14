using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eades_Dialer
{
    class Phone
    {
        string[] phone = new string[10];

        private string _company;
        private string _number;
        private int _celldetermine;

        public Phone(string Company, string Number, int cellDetermine)
        {
            _company = Company;
            _number = Number;
            _celldetermine = cellDetermine;
        }







        public string Company
        {
            get { return _company; }
        }
       
        public string Number
        {
            get { return _number; }
            
        }







    }
}
