namespace Helloworld
{
    class Hello{
        public static void Main(string[] args){
            try{
                Console.WriteLine("Type in a year and check if it is a leap year:");
                LeapYear leapYear = new LeapYear();
                int year = Convert.ToInt32(Console.ReadLine());
            
                leapYear.IsNumericTypeOfInt32(year);
                leapYear.IsGreatThan1582(year);
                
                if(leapYear.IsLeapYear(year)==true){
                    Console.WriteLine("Yay");
                } 
                else {
                    Console.WriteLine("Nay");
                } 
            } catch(FormatException){
                Console.WriteLine("Problem: Year is not an integer! Pls type in an interger instead!");
            } catch(IOException){
                Console.WriteLine("Year is not greater than 1582! Pls type in an interger greater than 1582!");
            } catch(Exception){
                Console.WriteLine("Something went wrong... pls try to run the program again...");
            }
        }

    }

}