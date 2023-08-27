## What Is This?

This is an example repo corresponding to multiple lessons within the LearnHowToProgram.com walkthrough on using Test-Driven Development, the "Red, Green, Refactor" workflow, and MSTest to create business logic for the Shape Tracker application in the [C# and .NET Pre-Work: Test-Driven Development and Debugging](https://www.learnhowtoprogram.com/c-and-net/test-driven-development-and-debugging/). The functionality in the C# Shape Tracker app is meant to match [the JavaScript Shape Tracker app](https://github.com/epicodus-lessons/section-5-shape-tracker/tree/3_multiple_business_logic_files) that Epicodus students created in the Intermediate JavaScript course.

There are multiple branches in this repo that are described more below.

## How To Run Tests

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's test directory called "ShapeTracker.Tests". 
3. Run `dotnet test` in the command line invoke MSTest to run tests. The results of running the tests will appear in the terminal.

### How to Run the Project

1. To optionally run the Shape Tracker app, first navigate to this project's production directory called "ShapeTracker".  
2. There is no user interface in this repo's default branch, but there is one in the branch `2_complete_testing`. To access the branch `2_complete_testing`, run the following commands within the "ShapeTracker" directory:

```
$ git fetch --all
$ git checkout 2_complete_testing
```

3. In the command line, run `dotnet run` in the "ShapeTracker" directory to run the console app. Since this is a console application, you'll interact with it through text commands in your terminal. Take note that the user interface will vary from branch to branch.
4. Optionally, you can run `dotnet build` to compile this console app without running it.

## Available Branches

**1_mstest_setup**: This is the default branch with the the required file/folder structure required to write and run tests with MSTest. This branch includes the code we added after working through the following lessons:

- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/what-we-ll-learn-in-this-section
- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/review-the-red-green-refactor-workflow-and-testing-best-practices
- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/mstest-configuration-and-setup

**2_complete_testing**: This branch includes the code we added after working through the following lessons:

- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/using-the-rgr-workflow-to-write-our-first-test-for-the-constructor
- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/testing-a-private-field-through-its-public-property-and-organizing-tests-with-arrange-act-assert
- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/testing-an-auto-implemented-property
- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/testing-a-private-field-through-its-getter-and-setter-methods
- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/testing-a-method-with-multiple-behaviors
- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/part-1-testing-static-class-members-and-collections
- https://www.learnhowtoprogram.com/c-and-net/tdd-and-debugging/part-2-adding-a-teardown-method-and-completing-the-tests-for-static-class-members