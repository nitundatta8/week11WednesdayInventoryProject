# _Inventory Control_

#### _Epicodus Week11 Wednesday Inventory Practice Project_

#### By _**Nitun**_  _**Khan Sahab**_

## Description

_A web application that allows user to add product and get details of the product._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the commands dotnet restore, dotnet build, and dotnet run.
5. Database: `inventory_demo`
6. Table: 
CREATE TABLE `products` (
  `ProductId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Workable` varchar(45) DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  PRIMARY KEY (`ProductId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
7. Need to change password in json file.a

## Known Bugs
 
None. All the basic requirements of Project are fulfilled
 
## Support and contact details

_Have a bug or an issue with this application? Email post_khan@yahoo.com_

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MSBuild
* Razor
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User can add product by clicking add new items** | User Input:"add Name,Workable and Quantity” | Output: " Name,Workable and Quantity displayed" |
| **User can view products** | User Input:”click on the product” | Output: "All product of are displayed" |


### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Khan Sahab and Nitun Datta_**