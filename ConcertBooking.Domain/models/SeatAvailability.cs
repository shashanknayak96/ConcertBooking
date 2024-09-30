namespace ConcertBooking.Domain;

public class SeatAvailability : BaseClass {
	public Guid SeatId { get; set; }
	public DateTime Date { get; set; }
	public bool IsAvailable { get; set; }

	public virtual Seat Seat { get; set; }
}