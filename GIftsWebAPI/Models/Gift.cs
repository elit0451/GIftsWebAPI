using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIftsWebAPI.Models
{
    public class Gift
    {
        private static int id = 0;
        private int myId = 0;
        public int GiftNumber
        {
            get { return myId; }
        }
        public string GiftName { get; set; }
        public bool GirlGift { get; set; }
        public bool BoyGift { get; set; }

        public Gift()
        {
        }

        public Gift(string giftName, bool girlGift, bool boyGift)
        {
            id++;
            myId = id;
            GiftName = giftName;
            GirlGift = girlGift;
            BoyGift = boyGift;
        }

    }
}