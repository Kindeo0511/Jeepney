using System;
using MySql.Data.MySqlClient;

namespace Jeep
{
    internal static class AuditHelper
    {
        private static string connectionString = "server=localhost;user id=root;password=;database=jeepney;";

        public static void Log(string username, string role, string actionType, string moduleName, string description)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO audit_trail (Username, Role, ActionType, ModuleName, Description, ActionDate)
                                 VALUES (@Username, @Role, @ActionType, @ModuleName, @Description, NOW())";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@ActionType", actionType);
                    cmd.Parameters.AddWithValue("@ModuleName", moduleName);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
