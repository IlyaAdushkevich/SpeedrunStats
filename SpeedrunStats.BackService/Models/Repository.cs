using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedrunStats.BackService.Models
{
    public class Repository
    {

        private List<Game> Games = new List<Game>
        {
            new Game
            {
                Id=1,
                Name="Hollow Knight",
                imageUrl="https://static-cdn.jtvnw.net/ttv-boxart/Hollow%20Knight-80x107.jpg",
                ReleaseDate=new DateTime(2017,02,24)
            },
            new Game
            {
                Id=2,
                Name="Dark Souls 3",
                imageUrl="https://static-cdn.jtvnw.net/ttv-boxart/Dark%20Souls%20III-80x107.jpg",
                ReleaseDate=new DateTime(2016,03,24)
            },
            new Game
            {
                Id=3,
                Name="Celeste",
                imageUrl="https://static-cdn.jtvnw.net/ttv-boxart/Celeste-80x107.jpg",
                ReleaseDate=new DateTime(2018,01,25)
            }
        };

        public List<Game> Get()
        {
            return Games;
        }

        public Game Get(int id)
        {
            return Games.FirstOrDefault(t=> t.Id == id);
        }

        public void Add(Game newGame)
        {
            Games.Add(newGame);
        }

        public void Update(Game gameToUpdate)
        {
            Games.Remove(Games.First(t => t.Id == gameToUpdate.Id));
            Add(gameToUpdate);
        }

        public void Remove(int id)
        {
            Games.Remove(Games.First(t => t.Id == id));
        }
    }
}
