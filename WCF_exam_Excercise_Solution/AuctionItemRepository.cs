using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_exam_Excercise_Solution
{
    public class AuctionItemRepository
    {
        private object _lock = new object();
        private List<AuctionItem> _items;
        public AuctionItemRepository()
        {
            _items = new List<AuctionItem>();
            _items.Add(new AuctionItem { ItemDescription = "used Commodore 64", RatingPrice = 50, ItemNumber = 1010, BidTimestamp = new DateTime() });
            _items.Add(new AuctionItem { ItemDescription = "NEW Commodore 64", RatingPrice = 20, ItemNumber = 2020, BidTimestamp = new DateTime() });
            _items.Add(new AuctionItem { ItemDescription = "Used Java book", RatingPrice = 30, ItemNumber = 3030, BidTimestamp = new DateTime() });
            _items.Add(new AuctionItem { ItemDescription = "New Lawn Chair", RatingPrice = 40, ItemNumber = 3030, BidTimestamp = new DateTime() });
        }
        public List<AuctionItem> GetItems()
        {
            lock (_lock)
            {
                return _items;
            }

        }
        public AuctionItem GetItem(int itemNumber)
        {
            lock (_lock)
            {
                foreach (AuctionItem item in _items)
                {
                    if (itemNumber == item.ItemNumber)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        public string GiveBid(Bid inBid)
        {

            lock (_lock)
            {

                for (int i = 0; i < _items.Count; i++)
                {
                    if (inBid.ItemNumber == _items[i].ItemNumber)
                    {
                        if (inBid.Price >= _items[i].BidPrice)
                        {
                            _items[i].BidPrice = inBid.Price;
                            _items[i].BidCustomName = inBid.CustomName;
                            _items[i].BidCustomPhone = inBid.CustomPhone;
                            _items[i].BidTimestamp = DateTime.Now;
                            return "OKAY";
                        }
                        return "BID TOO LOW";
                    }
                }
                return "Vare findes ikke";

            }
        }
    }
}