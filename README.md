# BDD/TDD With SpecFlow & .NET Core

[![Master Actions Status](https://github.com/tawfiknouri/BDD-TDD_ParkingCostCalculator_SpecFlow/workflows/commit-and-acceptance-stages/badge.svg)](https://github.com/tawfiknouri/BDD-TDD_ParkingCostCalculator_SpecFlow/actions)

The intention of this project is not create the best parking cost calculator in the world.
We want the simplest parking cost calculator in the world so we can focus on Behavior Driven Development (BDD) and Test Driven Development (TDD) practice

The main goal is to share knowledge !

Please do not hesitate to contact me if you have any questions or PR.


**The example also appears in the official specflow documentation.**

See here for details: **https://docs.specflow.org/en/latest/Examples.html#community-sample-projects**


Thanks for enjoying!


# Requirements

Imagine we were to design a parking cost calculator that calculates the price of parking tickets at the airport. There could be different parking sites like

* Valet Parking
* Short-Term Parking
* Long-Term Garage Parking
* Long-Term Surface Parking
* Economy Lot Parking

With each site having its own set of rules how a ticket price is calculated:
## Valet Parking
- 18.00€ per day
- 12.00€ for five hours or less
## Short-Term Parking
- 2.00€ first hour; 1.00€ each additional 1/2 hour
- 24.00€ daily maximum
## Long-Term Garage Parking
- 2.00€ per hour
- 2.00€ daily maximum
- 72.00€ per week (7th day free)
## Long-Term Surface Parking
- 2.00€ per hour
- 10.00€ daily maximum
- 60.00€ per week (7th day free)
## Economy Lot Parking
- 2.00€ per hour
- 9.00€ daily maximum
- 54.00€ per week (7th day free)

# The Technologies
* [SpecFlow](https://specflow.org/)
* [.NET Core](https://dotnet.microsoft.com/download)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core)
* [Nunit](https://nunit.org/)
  

# BDD practices
## Discovery
## Formulation

### Valet Parking

``` gherkin
@fast
Feature: Valet Parking feature
  The parking lot calculator can calculate costs for Valet Parking.

Scenario Outline: Calculate Valet Parking Cost
	Given parking lot is Valet
	And parking duration is <duration>
	When the cost estimate is calculated
	Then the parking cost should be <cost>

	Examples:
		| duration          | cost    |
		| 0 minute          | 0.00€   |
		| 30 minutes        | 12.00€  |
		| 3 hours           | 12.00€  |
		| 5 hours           | 12.00€  |
		| 5 hours, 1 minute | 18.00€  |
		| 12 hours          | 18.00€  |
		| 24 hours          | 18.00€  |
		| 1 day, 1 minute   | 36.00€  |
		| 3 days            | 54.00€  |
		| 1 week            | 126.00€ |
```

### Short-Term Parking

``` gherkin
@fast
Feature: Short-Term Parking feature
  The parking lot calculator can calculate costs for ShortTerm Parking.

Scenario Outline: Calculate Short-Term Parking Cost
	Given parking lot is ShortTerm
	And parking duration is <duration>
	When the cost estimate is calculated
	Then the parking cost should be <cost>

	Examples:
		| duration            | cost   |
		| 0 minute            | 0.00€  |
		| 30 minutes          | 2.00€  |
		| 1 hour              | 2.00€  |
		| 3 hours 30 minutes  | 7.00€  |
		| 12 hours 30 minutes | 24.00€ |
		| 1 day 30 minutes    | 25.00€ |
		| 1 day 1 hour        | 26.00€ |
```

### Long-Term Garage Parking

``` gherkin
@fast
Feature: Long-Term Garage Parking feature
  The parking lot calculator can calculate costs for Long-Term Garage parking.

Scenario Outline: Calculate LongTermGarage Parking Cost
	Given parking lot is LongTermGarage
	And parking duration is <duration>
	When the cost estimate is calculated
	Then the parking cost should be <cost>

	Examples:
		| duration       | cost    |
		| 0 minute       | 0.00€   |
		| 30 minutes     | 2.00€   |
		| 1 hour         | 2.00€   |
		| 3 hours        | 6.00€   |
		| 6 hours        | 12.00€  |
		| 7 hours        | 12.00€  |
		| 24 hours       | 12.00€  |
		| 1 day, 1 hour  | 14.00€  |
		| 1 day, 3 hours | 18.00€  |
		| 1 day, 7 hours | 24.00€  |
		| 6 days         | 72.00€  |
		| 6 days, 1 hour | 72.00€  |
		| 7 days         | 72.00€  |
		| 1 week, 2 days | 96.00€  |
		| 3 weeks        | 216.00€ |
```


## Automation
