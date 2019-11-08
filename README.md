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

### Demo :hammer:

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
- It should be automated and repeatable.
- It should be easy to implement.
- It should be relevant tomorrow.
- Anyone should be able to run it at the push of a button.
- It should run quickly.
- It should be consistent in its results (it always returns the same result if you don’t change anything between runs).
- It should have full control of the unit under test.
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

## <a name="FinalDefinition">Final definition</a>
[<<](#Properties) [>>](#Types)

### Unit Test
A unit test is an automated piece of code that invokes the __unit of work__ being tested, and then checks some assumptions
about a single end result of that unit. 
<br />
A unit test is almost always written using a __unit testing framework__. It can be written easily and runs quickly.
<br />
It’s trustworthy, readable, and maintainable. It’s consistent in its results as long as production code hasn’t changed.

### Unit Test construction
- Arrange - initialize objects or services and prepare data
- Act - perform the unit of work
- Assert - compare actual result with expected value

<br />
<br />

### Demo :hammer:

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
[<<](#FinalDefinition)

### Types of unit tests
- Test / Fact - for testing single specific scenario with fixed input and output. Usually parameterless.
- Test Case / Theory - for testing the same part of code against multiple input and output data. Usually accepts some input parameters and expected value.

### Naming strategies
- Test / Fact - name consists of 3 parts:
  - ```UnitOfWorkName``` - the name of the method or group of methods or classes you’re testing
  - ```Scenario``` - the conditions under which the unit is tested, such as “bad login” or “invalid user” or “good password.” You could describe the parameters being sent to the public method or the initial state of the system when the unit of work is invoked such as “system out of memory” or “no users exist” or “user already exists”
  - ```ExpectedBehavior``` - what you expect the tested method to do under the specified conditions.
  This could be one of three possibilities:
    * return a value as a result (a real value, or an exception)
    * change the state of the system as a result (like adding a new user to the system, so the system behaves differently on the next login)
    * call a third-party system as a result (like an external web service)
<br />
Example: Calculate_NoInputData_ThrowsException()
<br />
<br />

- Test Case / Theory - name consists of 3 1 part with suffix: ```UnitOfWorkNameTest```
<br />
Example: CalculateTest(...)

<br />
<br />

### Demo :hammer:

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
