using System;
using System.Data;
using System.Data.SqlClient;

namespace Wipro_ADONET_DatabaseConnectivity_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=Wipro_20_08_2024;Integrated Security=True");
        start:
            string selectAllQuery = "Select * from Customer";
            Console.WriteLine("Enter 1.Select  2.Insert  3.Update  4.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    DisplayCustomerData(con, selectAllQuery);
                    break;
                case 2:
                    InsertCustomerData(con);
                    break;
                case 3:
                    UpdateCustomerData(con);
                    break;
                case 4:
                    DeleteCustomerData(con);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("Do you want to continue? Y/N");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'Y' || c == 'y')
            {
                goto start;
            }
            Console.ReadLine();
        }

        public static void DisplayCustomerData(SqlConnection con, string strSelectAllQuery)
        {
            SqlCommand cmd = new SqlCommand(strSelectAllQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if(ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int custId = Convert.ToInt32(ds.Tables[0].Rows[i]["CustId"].ToString());
                    string custName = ds.Tables[0].Rows[i]["CustName"].ToString();
                    int custAge = Convert.ToInt32(ds.Tables[0].Rows[i]["CustAge"].ToString());
                    string custGender = ds.Tables[0].Rows[i]["CustGender"].ToString();
                    string custCity = ds.Tables[0].Rows[i]["CustCity"].ToString();
                    string custEmail = ds.Tables[0].Rows[i]["CustEmail"].ToString();

                    Console.WriteLine("============================Customer Details============================");
                    Console.WriteLine($"Customer ID: {custId}   |   Customer Name: {custName}");
                    Console.WriteLine($"Customer Age: {custAge}   |   Customer Gender: {custGender}");
                    Console.WriteLine($"Customer City: {custCity}   |   Customer Email: {custEmail}");
                    Console.WriteLine();
                }
            }
        }

        public static void InsertCustomerData(SqlConnection con)
        {
            Console.WriteLine("Enter the Customer Name: ");
            string custName = Console.ReadLine();
            Console.WriteLine("Enter the Customer Age: ");
            int custAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer Gender: ");
            string custGender = Console.ReadLine();
            Console.WriteLine("Enter the Customer City: ");
            string custCity = Console.ReadLine();
            Console.WriteLine("Enter the Customer Email: ");
            string custEmail = Console.ReadLine();

            string strInsertQuery = $"Insert into Customer values" +
                                    $"('{custName}', {custAge}, '{custGender}', '{custCity}', '{custEmail}')";

            try
            {
                SqlCommand cmd = new SqlCommand(strInsertQuery, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if(i != 0)
                {
                    Console.WriteLine(i + "Data Inserted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void UpdateCustomerData(SqlConnection con)
        {
            Console.WriteLine("Enter the Customer Id: ");
            int custId = Convert.ToInt32(Console.ReadLine());
            string selectOneQuery = $"Select * from Customer Where CustId = {custId}";
            DisplayCustomerData(con, selectOneQuery);

            Console.WriteLine("Do yo want to Update? Y/N");
            char ch1 = Convert.ToChar(Console.ReadLine());
            if (ch1 == 'Y' || ch1 == 'y')
            {
                Console.WriteLine("Enter the Customer Name: ");
                string custName = Console.ReadLine();
                Console.WriteLine("Enter the Customer Age: ");
                int custAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Customer Gender: ");
                string custGender = Console.ReadLine();
                Console.WriteLine("Enter the Customer City: ");
                string custCity = Console.ReadLine();
                Console.WriteLine("Enter the Customer Email: ");
                string custEmail = Console.ReadLine();

                string strUpdateQuery = $"Update Customer Set " +
                                        $"CustName = '{custName}', CustAge = {custAge}, " +
                                        $"CustGender = '{custGender}', CustCity = '{custCity}', CustEmail = '{custEmail}'" +
                                        $"Where CustId = {custId}";

                try
                {
                    SqlCommand cmd = new SqlCommand(strUpdateQuery, con);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i != 0)
                    {
                        Console.WriteLine(i + "Data Updated");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void DeleteCustomerData(SqlConnection con)
        {
            Console.WriteLine("Enter the Customer Id record need to be deleted: ");
            int custId = Convert.ToInt32(Console.ReadLine());
            string selectOneQuery = $"Select * from Customer Where CustId = {custId}";
            DisplayCustomerData(con, selectOneQuery);

            Console.WriteLine("Do you want to delete? Y/N");
            char ch2 = Convert.ToChar(Console.ReadLine());
            if (ch2 == 'Y' || ch2 == 'y')
            {
                string strDeleteQuery = $"Delete from Customer Where CustId = {custId}";
                try
                {
                    SqlCommand cmd = new SqlCommand(strDeleteQuery, con);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i != 0)
                    {
                        Console.WriteLine(i + "Data Deleted");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
