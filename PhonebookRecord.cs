using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class PhonebookRecord
    {
        public string name;
        public int phoneNo;

        public PhonebookRecord()
        {
            name = "";
            phoneNo = 0;
        }

        public PhonebookRecord(string fullname, int number)
        {
            name = fullname;
            phoneNo = number;
        }
    }
}
