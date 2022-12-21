using Spotify.Abstractions;
using Spotify.Helper;
using Spotify.Models;
using System.Data;

namespace Spotify.Services
{
    internal class ArtistService : IService<Artist>
    {
        public void Add(Artist model)
        {
            Sql.ExecCommand($"INSERT INTO Artists VALUES (N'{model.Name}', N'{model.Surname}', N'{model.Brithday}', N'{model.Gender}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Artists WHERE Id = {id}");
        }
        public List<Artist> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Artists");
            List<Artist> artists = new List<Artist>();
            foreach (DataRow dr in dt.Rows)
            {
                artists.Add(new Artist { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Surname = dr["Surname"].ToString(), Brithday = dr["Brithday"].ToString(), Gender = dr["Gender"].ToString() });
            }
            return artists;
        }
    }
}
