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
    internal class UserPlaylistService : IService<UserPlaylist>
    {
        public void Add(UserPlaylist model)
        {
            Sql.ExecCommand($"INSERT INTO UserPlaylist VALUES (N'{model.Playlists}', '{model.Users}')");
        }
        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE UserPlaylist WHERE Id = {id}");
        }
        public List<UserPlaylist> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT * FROM UserPlaylist");
            List<UserPlaylist> userplaylists = new List<UserPlaylist>();
            foreach (DataRow dr in dt.Rows)
            {
                userplaylists.Add(new UserPlaylist { Id = Convert.ToInt32(dr["Id"]), Playlists = Convert.ToInt32(dr["Musics"]), Users = Convert.ToInt32(dr["Users"]) });
            }
            return userplaylists;
        }
    }

}
