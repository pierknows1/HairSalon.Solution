# Pierre's Salon

#### By Pier Rodriguez

#### This MVC application lets you create a stylist and add a list of clients.

## Technologies Used

* C#
* .NET 6.0
* EF Core 6.0
* MySQL Workbench
* HTML
* Markdown
* Git
* CSS

## Description

This application is intended to help a salon owner keep track of all their stylists and salon clients. The owner is able to view a list of all current stylists, see details for each specific stylist, add new stylists to the system, and add new clients to a specific stylist.

## Setup/Installation

* _Clone this repo._

* _Open the terminal and navigate to this project's production directory `HairSalon`._

* _Within the production create a new file named `appsettings.json and place the following code inside replacing the text in the brackets with your MySql user name and password respectively._

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

* _From your terminal enter `dotnet run` to build project and run the page in your browser from the address: `localhost:5001`_



## Known Bugs

* _If the list of STYLISTS is deleted first before deleting the list of CLIENTS, the list of CLIENTS will stay and clicking on them will bring you to an error page._



## License

_MIT_

Copyright (c) _2023 Pier Rodriguez
