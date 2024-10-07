namespace ConcertBooking.Domain;

public class BaseClass {
	public Guid Id { get; set; }
	public DateTime CreatedOn { get; set; }
	public DateTime ModifiedOn { get; set; }
}