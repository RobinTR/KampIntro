using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Gun5Odev.Abstract;
using Gun5Odev.Entities;

namespace Gun5Odev.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Save(Gamer gamer, Game game, Offer offer)
        {
            Console.WriteLine(game.Name + " oyunu indirimli satılmıştır.");
        }

        public void Save(Gamer gamer, Game game)
        {
            Console.WriteLine(game.Name + " oyunu satılmıştır.");
        }
    }
}
