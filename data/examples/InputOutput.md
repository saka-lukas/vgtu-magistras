Input(x):

ENVIRONMENT:
- Cursor
- Chat GPT 4-o, Gemini 2.5 Flash, Grok 4

UNVIERSAL PROMPT:
- Framework: .NET
- Assertion library: NUnit
- Unit tests should be generated only for described function.
- File and Function for which unit tests have to be generated

#1 Example

    STRATEGY NAME:
    Role-based prompting

    CONTEXT:
    - Role for AI (QA Automation Engineer, Dev etc...)

    PROMPT:
    You are Web Developer who develops interface for E-Commerce web page. Your task is to generate unit test code for public void CalculateTotalPrice() function.

#2 Example

    STRATEGY NAME:
    Template prompting

    CONTEXT:
    - Template for generating unit tests
    - Names of good practices

    PROMPT:
    Template of UI tests can be found in ./UnitTestsTemplate.cs.
    Use AAA (Arrange – Act – Assert) pattern; Names should be descriptive; One logical assertion per tests has to be used;

    Your task is to generate unit test code for public void CalculateTotalPrice() function.

    

Output(y):

Generated unit test code e.g:

    [Fact]
    public void Add_ReturnsSum()
    {
        // Arrange
        var a = 2;
        var b = 3;

        // Act
        var result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        // Arrange
        var a = 10;
        var b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
    }

Then this generated unit test code will be evaluated according this criteria:
- Test Smell
- Test Coverage 
- Generations
- Readability and Maintainability
- Test Mutation
