using Microsoft.EntityFrameworkCore;
using ConcertBooking.Domain;

namespace ConcertBooking.Application;

public class ConcertBookingContext : BaseContext {
	public ConcertBookingContext(DbContextOptions<ConcertBookingContext> options) : base(options) {
	}

	public DbSet<Venue> Venue { get; set; }
	public DbSet<Seat> Seat { get; set; }
	public DbSet<SeatAvailability> SeatAvailability { get; set; }

	public DbSet<EventType> EventType { get; set; }
	public DbSet<Event> Event { get; set; }
}