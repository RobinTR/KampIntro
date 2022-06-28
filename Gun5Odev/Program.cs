using Gun5Odev.Abstract;
using Gun5Odev.Adapter;
using Gun5Odev.Concrete;
using Gun5Odev.Entities;

namespace Gun5Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasePlayerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer() { DateOfBirth = new DateTime(1999, 02, 25), FirstName = "Mem Robin", LastName = "Çen", NationalityId = "20000000002" });

            Gamer gamer = new Gamer()
            {
                FirstName = "Sadsadf", LastName = "dgfhdgfh", DateOfBirth = new DateTime(1983, 1, 2),
                NationalityId = "23014093254"
            };

            gamerManager.Add(gamer);
            gamerManager.Remove(gamer);
            gamerManager.Update(gamer);

            Offer offer = new Offer();
            OfferManager offerManager = new OfferManager();
            offer.Name = "Deneme";
            offer.DiscountRate = 20;
            offerManager.Add(offer);
            offerManager.Remove(offer);
            offerManager.Update(offer);

            Game game = new Game() { Name = "Red Dead Redemption 2", Price = 555 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Remove(game);
            gameManager.Update(game);

            SaleManager saleManager = new SaleManager();
            saleManager.Save(gamer, game, offer);
            saleManager.Save(gamer, game);


        }
    }
}