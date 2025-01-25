using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Wipro_ECommerceApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=WiproDFA_26_08_2024;Integrated Security=True");
        start:
            InnerJoinData(con);
            
            Console.ReadLine();
            goto start;
        }

        public static void InnerJoinData(SqlConnection conn)
        {
            Console.WriteLine("Enter the Customer Id for Inner Join: ");
            int custId = Convert.ToInt32(Console.ReadLine());

            string strQuery = "InnerJoin";
            try
            {
                SqlCommand cmd = new SqlCommand(strQuery, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerId", custId);
                conn.Open();

                Console.WriteLine("+-------------------------------------------------------------------------------------------------------------------------------------------------+");
                Console.WriteLine("| Customer Id | Customer Name  |    Customer Email    |  Customer Order History  |  Customer Reviews  |       Order Products       |  Total Amount|");
                Console.WriteLine("|-------------|----------------|----------------------|--------------------------|--------------------|----------------------------|--------------|");
                var read = cmd.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine($"|{read["CustomerId"]}             {read["CustomerName"]}            {read["CustomerEmail"]}             {read["CustomerOrderHistory"]}                 {read["Reviews"]}              {read["OrderedProducts"]}      " + 
                                      $"           {read["TotalAmount"]}");
                    /*Console.WriteLine("==============================Customer Details==============================");
                    Console.WriteLine($"Customer Id: {read["CustomerId"]}   |   Customer Name: {read["CustomerName"]}");
                    Console.WriteLine($"Customer Email: {read["CustomerEmail"]}   |   Customer Order History: {read["CustomerOrderHistory"]}");
                    Console.WriteLine($"Customer Reviews: {read["Reviews"]}");
                    Console.WriteLine("==============================Order Details==============================");
                    Console.WriteLine($"Order Products: {read["OrderedProducts"]}   |   Order Date: {read["OrderDate"]}");
                    Console.WriteLine($"Order Total Amount: {read["TotalAmount"]}");
                    Console.WriteLine();*/

                    //Console.WriteLine("|     " + $"{read["CustomerId"]}" + "       |    {read["CustomerName"]}      |   {read["CustomerEmail"]}   |       {read["CustomerOrderHistory"]}       |         {read["Reviews"]}          | {read["OrderedProducts"]}  |   {read["TotalAmount"]}");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
