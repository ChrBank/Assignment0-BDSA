namespace HelloworldTest;

public class ProgramsTest
{
    [Fact]
    public void Main_when_run_prints_Hello_World()
    {
         // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(Helloworld));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello, World!");
    }
}