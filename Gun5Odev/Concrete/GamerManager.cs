using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gun5Odev.Abstract;
using Gun5Odev.Entities;

namespace Gun5Odev.Concrete
{
    public class GamerManager : BasePlayerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                Console.WriteLine("Geçersiz kullanıcı bilgileri.");
            }

        }
    }
}
