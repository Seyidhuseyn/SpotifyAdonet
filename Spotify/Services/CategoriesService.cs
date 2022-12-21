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
    internal class CategoriesService : IService<Categories>
    {
        public void Add(Categories model)
        {
            Sql.ExecCommand($"INSERT INTO Categories VALUES (N'{model.Name}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Categories WHERE Id = {id}");
        }
        public List<Categories> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Categories");
            List<Categories> categories = new List<Categories>();
            foreach (DataRow dr in dt.Rows)
            {
                categories.Add(new Categories { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString() });
            }
            return categories;
        }
    }
}
