using ConcertBooking.Application;
using ConcertBooking.Domain;
using Microsoft.EntityFrameworkCore;

public class BaseContext : DbContext {
	public BaseContext(DbContextOptions<ConcertBookingContext> options) : base(options) { }

	public override int SaveChanges() {
		SetTracking();
		return base.SaveChanges();
	}

	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) {
		SetTracking();
		return base.SaveChangesAsync(cancellationToken);
	}

	private void SetTracking() {
		var entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

		foreach (var entry in entries) {
			var entity = (BaseClass)entry.Entity;

			if (entry.State == EntityState.Added) {
				entity.CreatedOn = DateTime.UtcNow;
			}

			entity.ModifiedOn = DateTime.UtcNow;
		}
	}

}