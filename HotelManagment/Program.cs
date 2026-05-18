using System.ComponentModel;

namespace HotelManagment;

class Program
{
    static void Main(string[] args)
    {
        //declaring variables 
        string gName = "";
        string gPhone = "";
        int rNum = 0;
        string rType = "";
        double nightRate = 0;
        DateTime ChekInD = DateTime.Today ;
        DateTime CheckOutD = DateTime.Today;
        int nightNum = 0;
        string rNotes = "";
        float discount = 0;
        int loyalityPoints = 0;
        bool isGuestReg = false;
        bool isCheckedIn = false;
        
        bool exit = false;

        Console.WriteLine("(0) . Register New Guest ");
        Console.WriteLine("(1) . View Guest Information ");
        Console.WriteLine("(2) . Check-In Guest ");
        Console.WriteLine("(3) . Check-Out & Bill ");
        Console.WriteLine("(4) . Apply Discount  ");
        Console.WriteLine("(5) . Upgrade Room  ");
        Console.WriteLine("(6) . Add Room Service Note ");
        Console.WriteLine("(7) . Search Guest by Name ");
        Console.WriteLine("(8) . Calculate Loyalty Points  ");
        Console.WriteLine("(9) . Print Receipt ");
        Console.WriteLine("(10) . Edit Guest Name  ");
        Console.WriteLine("(11) . Exit  ");
        Console.Write("Enter Your Choice: ");
        int options = Convert.ToInt32(Console.ReadLine());

        while (exit = false)
        {
            switch (options)
            {
                
            }
        }


    }
}