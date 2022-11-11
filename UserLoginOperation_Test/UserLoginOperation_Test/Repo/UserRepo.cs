using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using UserLoginOperation_Test.Models;
using UserLoginOperation_Test.Utility;

namespace UserLoginOperation_Test.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly string insertSql = "insert into [dbo].[user] ([user_login], [user_password], [user_email]) values (@login, @password, @email)";//,@role_id)";
        private readonly string deleteSql = "DELETE FROM [dbo].[user] WHERE user_id = @userId";
        private readonly string getIdFomLoginSql = "SELECT user_id FROM [dbo].[user] WHERE user_login = @login";
        private readonly string getIdFromSql = "SELECT user_login FROM [dbo].[user] WHERE user_login = @login";
        public void Create(User user)
        {
            DatabaseConnector.Connection.Open();

            using (var cmd = new SqlCommand(insertSql, DatabaseConnector.Connection))
            {
                SqlParameter loginParam = cmd.CreateParameter();
                loginParam.ParameterName = "@login";
                loginParam.Value = user.UserLogin;

                SqlParameter passwordParam = cmd.CreateParameter();
                passwordParam.ParameterName = "@password";
                passwordParam.Value = user.UserPassword;

                SqlParameter emailParam = cmd.CreateParameter();
                emailParam.ParameterName = "@email";
                emailParam.Value = user.UserEmail;

                cmd.Parameters.Add(loginParam);
                cmd.Parameters.Add(passwordParam);
                cmd.Parameters.Add(emailParam);

                //SqlParameter roleIdParam = cmd.CreateParameter();
                //roleIdParam.ParameterName = "role_id";
                //roleIdParam.Value = user.UserRole.RoleId;

                cmd.ExecuteNonQuery();
            }

            DatabaseConnector.Connection.Close();
        }

        public void Delete(Guid userId)
        {
            DatabaseConnector.Connection.Open();
            using (var cmd = new SqlCommand(deleteSql, DatabaseConnector.Connection))
            {
                SqlParameter userParam = cmd.CreateParameter();
                userParam.ParameterName = "@userId";
                userParam.Value = userId;
                cmd.Parameters.Add(userParam);
                cmd.ExecuteNonQuery();
            }
            DatabaseConnector.Connection.Close();

        }

        public User Get(Guid userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
        public Guid GetIdByLogin(string login)
        {
            DatabaseConnector.Connection.Open();
            using (var cmd = new SqlCommand(getIdFomLoginSql, DatabaseConnector.Connection))
            {
                SqlParameter loginParam = cmd.CreateParameter();
                loginParam.ParameterName = "@login";
                loginParam.Value = login;
                cmd.Parameters.Add(loginParam);
                var reader = cmd.ExecuteReader();
                reader.Read();
                var id = reader["user_id"];
                DatabaseConnector.Connection.Close();
                return (Guid)id;
            }            
        }
        public void ValidateUserLogin(string login)
        {
            DatabaseConnector.Connection.Open();
            using (var cmd = new SqlCommand(getIdFromSql, DatabaseConnector.Connection))
            {
                SqlParameter loginParam = cmd.CreateParameter();
                loginParam.ParameterName = "@login";
                loginParam.Value = login;
                cmd.Parameters.Add(loginParam);
                SqlDataAdapter sda = null;
                DataTable Dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(Dt);
                if (Dt.Rows.Count > 0)
                {
                    throw new Exception("Этот логин уже занят!");
                }
            }
        }
    }
}
