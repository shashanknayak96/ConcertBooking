
using AutoMapper;
using ConcertBooking.Domain;

public class EventTypeMapping : Profile {
	public EventTypeMapping() {
		CreateMap<CreateEventType, EventType>().ReverseMap();
	}
}