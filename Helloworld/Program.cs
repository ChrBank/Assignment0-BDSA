namespace Helloworld
{
    class Hello{
        public static void Main(string[] args){
            Console.WriteLine("Type in a year to check if it is a leap year:");
            LeapYear leapYear = new LeapYear();
            int year = Convert.ToInt32(Console.ReadLine());
            
            if(leapYear.IsLeapYear(year)==true){
                Console.WriteLine("Yay");
            } 
            else {
                Console.WriteLine("Nay");
            }

        }

    }

}