namespace Helloworld{

    public class LeapYear{
        public string YayOrNay(int year){
            //Console.WriteLine("Type in a year to check if it is a leap year:");
            //year = Convert.ToInt32(Console.ReadLine());
            
            if(IsLeapYear(year)==true){
                //Console.WriteLine("Yay");
                return "Yay";
            } 
            else {
               // Console.WriteLine("Nay");
                return "Nay";
            }
        }
        public bool IsLeapYear(int year){
            if (year%4 == 0 && year%100 != 0){
                return true;
            } 
            if (year%4 == 0 && year%400 == 0){
                return true;
            } 
            return false;
        }
        //The Datetime.IsLeapYear(year) should work 
        public bool IsNumericTypeOfInt32(object year){
            if(year.GetType() == typeof(Int32)){
                return true;
            }
            throw new FormatException();
            return false;
        }

        public bool IsGreatThan1582(int year){
            if(year>1582){
                return true;
            }
            throw new IOException();
            return false;

        }
    }

}