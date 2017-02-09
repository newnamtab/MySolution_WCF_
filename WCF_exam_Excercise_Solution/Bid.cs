using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_exam_Excercise_Solution
{   [DataContract]
    public class Bid
    {
        [DataMember]
        public int ItemNumber { get; set; }//(fx 123456 – et entydig item nummer)
        [DataMember]
        public int Price { get; set; }//(fx 2100)
        [DataMember]
        public string CustomName { get; set; }//(fx ”Bjørk Boye Busch”)
        [DataMember]
        public string CustomPhone { get; set; }//(fx ” 63129162”)
    }
}