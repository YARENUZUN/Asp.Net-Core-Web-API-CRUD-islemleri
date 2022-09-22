using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrate
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (var Db=new HotelDbContext())
            {
                Db.Hotels.Add(hotel);
                Db.SaveChanges();
                return hotel;
            }
        }

        public void DeleteHotel(int id)
        {
            using (var Db = new HotelDbContext())
            {
                var deleteHotel=GetHotelById(id);
                Db.Hotels.Remove(deleteHotel);
                Db.SaveChanges();
            }
        }

        public List<Hotel> GetAllHotels()   //tüm hotel ları dönderdik
        {
            using(var Db=new HotelDbContext())
            {
                return Db.Hotels.ToList();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var Db = new HotelDbContext())
            {
                return Db.Hotels.Find(id);
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using(var Db=new HotelDbContext())
            {
                Db.Hotels.Update(hotel);
                Db.SaveChanges();
                return hotel;
            }
        }
    }
}
