Feature: Brushing Of Teath

Scenario: Successful Breshing
	Given there is toothpeast on the bresh
		And the mouth is open	
	When the back teeth are burshed
		And the front teeth are burshed
	Then the teeth look clean
		And mouth is feels fresh
		But the braces are not damaged
