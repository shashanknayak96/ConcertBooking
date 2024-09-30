namespace ConcertBooking.Domain;

public class Seat : BaseClass {
	public int SeatName { get; set; }
	public Guid VenueId { get; set; }

	public virtual Venue Venue{ get; set; }
}