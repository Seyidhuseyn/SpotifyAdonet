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
    internal class MusicArtistsService : IService<MusicArtists>
    {
        public void Add(MusicArtists model)
        {
            Sql.ExecCommand($"INSERT INTO MusicArtists VALUES (N'{model.Artists}', '{model.Musics}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE MusicArtists WHERE Id = {id}");
        }
        public List<MusicArtists> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM MusicArtists");
            List<MusicArtists> musicartists = new List<MusicArtists>();
            foreach (DataRow dr in dt.Rows)
            {
                musicartists.Add(new MusicArtists { Id = Convert.ToInt32(dr["Id"]), Artists = Convert.ToInt32(dr["Artists"]), Musics = Convert.ToInt32(dr["Musics"]) });
            }
            return musicartists;
        }
    }
}
