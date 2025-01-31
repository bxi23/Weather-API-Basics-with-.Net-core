# MyWebAPI

This project is a simple ASP.NET Core Web API that provides basic CRUD (Create, Read, Update, Delete) operations for weather forecasts. The project was built following the guidance of the [Implementing Basic API Endpoints](https://www.coursera.org/learn/back-end-development-with-dotnet/supplement/VW34e/implementing-basic-api-endpoints) course on Coursera.

## Project Overview

The `WeatherForecastController` class provides the following API endpoints:

- **GET /weatherforecast**: Retrieves a list of weather forecasts.
- **POST /weatherforecast**: Creates a new weather forecast.
- **PUT /weatherforecast/{id}**: Updates an existing weather forecast by ID.
- **DELETE /weatherforecast/{id}**: Deletes a weather forecast by ID.

## Running the Project

1. **Set Up the Development Environment**:
   - Download and install the .NET SDK from Microsoft's official site.
   - Install Visual Studio and ensure the ASP.NET and web development workload is selected during installation.

2. **Create a New ASP.NET Core Web API Project**:
   - Open Command Prompt or Terminal.
   - Run this command to create a new project:
     ```sh
     dotnet new webapi -n MyWebAPI
     ```

3. **Add a Controller**:
   - In Visual Studio, add a new controller class (e.g., [WeatherForecastController.cs](http://_vscodecontentref_/1)).

4. **Define the API Methods**:
   - Implement the GET, POST, PUT, and DELETE methods in the `WeatherForecastController` class.

5. **Run the Application**:
   - Open Command Prompt or Terminal.
   - Navigate to the project directory.
   - Run the project using:
     ```sh
     dotnet run
     ```

## Testing the API Endpoints

You can test the API endpoints using the [requests.http](http://_vscodecontentref_/2) file with the REST Client extension in Visual Studio Code. The [requests.http](http://_vscodecontentref_/3) file contains the following requests:

### GET Weather Forecasts
```http
GET http://localhost:5260/weatherforecast