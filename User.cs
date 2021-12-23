using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pis
{
    class User
    {
        public int idUser;
        public string login;
        public string password;
        public string name;
        public string role;
        private User(List<string> data)
        {
            idUser = int.Parse(data[0]);
            login = data[1];
            password = data[2];
            name = data[3];
            role = GetRole(data[4]);
        }
        public static User LogIn(string login, string password)
        {
            Controller.connect.Open();

            string sql1 = @"select id_user, login, password, name, id_role from users where login='"+
                login+"' and password='"+password+"'";
            SqlCommand command = Controller.connect.CreateCommand();
            command.CommandText = sql1;
            SqlDataReader result = command.ExecuteReader();
            if (!result.HasRows) return null;
            var data = new List<string>();
            while (result.Read())
            {
                data.Add(result.GetValue(0).ToString());
                data.Add(result.GetValue(1).ToString());
                data.Add(result.GetValue(2).ToString());
                data.Add(result.GetValue(3).ToString());
                data.Add(result.GetValue(4).ToString());
            }
            return new User(data);
        }

        public string GetRole(string id_role)
        {
            string sql1 = @"select name from role where id_role=" + id_role;
            SqlCommand command = Controller.connect.CreateCommand();
            command.CommandText = sql1;
            string role = command.ExecuteScalar().ToString();

            Controller.connect.Close();

            return role;
        }
    }
}
