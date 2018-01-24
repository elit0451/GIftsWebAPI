using GIftsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GIftsWebAPI.Controllers
{
    public class GiftsController : ApiController
    {
        // GET: api/Gifts
        public List<Gift> Get()
        {
            return GiftsRepository.GetAllGifts();
        }

        // GET: api/Gifts/1

            [Route("api/Gifts/GetGirls")]
        public List<Gift> GetGirlsGift()
        {
            return GiftsRepository.GetGirlsGifts();
        }

        // POST: api/Gifts
        // Fiddler request body {"GiftName":"ball", "GirlGift":"true", "BoyGift":"false"}
        public void Post([FromBody] Gift gift)
        {
            GiftsRepository.Add(gift.GiftName, gift.GirlGift, gift.BoyGift);
        }
    }
}
