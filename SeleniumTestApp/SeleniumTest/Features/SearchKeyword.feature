Feature: SearchKeyword

Scenario: Verify Search Keyword in google
	Given I am on google search page
	When I Search for a keyword called 'Selenium'
	Then I should see 'Selenium' on the goole search
