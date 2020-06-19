using System;
using System.Text.RegularExpressions;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType = "";
            int groupSize = 0;
            string result = "";

            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            vacationType = Console.ReadLine();

            Console.WriteLine("How many are in your group?");
            groupSize = Convert.ToInt32(Console.ReadLine());

            string destination = "";
            string travelSuggestion = "";
         
            if (vacationType == "musical")
            {
                destination = "New Orleans";
            }
            else if (vacationType == "tropical")
            {
                destination = "Beach Vacation in Mexico";
            }
            else if (vacationType == "tropical")
            {
                destination = "Whitewater Rafting the Grand Canyon";
            }


            if (groupSize == 1 || groupSize == 2)
            {
                travelSuggestion = "First Class";
            }
            else if (groupSize >= 3 && groupSize <= 5)
            {
                travelSuggestion = "Helicopter";
            }
            else if (groupSize >= 6)
            {
                travelSuggestion = "Charter Flight";
            }


            result = "Since you’re a group of " + groupSize + " going on a " + vacationType + " vacation, you should take a " +
                travelSuggestion + " to " + destination + ".";

            Console.WriteLine(result);
        }
    }
}
