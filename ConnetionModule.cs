using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Jeep
{
    internal class ConnetionModule
    {
        public static MySqlConnection con = new MySqlConnection(
         "server=localhost;user id=root;password=;database=jeepney"
    );

        public static void openCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public static void closeCon()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }


    }
}
