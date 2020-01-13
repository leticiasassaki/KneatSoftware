# Kneat Software Coding Challenge
Project responsible for calculate the amount of stops for resupply the starships from Star Wars would take to make the distance from planets.

## Problem Approach
1 - I created a console application project.

2 - The Kneat project are separated in 4 folders
```
- Business: Responsable for the calculation the amount of stops, convertion starship consumables to hours and validation of values
- Exceptions: Responsable for the exceptions class in the project
- Model: Responsable for the class models Starship and StarshipHeader
- Service: Responsable for the request to API
```
3 - The KneatTest project are separated in 2 classes
```
- InputTest: Responsable for the test validation of the input values
- CalculationTest: Responsable for the test calculation and validation of the MGLTCalculation class
```

### Prerequisites
- Visual Studio 2019 or Visual Studio Code
```
https://visualstudio.microsoft.com/pt-br/downloads/
https://code.visualstudio.com/
```
- .NET Core 3.0
```
https://dotnet.microsoft.com/download
```
### Nuget Packages  
- NewtonSoft.JSON - Deserialize objects returned from the API of SWAPI
- xUnit - To create the tests of the application

### Installing

After the download of Visual Studio and .Net Core, follow the next steps

### Code:

- Cloning the project:
```
$ git clone https://github.com/leticiasassaki/KneatSoftware.git
```
### Running the project 

- Execute the following steps:
1 - Open Kneat.sln using Visual Studio.
2 - Build the application
3 - Press F5

### How to use
1 - Application will ask to input the distance in Mega light.
```
"Please, type the distance in mega lights."
```
2 - A request for Starships to SWAPI will be made.
```
"Requesting the Starships."
```
3 - A list of starships and the amount of stops will appear in the console.
```
Id | Name | Amount of Stops
1  | Executor | 0
```

## Running the tests
The idea to run the tests in this project was thought to be easy to maintain and execute as well.
```
Test > Windows > Test Explorer > Run All
```

