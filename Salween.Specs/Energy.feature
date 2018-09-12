Feature: Energy


Scenario: Success convert
	Given Web browser is opened
	When I navigate to Matric conversions.
	And I navigate to Energy and power section
	And I navigate to Kilowatt-hours
	And choose conversions to Newton-meters
	And type 30 KWh
	Then assert that 1.080000e+8 Nm are displayed as answer
	Then Close web browser