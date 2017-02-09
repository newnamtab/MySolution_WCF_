using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_exam_Excercise_Solution
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuctionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuctionService.svc or AuctionService.svc.cs at the Solution Explorer and start debugging.
    public class AuctionService : IAuctionService
    {
        private static AuctionItemRepository repository = new AuctionItemRepository();
        public AuctionItem GetAutctionItem(int value)
        {
            return repository.GetItem(value);
        }

        public List<AuctionItem> GetItems()
        {
            return repository.GetItems();
        }

        public string GiveBid(Bid inBid)
        {
            return repository.GiveBid(inBid);
        }

    }
}
