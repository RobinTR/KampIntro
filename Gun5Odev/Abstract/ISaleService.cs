using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gun5Odev.Entities;

namespace Gun5Odev.Abstract
{
    public interface ISaleService
    {
        void Save(Gamer gamer,Game game,Offer offer);
        void Save(Gamer gamer,Game game);
    }
}
