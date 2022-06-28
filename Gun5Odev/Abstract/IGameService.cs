using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gun5Odev.Entities;

namespace Gun5Odev.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Remove(Game game);
        void Update(Game game);
    }
}
