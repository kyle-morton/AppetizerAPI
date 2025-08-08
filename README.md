# AppetizersAPI

This is a simple ASP.NET Core Web API that returns a hardcoded list of appetizer data at the endpoint `/api/appetizers`.

## How to Run

1. Make sure you have [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) installed.
2. In the project directory, run:

   ```sh
   dotnet run
   ```

3. Visit `http://localhost:5000/api/appetizers` (or the port shown in the console) to see the data.

## API Endpoint

- `GET /api/appetizers` — Returns a JSON array of appetizers matching the structure in the provided example.

## Development

- Swagger UI is available in development mode at `/swagger`.

---

This project was generated with `dotnet new webapi --no-https --framework net8.0` and customized to return hardcoded appetizer data.
