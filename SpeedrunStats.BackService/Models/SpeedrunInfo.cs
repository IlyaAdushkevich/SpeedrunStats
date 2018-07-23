using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedrunStats.BackService.Models
{
    public class SpeedrunInfo
    {

        public int  Id { get; set; }

        public string GameId { get; set; }

        public string UserId { get; set; }

        public string Type { get; set; }

        public string Time { get; set; }


    }
}
