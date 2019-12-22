# Tech Talk - Unit Test

## <a name="BasicDefinition">Basic definition</a> 
[>>](#Properties)

### Unit Test
A unit test is a piece of a code (usually a method) that __invokes another piece of code__ and checks the correctness of some assumptions afterward.
<br />
If the assumptions turn out to be wrong, the unit test has failed.
<br />
A unit is a method or function.

### System Under Test
SUT stands for system under test, and some people like to use CUT
(class under test or code under test). When you test something, you refer to the
thing you’re testing as the SUT.

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="Properties">Properties of a good unit test</a>
[<<](#BasicDefinition) [>>](#FinalDefinition)

A unit test should have the following properties:
- It should be easy to implement - small & simple.
- It should be relevant tomorrow - aviod testing private implementation details.
- Anyone should be able to run it at the push of a button.
- It should run quickly.
- It should be consistent in its results (it always returns the same result if you don’t change anything between runs).
- It should be automated and repeatable.
- It should have full control of the SUT.
- It should be fully isolated (runs independently of other tests).
- When it fails, it should be easy to detect what was expected and determine how to pinpoint the problem.

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="FinalDefinition">Final definition</a>
[<<](#Properties) [>>](#Frameworks)

### Unit Test
A unit test is an automated piece of code that invokes the __unit of work__ being tested, and then checks some assumptions
about a single end result of that unit. 
<br />
A unit test is almost always written using a __unit testing framework__. It can be written easily and runs quickly.
<br />
It’s trustworthy, readable, and maintainable. It’s consistent in its results as long as production code hasn’t changed.

### Unit Of Work
A unit of work is the sum of actions that take place between the invocation of a public method in the system and a single 
noticeable end result by a test of that system. A noticeable end result can be observed without looking at the internal 
state of the system and only through its public APIs and behavior.
<br />
An end result is any of the following:
- The invoked public method returns a value (a function that’s not void)
- There’s a noticeable change to the state or behavior of the system before and after invocation that can be determined 
without interrogating private state.
(Examples: the system can log in a user, or the system’s properties change if the system is a state machine)
- There’s a callout to a third-party system over which the test has no control

### Unit Test construction
- Arrange - initialize objects or services and prepare data
- Act - perform the unit of work
- Assert - compare actual result with expected value

<br />
<br />

### Demo :hammer:
<br />
ConsoleTests for BookDtoMapper (console + vs runner)

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="Frameworks">Unit test frameworks and tools</a>
[<<](#FinalDefinition) [>>](#Types)

### Frameworks
- unit test framework with runner e.g.: nUnit, xUnit, jUnit, Jasmin, Karma
- fake data generator e.g.: AutoFixture, JFixture, faker.js
- simple mock generator (interface based) e.g.: Moq, NSubstitute, Mockito
- advanced mock generator (constructor, static, private) e.g.: Fakes, JustMock, PowerMock
- assertion framework e.g.: xUnit, FluentAssertions, AssertJ, assert.js
- runners e.g.: console runner, VS runner

<br />
<br />

### Demo :hammer:
<br />
Tests for BookDtoMapper

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="Types">Types and naming</a>
[<<](#Frameworks)[>>](#Tdd)

### Types of unit tests
- Test / Fact - for testing single specific scenario with fixed input and output. Usually parameterless.
- Test Case / Theory - for testing the same part of code against multiple input and output data. Usually accepts some input parameters and expected value.

### Naming strategies
- Test / Fact - name consists of 3 parts:
  - ```UnitOfWorkName``` - the name of the method or group of methods or classes you’re testing
  - ```Scenario``` - the conditions under which the unit is tested, such as “bad login” or “invalid user” or “good password.” 
  You could describe the parameters being sent to the public method or the initial state of the system when the unit of work is invoked 
  such as “system out of memory” or “no users exist” or “user already exists”
  - ```ExpectedBehavior``` - what you expect the tested method to do under the specified conditions.
  This could be one of three possibilities:
    * return a value as a result (a real value, or an exception)
    * change the state of the system as a result (like adding a new user to the system, so the system behaves differently on the next login)
    * call a third-party system as a result (like an external web service)
<br />
Example: Calculate_NoInputData_ThrowsException()
<br />
<br />

- Test Case / Theory - name consists of single part with ```Test``` suffix: ```UnitOfWorkNameTest```
<br />
Example: CalculateTest(...)

<br />
<br />

### Demo :hammer:
<br />
BookDtoMapperTests and StringHelperTests
<br />
resultTypes in Samples

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="Tdd">Test driven development - TDD</a>
[<<](#Types)[>>](#NonFunctional)

### TDD
- think WHEN to write a test instead of HOW
- test-first approach

### Steps
- add a test
- run all tests and see if new test fails
- create or update the code (logic)
- run tests
- refactor code of application

<br />
<br />

### Demo :hammer:
<br />
StringHelperTests for NULL

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="NonFunctional">Non-functional unit tests</a>
[<<](#Tdd)[>>](#Profits)

### Tests for non-functional requirements
- conventions - static code analysis (instead of code analyzers)
- technical reqirements - instead of assumptions e.g.: "we will remember that ..."

<br />
<br />

### Demo :hammer:
<br />
GeneralBaseControllerTests and GeneralValueObjectTests in SPR

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="Profits">Unit tests - pros & cons</a>
[<<](#NonFunctional)[>>](#Practices)

### Pros
- unit tests as a bug detector
- unit tests as a guard of contract
- unit tests as a guard of business logic
- unit tests as a business logic documentation
- save time usually spent for debugging

### Cons
- additional effort during initial development

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="Practices">Good, bad and ugly practices</a>
[<<](#Profits)[>>](#CaseStudy)

### Good
- single test checks single rule or condition (one or very few asserts)
- tests are completely isolated and independent (parallel)
- tests don't need mocking
- follow clear naming conventions

### Bad
- tests for lack-of-error instead of covering actual feature
- use reflection to test private logic (tight coupling)
- swallow exception in "silent" catch section
- use setup or clean-up logic (high test complexity)
- tests work with external dependencies (logs, database etc.)
- focus on 100% code coverage

### Ugly
- if you don't write tests you show disrespect to your BA and QA teams
- if you have to mock a lot or tests are complex, it means you produce low-quality codebase

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="CaseStudy">Case study</a>
[<<](#Practices)[>>](#Untestable)

<br />
<br />

### Demo :hammer:
HeaderGeneratorTests

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />

## <a name="Untestable">How (not) to write untestable code</a>
[<<](#CaseStudy)

### Options
- write good code with tests
- write bad code and refactor before testing
- write bad code and use advanced tools for tests ($)

<br />
<br />

### Demo :hammer:
<br />
BookstoreAppService
<br />
procedure.sql in Samples

<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />