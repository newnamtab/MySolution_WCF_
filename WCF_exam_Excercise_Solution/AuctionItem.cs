using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_exam_Excercise_Solution
{
    [DataContract]
    public class AuctionItem
    {   [DataMember]
        public int ItemNumber { get; set; }//(fx 123456 – et entydig item nummer)
        [DataMember]
        public string ItemDescription { get; set; }//(fx ” PH 5 Classic Hvid mat”)
        [DataMember]
        public int RatingPrice { get; set; }//(vurderingen fx 2100)
        [DataMember]
        public int BidPrice { get; set; }//(fx 2100 - hvis ingen bud afgivet så 0)
        [DataMember]
        public string BidCustomName { get; set; }//(fx ”Bjørk Boye Busch”)
        [DataMember]
        public string BidCustomPhone { get; set; }//(fx ” 63129162”)
        [DataMember]
        public DateTime BidTimestamp { get; set; }
    }
}