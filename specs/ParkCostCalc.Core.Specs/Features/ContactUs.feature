@fast
Feature: Contact Us
	In order to contact the customer support 
	As a traveler
	I want to be able to submit a contact request

@fast @db @email
Scenario: Traveler should be able to contact customer support with valid details
	Given the following contact details
		| name         | email                  | subject   | message                   |
		| Tawfik Nouri | nouri.tawfik@gmail.com | locations | What are your locations ? |
	When the contact request is submitted
	Then the contact request should be created successfully
	And the email with contact request should be sent to the support team