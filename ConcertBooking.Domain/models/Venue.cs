namespace ConcertBooking.Domain;

public class Venue : BaseName {
	public string Address { get; set; }
	public string Latitude { get; set; }
	public string Longitude { get; set; }

	public virtual List<Seat> Seats { get; set; }
}
