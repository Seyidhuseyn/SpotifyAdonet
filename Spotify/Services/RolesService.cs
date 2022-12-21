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
    internal class RolesService : IService<Roles>
    {
        public void Add(Roles model)
        {
            Sql.ExecCommand($"INSERT INTO Roles VALUES (N'{model.Type}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Roles WHERE Id = {id}");
        }
        public List<Roles> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Roles");
            List<Roles> roles = new List<Roles>();
            foreach (DataRow dr in dt.Rows)
            {
                roles.Add(new Roles { Id = Convert.ToInt32(dr["Id"]), Type = dr["Name"].ToString() });
            }
            return roles;
        }
    }
}
