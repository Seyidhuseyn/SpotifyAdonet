namespace Spotify.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.TimeSpan Duration { get; set; }
        public int Categories { get; set; }
    }
}
