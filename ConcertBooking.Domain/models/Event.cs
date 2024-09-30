namespace ConcertBooking.Domain;

public class Event : BaseClass {
	public string Name { get; set; }
	public DateTime EventDate { get; set; }
	public Guid EventTypeId { get; set; }

	public virtual EventType EventType { get; set; }
}