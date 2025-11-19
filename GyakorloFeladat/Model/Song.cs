using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Song : IIdEntity
    {
        public Song(string artist, string title, int length, int likes)
        {
            Artist = artist;
            Title = title;
            Length = length;
            Likes = likes;
            Id = Guid.NewGuid().ToString();
        }
        public Song()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id {get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public int Likes { get; set; }
    }
}
