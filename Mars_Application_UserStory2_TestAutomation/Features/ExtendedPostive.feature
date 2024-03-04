Feature: ExtendedPostive
Test MARS application Test cases

Background: 
## Positive_TC _001 - Log into Mars Application
Given User logs in Mars application using valid username "kodigantivandana@gmail.com" and password "vandu@28june"
When User selects Profile tab


@ExtendedPostiveTests,@ExtendedPostiveAddDuplicateLanguage
Scenario Outline:b1.User adds Language and levels in Profile tab
When User enters new Language details '<Language>' '<Language_Level>' and clicks on Add New button
Then Application saves the Langauge details '<Language>' '<Language_Level>' for the user

Examples: 
| Language | Language_Level |
| English  | Fluent         |

@ExtendedPostiveTests,@ExtendedPostiveAddDuplicateLanguage
Scenario Outline:b2.User adds Duplicate Language and levels in Profile tab
* User enters a duplciate Language details '<Language>' '<Language_Level>' and clicks on Add New button

Examples: 
| Language | Language_Level |
| English  | Fluent         |

@ExtendedPostiveTests,@ExtendedPostiveAddDuplicateSkill
Scenario Outline:b3.User adds skills and  levels in Profile tab
When User enters new skills detais '<skills>' '<Skill_Level>'and clicks on Add new button
Then Application saves the skills details '<skills>' '<Skill_Level>'
Examples: 
| skills         | Skill_Level |
| Automation Testing | Expert      |

@ExtendedPostiveTests,@ExtendedPostiveAddDuplicateSkill
Scenario Outline:b4.User adds Duplicate skills and levels in Profile tab
When User enters a duplciate skills details '<skills>' '<Skill_Level>' and clicks on Add New button
#Then Application saves the Langauge details '<Language>' '<Language_Level>' for th
Examples: 
| skills         | Skill_Level |
| Automation Testing | Expert      |

@ExtendedPostiveTests,@ExtendedPostiveAddDuplicateSkill
Scenario Outline:b5.User deletes skills and levels in Profile tab
When User deletes skills_details '<skills>' '<Skill_Level>' for the user
#Then Application deletes the skill details '<skills>' '<Skill_Level>' for the user

Examples: 
| skills				| Skill_Level |
| Automation Testing   | Expert      |