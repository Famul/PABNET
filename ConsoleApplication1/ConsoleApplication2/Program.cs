using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;



namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start App2");
            SqlConnection remoteConnection = 
                new SqlConnection(ConfigurationManager.AppSettings["sqlconnectionstring"]);

            try
            {
                remoteConnection.StateChange += new StateChangeEventHandler(StateChange);
                remoteConnection.Open();
                SqlCommand cmd2 = remoteConnection.CreateCommand();
                cmd2.CommandText = "select categoryid, categoryname from Categories order by 1";
                SqlDataReader reader = cmd2.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader.GetString(1));
                }
                reader.Close();

                cmd2.CommandText = "select productid, productname, unitprice, unitsinstock " +
                    "from products order by 1";
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader[0], reader[1], reader[2], reader[3]);
                }
                reader.Close();
                cmd2.CommandText = "select p.productid, p.productname, p.unitprice, p.unitsinstock, c.categoryname " +
                    "from products p join categories c on p.categoryid=c.categoryid order by 3";
                reader = cmd2.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("{0, 5}\t{1, -40}\t{2, 10}\t{3, 10}\t{4, -30}", reader["productid"], reader["productname"], 
                        reader["unitprice"], reader["unitsinstock"], reader["categoryname"]);
                }
                reader.Close();
                cmd2.CommandText = "select * from produkty_view order by 1";
                reader = cmd2.ExecuteReader();
                Console.WriteLine("{0, -20}{1, -40}{2, -20}{3, -20}{4, -30}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3), reader.GetName(4));
                while(reader.Read())
                {
                    Console.WriteLine("{0, -20}{1, -40}{2, -20}{3, -20}{4, -30}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
                reader.Close();

                cmd2.CommandText = "select categoryid, categoryname from Categories order by 1;" +
                    "select employeeid, lastname from employees;" +
                    "select year(getdate()), 'rok'";
                reader = cmd2.ExecuteReader();
                while(reader.HasRows)
                {
                    Console.WriteLine("{0, -20}\t{1, -30}", reader.GetName(0), reader.GetName(1));
                    while (reader.Read())
                    {
                        Console.WriteLine("{0, -20}\t{1, -30}", reader[0], reader[1]);
                    }
                    Console.WriteLine("\n");
                    reader.NextResult();

                }
                reader.Close();

                cmd2.CommandText = "insert into employees(lastname, firstname, title, titleofcourtesy) values('Marecki', 'Jan','Dyrektor','Mr'), ('Ma', 'Jan','Dyr','Mr'), " +
                    "('Maru', 'Mar','Prof','Mrs'), ('M', 'J','DJ','Mr')";
                int rowsInserted = cmd2.ExecuteNonQuery();
                Console.WriteLine("Wstawiono: {0}", rowsInserted);
                cmd2.CommandText = "update employees set lastname = 'Maraaaaa' where employeeid = 11";
                int rowsUpdated = cmd2.ExecuteNonQuery();
                Console.WriteLine("Zmieniono: {0}", rowsUpdated);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                remoteConnection.Close();
            }

            Console.ReadKey();
        }
        private static void StateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("{0}: {1}", "Connection State", e.CurrentState.ToString());
            MessageBox.Show("Connection State: " + e.CurrentState.ToString(), "Komunikacik");
        }
    }
}
