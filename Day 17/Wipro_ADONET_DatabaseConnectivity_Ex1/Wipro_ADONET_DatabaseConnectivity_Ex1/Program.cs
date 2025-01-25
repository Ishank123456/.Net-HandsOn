using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Wipro_ADONET_DatabaseConnectivity_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=Wipro_20_08_2024;Integrated Security=True");

            start:
            string selectAllQuery = "Select * from Employee";
            Console.WriteLine("Enter 1.Select  2.Insert  3.Update  4.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    DisplayEmployeeData(con, selectAllQuery);
                    break;
                case 2:
                    InsertEmployeeData(con);
                    break;
                case 3:
                    UpdateEmployeeData(con);
                    break;
                case 4:
                    DeleteEmployeeData(con);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("Do you want to continue? Y/N");
            char c = Convert.ToChar(Console.ReadLine());
            if(c == 'Y' || c == 'y')
            {
                goto start;
            }
            Console.ReadLine();
        }

        public static void DeleteEmployeeData(SqlConnection con)
        {
            Console.WriteLine("Enter the Employee Id record need to be deleted: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            string selectOneQuery = $"Select * from Employee Where EmpId = {empId}";
            DisplayEmployeeData(con, selectOneQuery);

            Console.WriteLine("Do you want to delete? Y/N");
            char ch2 = Convert.ToChar(Console.ReadLine());
            if(ch2 == 'Y' || ch2 == 'y')
            {
                string strDeleteQuery = $"Delete from Employee Where EmpId = {empId}";
                try
                {
                    SqlCommand cmd = new SqlCommand(strDeleteQuery, con);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if(i != 0)
                    {
                        Console.WriteLine(i + "Data Deleted");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public static void UpdateEmployeeData(SqlConnection con)
        {
            Console.WriteLine("Enter the Employee Id: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            string selectOneQuery = $"Select * from Employee Where EmpId = {empId}";
            DisplayEmployeeData(con, selectOneQuery);

            Console.WriteLine("Do yo want to Update? Y/N");
            char ch1 = Convert.ToChar(Console.ReadLine());
            if(ch1 == 'Y' || ch1 == 'y')
            {
                Console.WriteLine("Enter the Employee Name: ");
                string empName = Console.ReadLine();
                Console.WriteLine("Enter the Employee Address: ");
                string empAddress = Console.ReadLine();
                Console.WriteLine("Enter the Employee Contact: ");
                string empContact = Console.ReadLine();
                Console.WriteLine("Enter the Employee Salary: ");
                decimal empSal = Convert.ToDecimal(Console.ReadLine());

                string strUpdateQuery = $"Update Employee set " +
                                        $"EmpName = '{empName}', EmpAddress = '{empAddress}', " +
                                        $"EmpContact = '{empContact}', EmpSalary = {empSal} " +
                                        $"Where EmpId = {empId}";
                try
                {
                    SqlCommand cmd = new SqlCommand(strUpdateQuery, con);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if(i != 0)
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

        public static void InsertEmployeeData(SqlConnection con)
        {
            Console.WriteLine("Enter the Employee Name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Address: ");
            string empAddress = Console.ReadLine();
            Console.WriteLine("Enter the Employee Contact: ");
            string empContact = Console.ReadLine();
            Console.WriteLine("Enter the Employee Salary: ");
            decimal empSal = Convert.ToDecimal(Console.ReadLine());

            string strInsertQuery = $"Insert into Employee values"+
                                    $"('{empName}', '{empAddress}', '{empContact}', '{empSal}')";

            try
            {
                SqlCommand cmd = new SqlCommand(strInsertQuery, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    Console.WriteLine(i + " Data Saved");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DisplayEmployeeData(SqlConnection con, string selectAllQuery)
        {
            SqlCommand cmd = new SqlCommand(selectAllQuery, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int empId = Convert.ToInt32(ds.Tables[0].Rows[i]["EmpId"].ToString());
                    string empName = ds.Tables[0].Rows[i]["EmpName"].ToString();
                    string empAddress = ds.Tables[0].Rows[i]["EmpAddress"].ToString();
                    string empContact = ds.Tables[0].Rows[i]["EmpContact"].ToString();
                    decimal empSal = Convert.ToDecimal(ds.Tables[0].Rows[i]["EmpSalary"].ToString());

                    Console.WriteLine("====================Employee Details====================");
                    Console.WriteLine($"Employee ID: {empId} | Employee Name: {empName} | Employee Address: {empAddress} |");
                    Console.WriteLine($"Employee Contact: {empContact} | Employee Salary: {empSal}");
                    Console.WriteLine();
                }
            }
        }
    }
}
