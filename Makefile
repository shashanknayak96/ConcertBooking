PROJECT_NAME=ConcertBooking.Api
SOLUTION_FILE=ConcertBooking.sln
PROJECT_PATH=$(PROJECT_NAME)/$(PROJECT_NAME).csproj

# Build the solution
build:
	dotnet build $(SOLUTION_FILE)

# Run the project
run:
	dotnet run --project $(PROJECT_PATH)

watch:
	dotnet watch --project $(PROJECT_PATH)