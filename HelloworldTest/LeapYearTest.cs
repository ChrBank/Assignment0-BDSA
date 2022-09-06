namespace HelloworldTest;

public class LeapYearTest
{
     [Fact]
    public void Check_If_Is_Leap_Year_1600_True()
    {
        // Arrange
        int year = 1600;
        LeapYear leapYear = new LeapYear();

        // Act
            bool leapYearBool = leapYear.IsLeapYear(year);
            
        // Assert
            leapYearBool.Should().Be(true);
    }
    [Fact]
    public void Check_If_Is_Leap_Year_1700_False()
    {
        // Arrange
        int year = 1700;
        LeapYear leapYear = new LeapYear();

        // Act
            bool leapYearBool = leapYear.IsLeapYear(year);
            
        // Assert
            leapYearBool.Should().Be(false);
    }

    [Fact]
    public void Check_If_Is_Leap_Year_100_False()
    {
        // Arrange
        int year = 100;
        LeapYear leapYear = new LeapYear();

        // Act
            bool leapYearBool = leapYear.IsLeapYear(year);
            
        // Assert
            leapYearBool.Should().Be(false);
    }

     [Fact]
    public void Check_Nay()
    {
        // Arrange
        int year = 100;
        LeapYear leapYear = new LeapYear();

        // Act
           string s = leapYear.YayOrNay(year);
            
        // Assert
            s.Should().Be("Nay");
    }

     [Fact]
    public void Check_Yay()
    {
        // Arrange
        int year = 2024;
        LeapYear leapYear = new LeapYear();

        // Act
           string s = leapYear.YayOrNay(year);
            
        // Assert
            s.Should().Be("Yay");
    }
}