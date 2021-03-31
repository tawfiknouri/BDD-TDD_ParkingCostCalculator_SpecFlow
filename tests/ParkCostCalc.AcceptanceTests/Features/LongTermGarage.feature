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