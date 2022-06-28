using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gun5Odev.Abstract;
using Gun5Odev.Entities;

namespace Gun5Odev.Concrete
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.Name + " kampanyası oluşturuldu.");
        }

        public void Remove(Offer offer)
        {
            Console.WriteLine(offer.Name + " kampanyası silindi.");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine(offer.Name + " kampanyası güncellendi.");
        }
    }
}
