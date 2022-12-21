using Spotify.Abstractions;
using Spotify.Helper;
using Spotify.Models;
using System.Data;

namespace Spotify.Services
{
    internal class MusicService : IService<Music>
    {
        public void Add(Music model)
        {
            Sql.ExecCommand($"INSERT INTO Musics VALUES (N'{model.Name}', N'{model.Duration}', {model.Categories})");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Musics WHERE Id = {id}");
        }
        public List<Music> GetAll()
        {
          DataTable dt = Sql.ExecQuery("SELECT * FROM Musics");
            List<Music> musics = new List<Music>();
            foreach (DataRow dr in dt.Rows)
            {
                musics.Add(new Music {Id = Convert.ToInt32(dr["Id"]), Name = dr["Name"].ToString(), Duration = (dr["Duration"]).ToString(), Categories = Convert.ToInt32(dr["Categories"]) });
            }
            return musics;
        }
    }
}
