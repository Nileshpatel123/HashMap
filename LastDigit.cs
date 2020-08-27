using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class LastDigit
    {
        public int LastDigits(string phone)
        {
            int index = 10;

            // extract the last letter from "name" string, and transform it to uppcase (to avoid dealing with a~z)
            char lasterNumber = phone[phone.Length - 1];

            // in ASCII table "0"~"9" map to number 48~57. http://www.asciitable.com/
            // (int)lasterNumber >= 48 && (int)lasterNumber <= 57 mean to check if firstChar is in between A~Z
            if ((int)lasterNumber >= 48 && (int)lasterNumber <= 57)
            {
                // we use "(int)letter - 47" to map "0"~"9" to 0~9
                index = (int)lasterNumber - 47;
            }
            else
            {
                // map all non "0"/"9" char to 10
                index = 10;
            }
            return index;
        }
    }
}
