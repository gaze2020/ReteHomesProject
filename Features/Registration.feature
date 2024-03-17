Feature: New User Registration

As a potential user on the landing page of ReteHomes Property Website
I want to register as a seller on the website
So that I can display my properties for potential buyers

@tag1
Scenario: Register as a Seller
	Given I am on the ReteHomes Property Website
	When I click on the register button
	And I enter my full names
	And I enter a unique username
	And I enter email address
	And I enter a valid phone number
	And I enter my password and re-type the password
	And I select seller from the dropdown
	And I checked the box for T&C agreement
	When I click on the Register2 button
	Then I am registered as a seller on the website with email confirmation

