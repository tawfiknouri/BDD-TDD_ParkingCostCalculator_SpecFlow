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