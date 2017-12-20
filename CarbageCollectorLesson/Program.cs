using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbageCollectorLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> list = new List<User>();

            for(int i = 0;i< 100000000;i++)
            {
                list.Add(new User { Login = "admin" + i, Password = "" + i});
                Console.WriteLine(GC.GetGeneration(new User { Login = "admin" + i, Password = "" + i }));
            }

            for (int i = 0; i < 100000000; i++)
            {
                list.RemoveAt(i);
            }
            using (SqlConnection connection = new SqlConnection())
            {
                connection.Close();
            }
        }
    }
}
