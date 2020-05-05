@fast
Feature: Economy Parking feature
  The parking lot calculator can calculate costs for Economy parking.

Scenario Outline: Calculate Economy Parking Cost
	Given parking lot is Economy
	And parking duration is <duration>
	When the cost estimate is calculated
	Then the parking cost should be <cost>

	Examples:
		| duration       | cost    |
		| 0 minute       | 0.00€   |
		| 30 minutes     | 2.00€   |
		| 1 hour         | 2.00€   |
		| 4 hours        | 8.00€   |
		| 5 hours        | 9.00€   |
		| 6 hours        | 9.00€   |
		| 24 hours       | 9.00€   |
		| 1 day, 1 hour  | 11.00€  |
		| 1 day, 3 hours | 15.00€  |
		| 1 day, 5 hours | 18.00€  |
		| 6 days         | 54.00€  |
		| 6 days, 1 hour | 54.00€  |
		| 7 days         | 54.00€  |
		| 1 week, 2 days | 72.00€  |
		| 3 weeks        | 162.00€ |