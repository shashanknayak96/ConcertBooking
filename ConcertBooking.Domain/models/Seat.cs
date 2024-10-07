namespace ConcertBooking.Domain;

public class Seat : BaseName {
	public Guid VenueId { get; set; }

	public virtual Venue Venue{ get; set; }
}