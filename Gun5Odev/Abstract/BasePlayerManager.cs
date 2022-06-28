using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gun5Odev.Entities;

namespace Gun5Odev.Abstract
{
    public abstract class BasePlayerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" "+ gamer.LastName + " Kullanıcısı kaydedildi.");
        }

        public virtual void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " Kullanıcısı silindi.");
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" " + gamer.LastName + " Kullanıcısı güncellendi.");
        }
    }
}
