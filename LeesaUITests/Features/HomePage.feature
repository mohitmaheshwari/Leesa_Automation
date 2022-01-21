@Leesa_Home
Feature: Leesa-Home
	As a User 
	I would like to be able to use the Leesa feature

Scenario: Verify Website is rendering properly
	Given User lands on Leesa Website
	Then Verify Leesa Logo is displaying
	And Verify Navigation Menu is displaying
	And Verify Store Icon is displaying
	And Verify Account Icon is displaying
	And Verify Cart Icon is displaying
	And Verify Slider image is displaying
	And Verify Financing with Affirm is displaying
	And Verify Mattress List is displaying
	And Verify other Products are displaying

Scenario: Verify All Navigation Items are showing
	Given User lands on Leesa Website
	Then Verify for Menus and validate 'Mattresses', 'Bases', 'Beddings & Cushions', 'Bundles' and 'Blogs' are showing
	And Verify 'Mattresses' has sub menus and pointing to correct links
	And Verify 'Bases' has sub menus and pointing to correct links
	And Verify 'Beddings & Cushions' has submenus and pointing to correct links
	And Verify 'Bundles' is redirecting to correct link
	And Verify 'Blogs' is redirecting to correct link

	
