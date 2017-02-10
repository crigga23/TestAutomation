Feature: News
	In order to keep up-to-date with the latest news coverage
	As a user
	I want to be perform searches on the bbc website

Scenario:	Display UK related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed

Scenario:	Display World related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed


Scenario:	Display Business related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed

Scenario:	Display Politics related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed

Scenario:	Display Tech related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed

Scenario:	Display Science related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed

Scenario:	Display Health related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed

Scenario:	Display Education related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed

Scenario:	Display Entertainment & Arts related news articles
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed

Scenario:	Display Video Audio
	Given I am on the bbc news website
	When I access the UK section
	Then UK related news articles should be displayed
@search
Scenario:	Search for Trump
	Given I am on the bbc news website
	When I perform a search for 'Trump'
	Then news articles relating to Trump should be displayed

