using System;
using System.Data;
using System.Data.SqlClient;

namespace Lecture8_04._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            bool working = true;
            while (working)
            {
                System.Console.Write(@"
                Choose Function: 
                1. Insert
                2. Select All
                3. Select By ID
                4. Update
                5. Delete by ID 
                6. Exit
                Please input reference number: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Firstname: ");
                            string tempFirstName = Console.ReadLine();

                            Console.Write("Secondname: ");
                            string tempSecondName = Console.ReadLine();

                            Console.Write("Middlename: ");
                            string tempMiddleName = Console.ReadLine();

                            Console.Write("Day of Birth (format: dd): ");
                            string tempDay = Console.ReadLine();

                            Console.Write("Month Of Birth (format: MM): ");
                            string tempMonth = Console.ReadLine();

                            Console.Write("Year of Birth (format:YYYY): ");
                            string tempYear = Console.ReadLine();

                            string Birthday = tempDay + "." + tempMonth + "." + tempYear;

                            Commands.Insert(tempFirstName, tempSecondName, tempMiddleName, Birthday);

                        }
                        break;
                    case 2:
                        {
                            Commands.SelectAll();
                        }
                        break;
                    case 3:
                        {
                            System.Console.Write("Entere reference id: ");
                            int tempId = int.Parse(Console.ReadLine());
                            Commands.SelectByID(tempId);
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Id: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.WriteLine("Type Edits");

                            Console.Write("Firstname: ");
                            string tempFirstName = Console.ReadLine();

                            Console.Write("Secondname: ");
                            string tempSecondName = Console.ReadLine();

                            Console.Write("Middlename: ");
                            string tempMiddleName = Console.ReadLine();

                            Console.Write("Day of Birth (format: dd): ");
                            string tempDay = Console.ReadLine();

                            Console.Write("Month Of Birth (format: MM): ");
                            string tempMonth = Console.ReadLine();

                            Console.Write("Year of Birth (format:YYYY): ");
                            string tempYear = Console.ReadLine();

                            string Birthday = tempDay + "." + tempMonth + "." + tempYear;
                            Commands.Update(tempFirstName, tempSecondName, tempMiddleName, Birthday, id);

                        }
                        break;
                    case 5:
                        {
                            Console.Write("Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Commands.Delete(id);

                        }
                        break;
                    case 6:
                        {
                            working = false;
                        }
                        break;
                }
            }


        }
    }
}
