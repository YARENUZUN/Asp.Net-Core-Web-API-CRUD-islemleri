using System;
using Microsoft.AspNetCore.Mvc;


namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
            private static readonly IHotelService _hotelService;
            public HotelsController(IHotelService hotelService)
            {
                _hotelService = hotelService;
            }


            [HttpGet("{id}")]
            public IHotelService Get(int id)
            {
                Return _hotelService.GetHotelById(id);
            }

        [HttpPost]
        public Hotel Post([FromBody]Hotel (hotel))
        {
            return _hotelService.CreateHotel(hotel);
        }

        [HttpPut]
        public Hotel Put([FromBody]Hotel (hotel))
        {
            return _hotelService.UpdateHotel(hotel);
        }

        [HttpDelete("{id}")]
        public void Post(int id)
        {
            _hotelService.DeleteHotel(id);
        }



    }
}
