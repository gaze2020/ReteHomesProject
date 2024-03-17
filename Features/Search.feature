Feature: Search

As a user of ReteHomes Property Website
I want to be able to search for any Property within the Website
So that I can use the results to make a better decisions on acquiring

@tag1
Scenario: Search for a Property
	Given that I am on the landing page of ReteHomes Property Website
	And I scroll down to the search button
	When I click on the search field
	And I type Lagos Property on the search field
	And I click on the search button
	Then I am redirected to a detailed page of the searched property
