using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIftsWebAPI.Models
{
    public static class GiftsRepository
    {
        public static List<Gift> listOfGifts = new List<Gift>();
        public static object myLock = new object();

        public static void Populate()
        {
            Gift gift1 = new Gift("pony", true, true);
            Gift gift2 = new Gift("axe", false, true);
            Gift gift3 = new Gift("barbie", true, false);

            listOfGifts.Add(gift1);
            listOfGifts.Add(gift2);
            listOfGifts.Add(gift3);
        }

        public static void Add(string giftName, bool girlsGift, bool boysGift)
        {
            lock (myLock)
            {
                listOfGifts.Add(new Gift(giftName, girlsGift, boysGift));
            }
        }

        public static List<Gift> GetAllGifts()
        {
            Populate();
            lock (myLock)
            {
                return listOfGifts.ToList();
            }
        }

        public static List<Gift> GetGirlsGifts()
        {
            List<Gift> girlsGifts = new List<Gift>();

            lock (myLock)
            {
                foreach(Gift g in listOfGifts)
                {
                    if(g.GirlGift == true)
                    {
                        girlsGifts.Add(g);
                    }
                }
            }

            return girlsGifts;
        }
    }
}