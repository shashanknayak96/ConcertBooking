using FluentValidation;

public class CreateEventTypeValidator : AbstractValidator<CreateEventType> {
	public CreateEventTypeValidator() {
		RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty")
			.Length(1, 100).WithMessage("Name must be between 1 and 100 characters");
	}
}