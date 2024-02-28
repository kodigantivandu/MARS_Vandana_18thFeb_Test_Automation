Feature: NegativeInvalid
Test MARS application Test cases

A short summary of the feature

@Negative_Invalid_Tests
Scenario Outline: Existing user does not type @ in Email field
	
    When the user enters '<username>' '<password>'  without @ in the Email field
   # Then the system should not accept the email
     
  Examples: 
 | username                     | password  |
 | kodigantivandanagmail.com | 123456789 |

 @Negative_Invalid_Tests
 Scenario Outline: Existing user doesnot type .com in the email field
 When the user '<username>' '<password>' without .com in the Email field
 # Then system should not accept the email
 Examples: 
 | username                     | password  |
 | kodigantivandana@gmail  | 123456789 |

 @Negative_Invalid_Tests
 Scenario Outline: Existing user's Email field is Empty
    
    When the user '<username>' '<password>' and leaves the Email field empty
  #  Then the system should display an error message

     Examples: 
 | username             | password  |
 |                      | 123456789 |

 @Negative_Invalid_Tests
 Scenario Outline: Existing user's Password field is Empty
    
    When the user enters '<username>' '<password>' and leaves the password field empty
  #  Then the system should display an error message

     Examples: 
 | username                    | password  |
 | kodigantivandana@gmail.com  |           |


    






