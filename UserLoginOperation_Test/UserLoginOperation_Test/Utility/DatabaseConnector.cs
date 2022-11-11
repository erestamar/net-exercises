using System.Data.SqlClient;

namespace UserLoginOperation_Test.Utility
{
    public static class DatabaseConnector
    {
        private static SqlConnection? _sqlConnection;

        public static SqlConnection Connection 
        { 
            get
            {
                if (_sqlConnection is not null)
                {
                    return _sqlConnection;
                }

                var datasource = @"(localdb)\MSSQLLocalDB";
                var database = "UserLoginOperation_Test";
                var connString = "Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True";
                var connection = new SqlConnection(connString);
                _sqlConnection = connection;

                return connection;
            }
        }
    }
}
