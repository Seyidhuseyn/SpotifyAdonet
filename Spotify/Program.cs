using Spotify.Helper;
using Spotify.Models;
using Spotify.Services;

namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CRUD emeliyyatini hansi cedvel uzerinde aparacaqsiniz?");
            Console.WriteLine("1--Roles\n\n2--Users\n\n3--Categories\n\n4--Musics\n\n5--Playlists\n\n6--UserPlaylist\n\n7--Artists\n\n8--MusicArtists\n\n");

        repeat:
            Console.Write("Reqem daxil edin:");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Roles");
                    Roles();
                    goto repeat;
                    break;
                case 2:
                    Console.WriteLine("Users");
                    Users();
                    goto repeat;
                    break;
                case 3:
                    Console.WriteLine("Categories");
                    Categories();
                    goto repeat;
                    break;
                case 4:
                    Console.WriteLine("Musics");
                    goto repeat;
                    break;
                case 5:
                    Console.WriteLine("Playlists");
                    goto repeat;
                    break;
                case 6:
                    Console.WriteLine("UserPlaylist");
                    goto repeat;
                    break;
                case 7:
                    Console.WriteLine("Artists");
                    goto repeat;
                    break;
                case 8:
                    Console.WriteLine("MusicArtists");
                    goto repeat;
                    break;
                default:
                    Console.WriteLine("Duzgun reqem daxil edin");
                    goto repeat;
                    break;
            }
            

            //-----------------------Music hissesi----------------------------

            //MusicService serviceM = new MusicService();
            //Music seyid = new Music { Name = "istemirm", Duration = "03:34", Categories = 1 };
            //serviceM.Add(seyid);

            //serviceM.Delete(6);

            //foreach (var item in serviceM.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------------Playlists Hissesi-------------------------

            //PlaylistsService serviceP = new PlaylistsService();
            //Playlists ps = new Playlists { Musics = 1};
            //serviceP.Add(ps);

            //serviceP.Delete(1);

            //foreach (var item in serviceP.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //----------------------UserPlaylist Hissesi-----------------------

            //UserPlaylistService serviceUP = new UserPlaylistService();
            //UserPlaylist up = new UserPlaylist { Playlists = 1, Users = 1 };
            //serviceUP.Add(up);

            //serviceUP.Delete(1);

            //foreach (var item in serviceUP.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------------Artist hissesi----------------------------

            //ArtistService serviceA = new ArtistService();
            //Artist huseyn = new Artist { Name = "Thiss", Surname = "Hisss", Brithday = "11-10-2009", Gender = "Male" };
            //serviceA.Add(huseyn);

            //serviceA.Delete(2);

            //foreach (var item in serviceA.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //-----------------------MusicArtists Hissesi----------------------

            //MusicArtistsService serviceMA = new MusicArtistsService();
            //MusicArtists ma = new MusicArtists { Artists =1, Musics = 1};
            //serviceMA.Add(ma);

            //serviceMA.Delete(1);

            //foreach (var item in serviceMA.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

        }

        //----------------------Roles Hissesi-----------------------------
        static void Roles()
        {
        repeat:
            RolesService serviceR = new RolesService();
            Console.Write("Eded daxil edin:");
            int num2 = int.Parse(Console.ReadLine());
            switch (num2)
            {
                case 1:
                    Console.WriteLine("Create seçildi..\n");
                    Roles rs = new Roles { Type = "Moderator" };
                    serviceR.Add(rs);
                    break;
                case 2:
                    Console.WriteLine("Delete seçildi...");
                    serviceR.Delete(2);
                    break;
                case 3:
                    Console.WriteLine("GetAll seçildi...");
                    foreach (var item in serviceR.GetAll())
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Duzgun reqem daxil edin");
                    goto repeat;
                    break;
            }
        }

        //-----------------------Users Hissesi----------------------------
        static void Users()
        {
        repeat:
            UsersService serviceU = new UsersService();
            Console.Write("Eded daxil edin:");
            int num2 = int.Parse(Console.ReadLine());
            switch (num2)
            {
                case 1:
                    Console.WriteLine("Create seçildi..\n");
                    Users u = new Users { Name = "Seyidhuseyn", Surname = "Majidov", Username = "sey1dhuseyn", Password = "10fff774", Gender = "Male", Roles = 1 };
                    serviceU.Add(u);
                    break;
                case 2:
                    Console.WriteLine("Delete seçildi...");
                    serviceU.Delete(2);
                    break;
                case 3:
                    Console.WriteLine("GetAll seçildi...");
                    foreach (var item in serviceU.GetAll())
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Duzgun reqem daxil edin");
                    goto repeat;
                    break;
            }
        }

        //-----------------------Categories Hissesi------------------------
        static void Categories()
        {
        repeat:
            CategoriesService serviceC = new CategoriesService();
            Console.Write("Eded daxil edin:");
            int num2 = int.Parse(Console.ReadLine());
            switch (num2)
            {
                case 1:
                    Console.WriteLine("Create seçildi..\n");
                    Categories cs = new Categories { Name = "Hit" };
                    serviceC.Add(cs);
                    break;
                case 2:
                    Console.WriteLine("Delete seçildi...");
                    serviceC.Delete(2);
                    break;
                case 3:
                    Console.WriteLine("GetAll seçildi...");
                    foreach (var item in serviceC.GetAll())
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Duzgun reqem daxil edin");
                    goto repeat;
                    break;
            }
        }
    }
}