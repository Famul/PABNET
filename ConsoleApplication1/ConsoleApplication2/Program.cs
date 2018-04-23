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
            SqlConnection remoteConection = 
                new SqlConnection(ConfigurationManager.AppSettings["sqlconnectionstring"]);


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

            Console.ReadKey();
        }
        private static void StateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("{0}: {1}", "Connection State", e.CurrentState.ToString());
            MessageBox.Show("Connection State: " + e.CurrentState.ToString(), "Komunikacik");
        }
    }
}
