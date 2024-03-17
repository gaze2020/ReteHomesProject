Feature: Login

As a registered user of Retehomes Property website
I want to Login to my profile
So that I can get detailed info of the properties

@tag1
Scenario: Login to my Profile
	Given I am on the homepage of the Retehomes website
	When I click the Login Button on the header section
	And I enter a valid registered email address
	And I enter a valid registered password
	And I checked the Remember Me box
	And I click on the Login Button
	Then I should be successfullly logged in to my profile
