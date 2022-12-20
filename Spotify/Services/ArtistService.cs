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
            Sql.ExecCommand($"INSERT INTO Musics VALUES (N'{model.Name}', N'{model.Surname}', {model.Gender})");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Musics WHERE Id = {id}");
        }
        public List<Artist> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Musics");
            List<Artist> artists = new List<Artist>();
            foreach (DataRow dr in dt.Rows)
            {
                artists.Add(new Artist { Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), /*Duration = Convert.ToInt32(dr["Duration"]),*/ Gender = dr["Gender"].ToString() });
            }
            return artists;
        }
    }
}
