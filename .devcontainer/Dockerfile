# Use the official Microsoft .NET image.
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set the working directory inside the container to /workspace.
WORKDIR /workspace

# Install system dependencies required for your project here.
# Update the package lists and install ssh and procps (which provides ps).
RUN apt-get update && apt-get install -y \
    ssh \
    procps \
    && rm -rf /var/lib/apt/lists/*

# Copy the solution file
COPY MasterCommander.sln .

# Copy the entire src directory and restore as distinct layers
COPY src/ ./src/
RUN for file in $(ls src/**/*.csproj); do dotnet restore $file; done

# Optionally, copy other directories if needed, e.g., for tests or additional source files.

# Set the working directory to where most of the work will be done
WORKDIR /workspace/src
