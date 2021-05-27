# Test Instructions
## .NET Application
The aim of the coffee solution is to create a drink based on user input through a console app(inQuba.CoffeeMachine).
You are required to provide the machine with the following capabilities:

- Create a cappuccino drink. In order to make a cappuccino the user must provide the amount of sugar required. A cappuccino requires 5 beans to make.
- Coffee should require the selection of whether a user would like Milk or not. We may assume other drinks always require milk. 
- Change the console app(user interface) so that a user has the ability to select more drinks when ever a drink is ready. The machine should only turn off when the user sends the command "off".
- Implement tracking of the number of beans and remaining milk capacity in the machine. An appropiate message should be displayed should there be insufficient beans or milk remaining in the machine for the selection. Milk Requirements per drink: Coffee - 1 Milk unit, Latte - 2 Milk units, Cappaccino - 3 Milk units.
- The machines maximum bean capacity is 25. The maximum milk capacity is 20.

You have full control over the machine and may make changes where you see fit using best practices and clean code. YOU ARE ALLOWED to completely scrap the solution and start from scratch should you wish.

Pay special attention to the following:
- Any violations of SOLID should be corrected.
- Unit tests should be written for new functionality. Old tests should pass but can be removed if they are no longer applicable.
- Code readability

Bonus: Display a message to user when the bean capacity has reached 5 or lower, informing them of a low bean capacity.

## Angular Application
Angular setup can be found at: https://angular.io/guide/setup-local

Simple Tutorial: https://angular.io/tutorial

All functional changes will made in the DrinkMaker component(src/app/drink-maker.component.ts).

- The drink object is currently created in the DrinkMaker component. Create a "Drink" interface with the same properties shown in the component so it may be reused.
- The "makeDrink" method should create a new drink object. The method should have "type" and "numberOfSugars" as parameters.
- Create a test in "drink-maker.component.spec.ts" that tests the makeDrink method.
- Create a service that returns a list of made up drinks. Create a method in the DrinkMaker component that calls the service and retrieves the mock list. Create a test for this method
