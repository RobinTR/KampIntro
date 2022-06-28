using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gun5Odev.Abstract;
using Gun5Odev.Entities;

namespace Gun5Odev.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " oyunu eklendi.");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.Name + " oyunu silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " oyunu güncellendi.");
        }
    }
}
