using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start App1");
            // SqlConnection localConection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"c:\\users\\187684\\documents\\visual studio 2015\\Projects\\ConsoleApplication1\\ConsoleApplication1\\DB1.mdf\"; Integrated Security = True");
            //SqlConnection localConection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\187684\Documents\Visual Studio 2015\Projects\ConsoleApplication1\ConsoleApplication1\DB1.mdf'; Integrated Security = True");
            //AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\187684\Documents\Visual Studio 2015\Projects\ConsoleApplication1\ConsoleApplication1");
            SqlConnection localConection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\DB1.mdf; Integrated Security = True");
            
            SqlConnection remoteConection = new SqlConnection("Data Source=IBM-13;Initial Catalog=Northwind;User ID=SA;Password=praktyka");

           

            try
            {
                localConection.StateChange += new StateChangeEventHandler(StateChange);
                localConection.Open();
                SqlCommand cmd1 = localConection.CreateCommand();
                cmd1.CommandText = "drop table a; drop table b";
                cmd1.ExecuteNonQuery();
                cmd1.CommandText = "Create table a(a1 int); insert into a values (1),(2),(3)";
                cmd1.ExecuteNonQuery();
                cmd1.CommandText = "begin create table b(a1 int); insert into b values (4),(5),(6); end;";
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                localConection.Close();
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "IBM-13";
            builder.InitialCatalog = "Northwind";
            builder.ConnectTimeout = 5;
            Console.Write("Nazwa uzytkownika: ");
            builder.UserID = Console.ReadLine();
            Console.Write("Haslo: ");
            builder.Password = Console.ReadLine();
            remoteConection = new SqlConnection(builder.ConnectionString);
            Console.WriteLine("Connection timeout: {0}s", remoteConection.ConnectionTimeout);

            try
            {
                remoteConection.StateChange += new StateChangeEventHandler(StateChange);
                remoteConection.Open();
                SqlCommand cmd2 = remoteConection.CreateCommand();
                cmd2.CommandText = "drop table a; drop table b";
                cmd2.ExecuteNonQuery();
                cmd2.CommandText = "Create table a(a1 int); insert into a values (1),(2),(3)";
                cmd2.ExecuteNonQuery();
                cmd2.CommandText = "begin create table b(a1 int); insert into b values (4),(5),(6); end;";
                cmd2.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                remoteConection.Close();
            }
            //con.Dispose();
            Console.ReadKey();
        }

        private static void StateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("{0}: {1}", "Connection State", e.CurrentState.ToString());
            MessageBox.Show("Connection State: " + e.CurrentState.ToString(), "Komunikacik");
        }
    }
}
