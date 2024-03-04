Feature: NegativeValid
Test MARS application Test cases

Background: 
## Positive_TC _001 - Log into Mars Application
Given User launches Mars application

@Negative_Valid_Tests
 Scenario: New user clicks join button with existing email
  #  Given  New user clicks join button
    When Enters all required details
    | First_Name | Last_Name | Email_Address        | Password | Confirm_Password | 
    | vandana   | kodiganti  | kodigantivandana@gmail.com   | *****    | *****           |
   # And User clicks on I agree and clicks Join
   # Then User should receive message as Email address already present


@Negative_Valid_Tests
  Scenario Outline: User enters password field more than  6 charaters
 # Given User Clicks on Sign in button in Mars application portal
 When User enters valid '<username>' '< Password>' field characters more than six characters
 #Then  Error message more than 6 characters  not allowed
 
 Examples: 
 | username                     | password  |
  | kodigantivandana@gmail.com | 123456789 |

@Negative_Valid_Tests
Scenario Outline: User exceedsmax lengthcharacters in language field and language level in profile tab
Given User logs in Mars application using valid username "kodigantivandana@gmail.com" and password "vandu@28june"
When User selects Profile tab
When User enters new Language details '<Language>' '<Language_Level>' and clicks on Add New button
#Then Application should show error message
## note - then cannot be implemented due to defect -- Application is accepting unlimited characters

Examples: 
| Language | Language_Level |
| Englishhhhhhhhhhhhhhhhhhhhhhhhh  | Fluent         |

@Negative_Valid_Test_to_fix
Scenario Outline: User exceeds max lengthcharacters in skills field and skills level in profile tab
Given User logs in Mars application using valid username "kodigantivandana@gmail.com" and password "vandu@28june"
When User selects Profile tab
Given User enters new skills detais '<skills>' '<Skill_Level>'and clicks on Add new button
#Then Application should show error message
## note - then cannot be implemented due to defect -- Application is accepting unlimited characters

Examples: 
| skills | Skill_Level |
| Manual_Testing_testttttttttttttttttttttttt  | Expert         |




  