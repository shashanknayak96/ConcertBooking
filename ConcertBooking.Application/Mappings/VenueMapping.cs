
using AutoMapper;
using ConcertBooking.Application.Models;
using ConcertBooking.Domain;

public class VenueMapping : Profile {
	public VenueMapping() {
		CreateMap<CreateVenue, Venue>().ReverseMap();
	}
}