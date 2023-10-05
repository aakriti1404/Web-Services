using Microsoft.EntityFrameworkCore;
using HotelBookingRESTAPI.Models;
using System;

namespace HotelBookingRESTAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
    }
}
