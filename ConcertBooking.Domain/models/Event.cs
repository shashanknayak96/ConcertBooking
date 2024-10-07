namespace ConcertBooking.Domain;

public class Event : BaseName {
	public DateTime EventDate { get; set; }
	public Guid EventTypeId { get; set; }

	public virtual EventType EventType { get; set; }
}