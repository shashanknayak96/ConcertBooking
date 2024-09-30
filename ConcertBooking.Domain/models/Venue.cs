namespace ConcertBooking.Domain;

public class Venue : BaseClass {
	public string Name { get; set; }
	public string Address { get; set; }
	public string Latitude { get; set; }
	public string Longitude { get; set; }

	public virtual List<Seat> Seats { get; set; }
}
