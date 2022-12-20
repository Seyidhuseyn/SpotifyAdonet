using Spotify.Helper;
using Spotify.Models;
using Spotify.Services;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Music hissesi----------------------------

            MusicService serviceM = new MusicService();
            Music seyid = new Music { Name = "Isteyirem", Categories = 1 };
            serviceM.Add(seyid);

            //serviceM.Delete(6);

            //foreach (var item in serviceM.GetAll())
            //{
            //    Console.WriteLine(item);
            //}



            //-----------------------Artist hissesi----------------------------

            //ArtistService serviceA = new ArtistService();
            //Artist huseyn = new Artist {Name = "This", Surname = "Hiss", Gender = "Male"};
            //serviceA.Add(huseyn);

            //serviceA.Delete(2);

            //foreach (var item in serviceA.GetAll())
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}