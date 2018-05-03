Feature: POC
    In order to show myself off as a badass test automator
    I want to implement a test framework 
    in a language I have never worked with before
	
	
@bogusTag
Scenario: Basic stuff up and running
    Given I have navigated to "http://www2.hm.com/sv_se/index.html"
    Then I should be able to see the link to the shopping cart

 Scenario: Also doing some navigation and chilling for a bit
    Given I have navigated to "https://diabol.se"
    Then I should be able to navigate to the about page
        And chill for a while 