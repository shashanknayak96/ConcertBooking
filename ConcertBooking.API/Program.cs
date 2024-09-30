using ConcertBooking.Application;
using ConcertBooking.Application.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ConcertBookingContext>((options) => {
	options.UseNpgsql(builder.Configuration.GetConnectionString("ConcertBookingDatabase"), options => options.MigrationsAssembly(typeof(Program).Assembly.GetName().Name));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(EventTypeMapping));

// Services
builder.Services.AddScoped<IEventTypeRepository, EventTypeRepository>();
builder.Services.AddScoped<IEventTypeService, EventTypeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapControllers();

app.UseHttpsRedirection();
app.Run();
