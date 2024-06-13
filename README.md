**Course Summary:**
- Setting up a test project
- Implementing unit tests
- Writing testable code
- Applying TDD (Test Driven Development)
- Running tests automatically


**module 2 - writing your first unit test**

- There are 3 popular Unit testing framework for .NET:
	- MSTest;
	- NUnit;
	- xUnit (the latest unit test framework and the framework that will be used in this course);
- What is unit testing
	- Ensure your code works as expected
- Explore the .NET console application
- Add a test project:
	- write a unit test
	- Run and debug  the unit test
	
	
**module 3 - Implementing Different Unit Tests**

- Summary
- The parts of a unit test:
	- Arrange, act, assert
- Write different unit tests:
	- Test that empty lines are skipped;
	- Test for an exception;
- Implement a data-driven test


**module 4 - 	Writing Testable Code**

Summary:
- Decouple dependencies (Know How to Decouple Dependencies):
	- Test the MachineDataProcessor;
	- Create an ICoffeeCountStore Interface;
	- Use the interface in the MachineDataProcessor class;
- Write unit tests:
	- Implement a FakeCoffeeCountStore;
- Run code before and after every test;


**module 5 - Applying Test Driven Development**

Summary:
- Test Driven Development (TDD):
	- Unit tests drive the implementation
	- Red, green, refactor
- Implement a requirement with TDD:
	- Write a test
	- Implement the requirement
	- Refactor the code


**module 6 - Running Unit Tests Automatically**

Summary:
- Run tests with the .NET CLI (command-line interface):
	- dotnet test
- Push code to a repository on GitHub
- Run Tests Automatically with a GitHub Action
	- trigger the tests with a commit
