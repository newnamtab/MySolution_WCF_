using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF_Klient_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Myprogram = new Program();
            Myprogram.Run();
        }
        public void Run()
        {
            AuctionReference.AuctionServiceClient service = new AuctionReference.AuctionServiceClient();

            AuctionReference.Bid temBid = new AuctionReference.Bid();
            temBid.CustomName = "Søren";
            temBid.CustomPhone = "12346579";
            temBid.ItemNumber = 1010;
            temBid.Price = 5;

            Console.WriteLine(service.GiveBid(temBid));
            Console.ReadKey();

        }
    }
}
