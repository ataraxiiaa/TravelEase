using System;

namespace TravelEase
{
    public static class ConnectionHelper
    {
        // Static method to return the connection string
        public static string GetConnectionString()
        {
            return "Data Source=ALI\\SQLEXPRESS;Initial Catalog=tourismDatabase;Integrated Security=True";
        }
    }
}
