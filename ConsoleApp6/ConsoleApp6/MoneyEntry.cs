using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class MoneyEntry
    {
        private double _amoynt;
        public MoneyEntry()
        {
            _amoynt = 0;
            EntryDate = DateTime.Now;
        }
        public MoneyEntry(double amoynt, DateTime date)
        {
            _amoynt = amoynt;
            EntryDate = date;
        }
        public void InitWithString(string amoynt,string date)
        {
            Double.TryParse(amoynt, out _amoynt);
            DateTime dt;
            DateTime.TryParse(date, out dt);
            EntryDate = dt;


        }
        public override string  ToString()
        {
            return string.Format("{0} от{1}", _amoynt, EntryDate.Date); 
        }
        public bool IsDebit
        {
         get
            {
             return (_amoynt >= 0);
            }
            set
            {
                if (value && _amoynt < 0)
                    _amoynt = -_amoynt;
            }
        }
        public double Amoynt
        {
            get{return _amoynt;}
            set { _amoynt = value; }
        }
        public DateTime EntryDate { set; get; }

    }

}
