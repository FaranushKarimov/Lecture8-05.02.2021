using System;
using System.Data;
using System.Data.SqlClient;

namespace Lecture8_04._02._2021
{
    public static class Commands
    {
        public const string conString = @"Data source=KARIMOVFARAMUSH ; Initial catalog=alif_academy; Integrated Security=true";

        public static void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command1 = connection.CreateCommand();

                command1.Transaction = transaction;

                try
                {
                    command1.CommandText = $"delete PersonTable where id = {id}";
                    command1.ExecuteNonQuery();
                    transaction.Commit();
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Done...");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    System.Console.WriteLine(ex.Message);
                }
                connection.Close();
            }
        }

        public static void Update(string FirstName, string SecondName, string MiddleName, string Birthday, int id)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command1 = connection.CreateCommand();

                command1.Transaction = transaction;

                try
                {
                    command1.CommandText = $"update PersonTable set FirstName = '{FirstName}', LastName = '{SecondName}', MiddleName = '{MiddleName}', BirthDate = '{Birthday}' where Id = {id}";
                    command1.ExecuteNonQuery();
                    transaction.Commit();
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Done...");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    System.Console.WriteLine(ex.Message);
                }
                connection.Close();
            }
        }

        public static void SelectByID(int ID)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("\nID\t\tFirstname\t\tLastname\t\tMiddlename\t\tBirthday");
            string commandText = $"Select * from PersonTable where id = '{ID}'";
            SqlCommand command = new SqlCommand(commandText, con);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                String tempId = reader.GetValue(0).ToString();
                String tempFirst = reader.GetValue(1).ToString();
                String tempSecond = reader.GetValue(2).ToString();
                string tempMiddle = reader.GetValue(3).ToString();
                String tempDate = reader.GetValue(4).ToString().Trim().Substring(0, 10);

                ConsoleShow.ShowTable(tempId, tempFirst, tempSecond, tempMiddle, tempDate);
            }
            reader.Close();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SelectAll()
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                System.Console.WriteLine("Connected");
            }
            else
            {
                System.Console.WriteLine("Error");
            }
            string commandText = "Select * from PersonTable";
            SqlCommand command = new SqlCommand(commandText, con);

            Console.ForegroundColor = ConsoleColor.Green;


            System.Console.WriteLine("\nID\t\tFirstname\t\tLastname\t\tMiddlename\t\tBirthday");

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                String tempId = reader.GetValue(0).ToString();
                String tempFirst = reader.GetValue(1).ToString();
                String tempSecond = reader.GetValue(2).ToString();
                string tempMiddle = reader.GetValue(3).ToString();
                String tempDate = reader.GetValue(4).ToString().Trim().Substring(0, 10);

                ConsoleShow.ShowTable(tempId, tempFirst, tempSecond, tempMiddle, tempDate);
            }
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.Write("\nPlease press any key to continue...");
            Console.ReadKey();
            reader.Close();
        }


        public static void Insert(string Firstname, string Lastname, string Middlename, string Birthday)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command1 = connection.CreateCommand();

                command1.Transaction = transaction;

                try
                {
                    command1.CommandText = $"INSERT into PersonTable([FirstName], [LastName], [MiddleName], [BirhDate]) VALUES ('{Firstname}', '{Lastname}', '{Middlename}', '{Birthday}')";
                    command1.ExecuteNonQuery();
                    transaction.Commit();
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Done...");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                catch (Exception ex)
                {
                    transaction.Rollback();
                    System.Console.WriteLine(ex.Message);
                }
                connection.Close();

            }
        }
    }
}
