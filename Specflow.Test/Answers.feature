@important
Feature: Answers
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Add two numbers
	Given I have entered <Number 1> into the calculator
	And I have also entered <Number 2> into the calculator
	When I press add
	Then the result should be <Number 3> on the screen
	
	Examples: 
		| Case           | Number 1 | Number 2 | Number 3 |
		| Add 50 and 70  | 50       | 70       | 120      |
		| Add 70 and 50  | 70       | 50       | 120      |
		| Add 60 and 60  | 60       | 60       | 120      |
		| Add 50 and -25 | 50       | -25      | 25       |