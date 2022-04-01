
<center># Animal Shelter</center>

------------------------------

------------------------------

## About 

### Description
An API that serves up info on current animals in our shelter.

### Known Bugs
Patch route is not functional.

### Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL 8.0.20 for Linux](https://dev.mysql.com/)
* [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger - NSwag 13.3.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
* [Postman](postman.com)

------------------------------

## Getting Started

### Required Software

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  1) Download VSCODE - [VisualStudio Code](https://www.npmjs.com/)
  2) Click the download for your operating system.
  3) Open and install.

### Setup and Use

  #### Download

  1) Navigate to (https://github.com/jwtill/AnimalShelter.Solution).
  2) Click 'Clone or download' to see the link and click the 'Download ZIP' button.
  3) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings.json

  1) Create a new file in the AnimalShelter.Solution/AnimalShelter directory called `appsettings.json`
  2) Add the following in to the new file:
  
  ```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=josh_tillinghast;uid=root;pwd=[YOUR PASSWORD HERE];"
  }
}


  ```
  3) Replace '[YOUR PASSWORD HERE]' with your MySQL password that was created when you set up that application.

  #### Database
  1) Go to AnimalShelter.Solution/AnimalShelter directory using the command line.
  2) Run the command `dotnet ef database update` to recreate the database locally.
  
  #### Launch the API
  1) Navigate to AnimalShelter.Solution/AnimalShelter directory, then use the command `dotnet run` to start the application.
 
------------------------------


### Using Swagger Documentation 
Swagger is a tool for documenting endpoints using a UI that is straightforward to navigate.
Navigate to localhost:5001 or localhost:5000 and you will be redirected to the Swagger index, where you can explore endpoints and their requirements.

### Routes
------------------------------
#### GET /api​/Animals
- Gets an animal based on URL parameters.
#### POST ​/api​/Animals
- Adds a new animal
#### GET /api​/Animals​/Adoptable
- Gets a list of animals that have not been adopted.
#### GET /api​/Animals​/{id}
- Gets an animal based on ID.
#### PUT /api​/Animals​/{id}
- Updates an animal with a given ID.
#### DELETE /api​/Animals​/{id}
- Deletes an animal with a given ID.
#### PATCH /api​/Animals​/{id}
- Changes a given animal's Adopted status.
#### GET /api​/Animals​/Random
- Gets a random animal.




### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2022 Josh Tillinghast. All Rights Reserved.

```
MIT License

Copyright (c) 2022 Josh Tillinghast.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------

### Acknowledgements

Thanks to all my pairs this week for helping me understand the material in different ways, and to my family for support throughout the program!
------------------------------

<center><a href="#">Return to Top</a></center>