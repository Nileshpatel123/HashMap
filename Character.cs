using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Character
    {
        public static int firstCharacter(string name)
        {
            int index = 0;

            char firstChar = Char.ToUpper(name[0]);
            int fchar = Convert.ToInt32(firstChar);

            if( fchar >= 65 && fchar <= 90)
            {
                index = fchar - 64;
            }
            else
            {
                index = 0;
            }
            return index;
        }
    }
}
