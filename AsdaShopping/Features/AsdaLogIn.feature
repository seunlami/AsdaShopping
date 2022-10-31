Feature: AsdaLogIn
	

@mytag
Scenario: Register new asda log in details
	Given I navigate to website "https://www.asda.com/"
	And I click accept on the pop up screen
	And I click on register
	And I enter email address "seunodunlami2016@gmail.com"
	And I enter password "movingmad1978##"
	When I click on register
	Then I should be logged in 

	@mytag
Scenario: Sign In with new Asda log in details
Given I navigate to website "https://www.asda.com/"
	And I click accept on the pop up screen
	And I click on Sign In
	And I enter new email address "seunodunlami2016@gmail.com"
	And I enter new password "movingmad1978##"
	When I click on Sign in
	#Then I should be logged into the website homepage

