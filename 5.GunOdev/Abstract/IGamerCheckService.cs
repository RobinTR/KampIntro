using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5.GunOdev.Entities;

namespace _5.GunOdev.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIsGamerRealPerson(Gamer gamer);
    }
}
