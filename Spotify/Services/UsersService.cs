using Spotify.Abstractions;
using Spotify.Helper;
using Spotify.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Services
{
    internal class UsersService : IService<Users>
    {
        public void Add(Users model)
        {
            Sql.ExecCommand($"INSERT INTO Users VALUES (N'{model.Name}', N'{model.Surname}', N'{model.Username}', N'{model.Password}', N'{model.Gender}', N'{model.Roles}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Users WHERE Id = {id}");
        }
        public List<Users> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Users");
            List<Users> users = new List<Users>();
            foreach (DataRow dr in dt.Rows)
            {
                users.Add(new Users { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Surname = dr["Surname"].ToString(), Username = dr["Username"].ToString(), Password = dr["Password"].ToString(), Gender = dr["Gender"].ToString(), Roles = Convert.ToInt32(dr["Roles"]) });
            }
            return users;
        }
    }
}
