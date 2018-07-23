using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedrunStats.BackService.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string imageUrl { get; set; }

        public DateTime ReleaseDate { get; set; }



    }
}
