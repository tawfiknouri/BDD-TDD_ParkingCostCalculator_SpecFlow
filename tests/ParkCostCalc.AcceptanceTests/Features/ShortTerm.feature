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