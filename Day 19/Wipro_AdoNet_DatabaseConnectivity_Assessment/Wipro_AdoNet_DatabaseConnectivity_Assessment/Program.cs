using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Wipro_AdoNet_DatabaseConnectivity_Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=Wipro_21_08_2024;Integrated Security=True");
        start:
            string selectAllQueryEmp = "SelectEmployeeDetails";
            string selectAllQueryCust = "SelectCustomerDetails";
            Console.WriteLine("Enter which Query you want to perform\n1.Select\n2.Insert\n3.Update\n4.Delete\n5.Inner Join");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Choose  1.Employee Details \n2.Customer Details");
                    int ch1 = Convert.ToInt32(Console.ReadLine());
                    if (ch1 == 1)
                        SelectEmployeeData(con, selectAllQueryEmp);
                    else if (ch1 == 2)
                        SelectCustomerData(con, selectAllQueryCust);
                    break;
                case 2:
                    Console.WriteLine("Choose\n1.Insert Employee Details\n2.Insert Customer Details");
                    int ch2 = Convert.ToInt32(Console.ReadLine());
                    if (ch2 == 1)
                        InsertEmployeeData(con);
                    else if (ch2 == 2)
                        InsertCustomerData(con);
                    break;
                case 3:
                    Console.WriteLine("Choose\n1.Update Employee Details\n2.Update Customer Details");
                    int ch3 = Convert.ToInt32(Console.ReadLine());
                    if (ch3 == 1)
                        UpdateEmployeeData(con);
                    else if (ch3 == 2)
                        UpdateCustomerData(con);
                    break;
                case 4:
                    Console.WriteLine("Choose\n1.Delete Employee Details\n2.Delete Customer Details");
                    int ch4 = Convert.ToInt32(Console.ReadLine());
                    if (ch4 == 1)
                        DeleteEmployeeData(con);
                    else if (ch4 == 2)
                        DeleteCustomerData(con);
                    break;
                case 5:
                    InnerJoinData(con);
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

        public static void SelectEmployeeData(SqlConnection conn, string strSelectAllQuery)
        {
            List<Employee> employeeList = new List<Employee>();

            SqlCommand cmd = new SqlCommand(strSelectAllQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Employee objEmployee = new Employee();
                    objEmployee.EmpId = Convert.ToInt32(ds.Tables[0].Rows[i]["EmpId"].ToString());
                    objEmployee.EmpName = ds.Tables[0].Rows[i]["EmpName"].ToString();
                    objEmployee.EmpAge = Convert.ToInt32(ds.Tables[0].Rows[i]["EmpAge"].ToString());
                    objEmployee.EmpSal = Convert.ToDecimal(ds.Tables[0].Rows[i]["EmpSal"].ToString());
                    objEmployee.EmpCity = ds.Tables[0].Rows[i]["EmpCity"].ToString();
                    objEmployee.EmpEmail = ds.Tables[0].Rows[i]["EmpEmail"].ToString();
                    objEmployee.EmpQualification = ds.Tables[0].Rows[i]["EmpQualification"].ToString();
                    objEmployee.DeptId = Convert.ToInt32(ds.Tables[0].Rows[i]["DeptId"].ToString());

                    employeeList.Add(objEmployee);

                    foreach (var employee in employeeList)
                    {
                        Console.WriteLine("==============================Employee Details==============================");
                        Console.WriteLine($"Employee Id: {objEmployee.EmpId}   |   Employee Name: {objEmployee.EmpName}");
                        Console.WriteLine($"Employee Age: {objEmployee.EmpAge}   |   Employee Salary: {objEmployee.EmpSal}");
                        Console.WriteLine($"Employee Email: {objEmployee.EmpEmail}   |   Employee Qualification: {objEmployee.EmpQualification}");
                        Console.WriteLine($"Employee City: {objEmployee.EmpCity}   |   Department ID: {objEmployee.DeptId}");
                        Console.WriteLine();
                    }

                }
            }
        }

        public static void InnerJoinData(SqlConnection conn)
        {
            Console.WriteLine("Enter the Employee Id for Inner Join: ");
            int empId = Convert.ToInt32(Console.ReadLine());

            string strQuery = "InnerJoin";
            try
            {
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", empId);
                conn.Open();
                var read = cmd.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine("==============================Employee Details==============================");
                    Console.WriteLine($"Employee Id: {read["EmpId"]}   |   Employee Name: {read["EmpName"]}");
                    Console.WriteLine($"Employee Age: {read["EmpAge"]}   |   Employee Salary: {read["EmpSal"]}");
                    Console.WriteLine($"Employee Email: {read["EmpEmail"]}   |   Employee Qualification: {read["EmpQualification"]}");
                    Console.WriteLine($"Employee City: {read["EmpCity"]}");
                    Console.WriteLine("==============================Department Details==============================");
                    Console.WriteLine($"Department ID: {read["DeptId"]}   |   Department Name: {read["DeptName"]}");
                    Console.WriteLine();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void InsertEmployeeData(SqlConnection conn)
        {
            Console.WriteLine("Enter the Employee Name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Age: ");
            int empAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary: ");
            decimal empSal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee City: ");
            string empCity = Console.ReadLine();
            Console.WriteLine("Enter the Employee Email: ");
            string empEmail = Console.ReadLine();
            Console.WriteLine("Enter the Employee Qualification: ");
            string empQuali = Console.ReadLine();

            string strInsertQuery = $"InsertEmployeeDetails";

            try
            {
                SqlCommand cmd = new SqlCommand(strInsertQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpName", empName);
                cmd.Parameters.AddWithValue("@EmpAge", empAge);
                cmd.Parameters.AddWithValue("@EmpSal", empSal);
                cmd.Parameters.AddWithValue("@EmpCity", empCity);
                cmd.Parameters.AddWithValue("@EmpEmail", empEmail);
                cmd.Parameters.AddWithValue("@EmpQualification", empQuali);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
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

        public static void UpdateEmployeeData(SqlConnection conn)
        {
            Console.WriteLine("Enter the Employee Id: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            string selectOneQuery = $"Select * from Employee Where EmpId = {empId}";
            SelectEmployeeData(conn, selectOneQuery);

            Console.WriteLine("Do yo want to Update? Y/N");
            char ch1 = Convert.ToChar(Console.ReadLine());
            if (ch1 == 'Y' || ch1 == 'y')
            {
                Console.WriteLine("Enter the Employee Name: ");
                string empName = Console.ReadLine();
                Console.WriteLine("Enter the Employee Age: ");
                int empAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Salary: ");
                decimal empSal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee City: ");
                string empCity = Console.ReadLine();
                Console.WriteLine("Enter the Employee Email: ");
                string empEmail = Console.ReadLine();
                Console.WriteLine("Enter the Employee Qualification: ");
                string empQuali = Console.ReadLine();
                Console.WriteLine("Enter the Department ID: ");
                int deptId = Convert.ToInt32(Console.ReadLine());

                string strUpdateQuery = "UpdateEmployeeDetails";

                try
                {
                    SqlCommand cmd = new SqlCommand(strUpdateQuery, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    cmd.Parameters.AddWithValue("@EmpName", empName);
                    cmd.Parameters.AddWithValue("@EmpAge", empAge);
                    cmd.Parameters.AddWithValue("@EmpSal", empSal);
                    cmd.Parameters.AddWithValue("@EmpCity", empCity);
                    cmd.Parameters.AddWithValue("@EmpEmail", empEmail);
                    cmd.Parameters.AddWithValue("@EmpQualification", empQuali);
                    cmd.Parameters.AddWithValue("@DeptId", deptId);
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
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

        public static void DeleteEmployeeData(SqlConnection conn)
        {
            Console.WriteLine("Enter the Employee Id record need to be deleted: ");
            int empId = Convert.ToInt32(Console.ReadLine());
            string selectOneQuery = $"Select * from Employee Where EmpId = {empId}";
            SelectEmployeeData(conn, selectOneQuery);

            Console.WriteLine("Do you want to delete? Y/N");
            char ch2 = Convert.ToChar(Console.ReadLine());
            if (ch2 == 'Y' || ch2 == 'y')
            {
                string strDeleteQuery = "DeleteEmployeeDetails";
                try
                {
                    SqlCommand cmd = new SqlCommand(strDeleteQuery, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
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

        public static void SelectCustomerData(SqlConnection con, string strSelectAllQuery)
        {
            List<Customer> customerList = new List<Customer>();

            SqlCommand cmd = new SqlCommand(strSelectAllQuery, con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Customer objCustomer = new Customer();
                    objCustomer.CustId = Convert.ToInt32(ds.Tables[0].Rows[i]["CustId"].ToString());
                    objCustomer.CustName = ds.Tables[0].Rows[i]["CustName"].ToString();
                    objCustomer.CustAddress = ds.Tables[0].Rows[i]["CustAddress"].ToString();
                    objCustomer.CustCountry = ds.Tables[0].Rows[i]["CustomerCountry"].ToString();

                    customerList.Add(objCustomer);

                    foreach (var customer in customerList)
                    {
                        Console.WriteLine("============================Customer Details============================");
                        Console.WriteLine($"Customer ID: {objCustomer.CustId}   |   Customer Name: {objCustomer.CustName}");
                        Console.WriteLine($"Customer Address: {objCustomer.CustAddress}   |   Customer Country: {objCustomer.CustCountry}");
                        Console.WriteLine();
                    }
                }
            }
        }

        public static void InsertCustomerData(SqlConnection conn)
        {
            Console.WriteLine("Enter the Customer Name: ");
            string custName = Console.ReadLine();
            Console.WriteLine("Enter the Customer Address: ");
            int custAddress = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer Country: ");
            string custCountry = Console.ReadLine();

            string strInsertQuery = $"InsertCustomerDetails";

            try
            {
                SqlCommand cmd = new SqlCommand(strInsertQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustName", custName);
                cmd.Parameters.AddWithValue("@CustAddress", custAddress);
                cmd.Parameters.AddWithValue("@CustomerCountry", custCountry);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
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

        public static void UpdateCustomerData(SqlConnection conn)
        {
            Console.WriteLine("Enter the Customer Id: ");
            int custId = Convert.ToInt32(Console.ReadLine());
            string selectOneQuery = $"Select * from Customer Where CustId = {custId}";
            SelectEmployeeData(conn, selectOneQuery);

            Console.WriteLine("Do yo want to Update? Y/N");
            char ch1 = Convert.ToChar(Console.ReadLine());
            if (ch1 == 'Y' || ch1 == 'y')
            {
                Console.WriteLine("Enter the Customer Name: ");
                string custName = Console.ReadLine();
                Console.WriteLine("Enter the Customer Address: ");
                int custAddress = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Customer Country: ");
                string custCountry = Console.ReadLine();

                string strUpdateQuery = "UpdateCustomerDetails";

                try
                {
                    SqlCommand cmd = new SqlCommand(strUpdateQuery, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CustId", custId);
                    cmd.Parameters.AddWithValue("@CustName", custName);
                    cmd.Parameters.AddWithValue("@CustAddress", custAddress);
                    cmd.Parameters.AddWithValue("@CustomerCountry", custCountry);
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
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

        public static void DeleteCustomerData(SqlConnection conn)
        {
            Console.WriteLine("Enter the Customer Id record need to be deleted: ");
            int custId = Convert.ToInt32(Console.ReadLine());
            string selectOneQuery = $"Select * from Customer Where CustId = {custId}";
            SelectEmployeeData(conn, selectOneQuery);

            Console.WriteLine("Do you want to delete? Y/N");
            char ch2 = Convert.ToChar(Console.ReadLine());
            if (ch2 == 'Y' || ch2 == 'y')
            {
                string strDeleteQuery = "DeleteCustomerDetails";
                try
                {
                    SqlCommand cmd = new SqlCommand(strDeleteQuery, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CustId", custId);
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
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
