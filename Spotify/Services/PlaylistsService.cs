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
    internal class PlaylistsService : IService<Playlists>
    {
        public void Add(Playlists model)
        {
            Sql.ExecCommand($"INSERT INTO Playlists VALUES (N'{model.Musics}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE Playlists WHERE Id = {id}");
        }
        public List<Playlists> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM Playlists");
            List<Playlists> playlists = new List<Playlists>();
            foreach (DataRow dr in dt.Rows)
            {
                playlists.Add(new Playlists { Id = Convert.ToInt32(dr["Id"]), Musics = Convert.ToInt32(dr["Musics"]) });
            }
            return playlists;
        }
    }
}
