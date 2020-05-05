@fast
Feature: Long-Term Surface Parking feature
  The parking lot calculator can calculate costs for Long-Term Surface parking.

Scenario Outline: Calculate LongTermSurface Parking Cost
	Given parking lot is LongTermSurface
	And parking duration is <duration>
	When the cost estimate is calculated
	Then the parking cost should be <cost>

	Examples:
		| duration       | cost    |
		| 0 minute       | 0.00€   |
		| 30 minutes     | 2.00€   |
		| 1 hour         | 2.00€   |
		| 5 hours        | 10.00€  |
		| 6 hours        | 10.00€  |
		| 24 hours       | 10.00€  |
		| 1 day, 1 hour  | 12.00€  |
		| 1 day, 3 hours | 16.00€  |
		| 1 day, 6 hours | 20.00€  |
		| 6 days         | 60.00€  |
		| 6 days, 1 hour | 60.00€  |
		| 7 days         | 60.00€  |
		| 1 week, 2 days | 80.00€  |
		| 3 weeks        | 180.00€ |