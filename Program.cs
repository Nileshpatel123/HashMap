using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PhonebookRecord[] phonebook = new PhonebookRecord[6];

            phonebook[0] = new PhonebookRecord("Lucie", 0312897654);
            phonebook[1] = new PhonebookRecord("Nancy", 0436123987);
            phonebook[2] = new PhonebookRecord("Jamie", 0412345789);
            phonebook[3] = new PhonebookRecord("Davis", 0326654321);
            phonebook[4] = new PhonebookRecord("Marissa", 0415888999);
            phonebook[5] = new PhonebookRecord("Marissaaa", 0415888999);

            foreach (PhonebookRecord phonebooks in phonebook)
            {
                Console.WriteLine(phonebooks.name + " " + phonebooks.phoneNo);
            }

            List<PhonebookRecord>[] firstLetter = new List<PhonebookRecord>[27];

            for(int i=0; i< firstLetter.Length; i++)
            {
                firstLetter[i] = new List<PhonebookRecord>();
            }

            foreach(PhonebookRecord record in phonebook)
            {
                int index = Character.firstCharacter(record.name);
                firstLetter[index].Add(record);
            }

            for (int i = 0; i < firstLetter.Length; i++)
            {
                Console.Write($"[{i}]:\t");
                foreach (PhonebookRecord record in firstLetter[i])
                {
                    Console.Write($"[{record.name} / {record.phoneNo}] -> ");
                }
                Console.Write("\n");
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter\n1: Search by name\n2: Search by number\n3: exit");

                int searchNo = Convert.ToInt32(Console.ReadLine());
                Boolean found = true;

                if (searchNo == 1)
                {
                    Console.WriteLine("Please enter name");
                    string name = Console.ReadLine();

                    for (int i = 0; i < phonebook.Length; i++)
                    {
                        if (name.Equals(phonebook[i].name))
                        {
                            found = true;
                            Console.WriteLine("Mr " + phonebook[i].name + " your number is " + phonebook[i].phoneNo);
                        }

                        if (found == false)
                        {
                            Console.WriteLine(name + " not found");
                        }
                    }
                }

                else if (searchNo == 2)
                {
                    Console.WriteLine("Please enter number");
                    int number = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < phonebook.Length; i++)
                    {
                        if (number == phonebook[i].phoneNo)
                        {
                            found = true;
                            Console.WriteLine("Mr " + phonebook[i].name + " your number is " + phonebook[i].phoneNo);
                        }
                        if (found == false)
                        {
                            Console.WriteLine(number + " not found");
                        }
                    }
                }

                else if (searchNo == 3)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
                    Console.ReadKey();
        }
    }
}
