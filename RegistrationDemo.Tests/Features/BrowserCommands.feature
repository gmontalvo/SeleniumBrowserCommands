Feature: seleniumframework.com features

@Browser:Firefox
Scenario: Open seleniumframework website
Given I open seleniumframework website
And I navigate to ABOUT link
Then I print the html

@Browser:Firefox
Scenario: Browser commands
Given I open seleniumframework website
Then I perform selenium browser commands
