using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DatabaseConnectivuty_StoredProcedures_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=Wipro_20_08_2024;Integrated Security=True");
        start:
            string selectAllQuery = "SelectStudentDetails";
            Console.WriteLine("Enter 1.Select  2.Insert  3.Select With ID  4.Update  5.Delete");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    SelectStudentData(con, selectAllQuery);
                    break;
                case 2:
                    InsertStudentData(con);
                    break;
                case 3:
                    SelectStudentDataWithId(con);
                    break;
                case 4:
                    UpdateStudentData(con);
                    break;
                case 5:
                    DeleteStudentData(con);
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

        public static void SelectStudentData(SqlConnection con, string strSelectAllQuery)
        {
            SqlCommand cmd = new SqlCommand(strSelectAllQuery, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    int stuId = Convert.ToInt32(ds.Tables[0].Rows[i]["StudentId"].ToString());
                    string stuName = ds.Tables[0].Rows[i]["StudentName"].ToString();
                    string stuEmail = ds.Tables[0].Rows[i]["StudentEmail"].ToString();
                    int stuAge = Convert.ToInt32(ds.Tables[0].Rows[i]["StudentAge"].ToString());
                    string stuMobileNo = ds.Tables[0].Rows[i]["StudentMobileNo"].ToString();

                    Console.WriteLine("============================Customer Details============================");
                    Console.WriteLine($"Student ID: {stuId}   |   Student Name: {stuName}");
                    Console.WriteLine($"Student Email: {stuEmail}   |   Student Age: {stuAge}");
                    Console.WriteLine($"Student Mobile Number: {stuMobileNo}");
                    Console.WriteLine();
                }
            }
        }

        public static void SelectStudentDataWithId(SqlConnection con)
        {
            Console.WriteLine("Enter the Student Id: ");
            int stuId = Convert.ToInt32(Console.ReadLine());

            string strSelectOneQuery = "SelectStudentDetailsWithId";
            SqlCommand cmd = new SqlCommand(strSelectOneQuery, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StudentId", stuId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string stuName = ds.Tables[0].Rows[i]["StudentName"].ToString();
                    string stuEmail = ds.Tables[0].Rows[i]["StudentEmail"].ToString();
                    int stuAge = Convert.ToInt32(ds.Tables[0].Rows[i]["StudentAge"].ToString());
                    string stuMobileNo = ds.Tables[0].Rows[i]["StudentMobileNo"].ToString();

                    Console.WriteLine("============================Customer Details============================");
                    Console.WriteLine($"Student ID: {stuId}   |   Student Name: {stuName}");
                    Console.WriteLine($"Student Email: {stuEmail}   |   Student Age: {stuAge}");
                    Console.WriteLine($"Student Mobile Number: {stuMobileNo}");
                    Console.WriteLine();
                }
            }
        }

        public static void InsertStudentData(SqlConnection con)
        {
            Console.WriteLine("Enter the Student Name: ");
            string stuName = Console.ReadLine();
            Console.WriteLine("Enter the Student Email: ");
            string stuEmail = Console.ReadLine();
            Console.WriteLine("Enter the Student Age: ");
            int stuAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Mobile Number: ");
            string stuMobile = Console.ReadLine();

            string strInsertQuery = "InsertStudentDetails";
            try
            {
                SqlCommand cmd = new SqlCommand(strInsertQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Define the Parameters in long format
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@StudentName";
                parameter.SqlDbType = SqlDbType.VarChar;
                parameter.Value = stuName;
                cmd.Parameters.Add(parameter);

                //Define the Parameters in short format
                cmd.Parameters.AddWithValue("@StudentEmail", stuEmail);
                cmd.Parameters.AddWithValue("@StudentAge", stuAge);
                cmd.Parameters.AddWithValue("@StudentMobileNo", stuMobile);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    Console.WriteLine(i + "Data Inserted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void UpdateStudentData(SqlConnection con)
        { 
            SelectStudentDataWithId(con);

            Console.WriteLine("Do yo want to Update? Y/N");
            char ch1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Student Id that you Want to Update: ");
            int stuId = Convert.ToInt32(Console.ReadLine());
            if (ch1 == 'Y' || ch1 == 'y')
            {
                Console.WriteLine("Enter the Student Name: ");
                string stuName = Console.ReadLine();
                Console.WriteLine("Enter the Student Email: ");
                string stuEmail = Console.ReadLine();
                Console.WriteLine("Enter the Student Age: ");
                int stuAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Mobile Number: ");
                string stuMobile = Console.ReadLine();

                string strUpdateQuery = "UpdateStudentDetails";

                try
                {
                    SqlCommand cmd = new SqlCommand(strUpdateQuery, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentId", stuId);
                    cmd.Parameters.AddWithValue("@StudentName", stuName);
                    cmd.Parameters.AddWithValue("@StudentEmail", stuEmail);
                    cmd.Parameters.AddWithValue("@StudentAge", stuAge);
                    cmd.Parameters.AddWithValue("@StudentMobileNo", stuMobile);
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

        public static void DeleteStudentData(SqlConnection con)
        {
            SelectStudentDataWithId(con);

            Console.WriteLine("Do you want to delete? Y/N");
            char ch2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Customer Id record need to be deleted: ");
            int stuId = Convert.ToInt32(Console.ReadLine());
            if (ch2 == 'Y' || ch2 == 'y')
            {
                string strDeleteQuery = $"DeleteStudentDetails";
                try
                {
                    SqlCommand cmd = new SqlCommand(strDeleteQuery, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@StudentId", stuId);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i != 0)
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
    }
}
