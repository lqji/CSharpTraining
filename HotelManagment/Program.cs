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
        int options;
        bool exit = false;
        

        while (exit == false)
        {
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
            Console.WriteLine("");
            Console.Write("Enter Your Choice: ");
            options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 0:
                    if (isGuestReg == true)
                    {
                        Console.WriteLine("guest already have been registered");
                    }
                    else
                    {
                        Console.Write("Enter guest's name: ");
                        gName = Console.ReadLine();
                        Console.Write("Enter guest's phone number: ");
                        gPhone = Console.ReadLine();
                        Console.Write("Choose Room Type: ");
                        rType = Console.ReadLine();
                        Console.Write("Nightly rate: ");
                        nightRate = Convert.ToDouble(Console.ReadLine());
                        rNum = Random.Shared.Next(1, 505);
                        Console.Write("Enter Room Notes: ");
                        rNotes = Console.ReadLine();
                        Console.Write("Enter how many nights guest is staying: ");
                        nightNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Discount: ");
                        discount =float.Parse(Console.ReadLine());
                        isGuestReg = true;
                    }
                    
                    break;
                case 1:
                    if (isGuestReg == false)
                    {
                        Console.WriteLine("No Guests Registered ");
                    }
                    else
                    {
                        Console.WriteLine("---- Guest Details ----");
                        Console.WriteLine("");
                        Console.WriteLine("Guest name: " + gName.ToUpper());
                        Console.WriteLine("Guest Phone number: " + gPhone);
                        Console.WriteLine("Room Type: " + rType);
                        Console.WriteLine("Room Number: " + Convert.ToString(rNum));
                        Console.WriteLine("Room Notes: " + rNotes);
                        Console.WriteLine("Check In Date: " + Convert.ToString(ChekInD));
                        Console.WriteLine("Check Out Date: " + Convert.ToString(CheckOutD));
                        Console.WriteLine("Nightly Rates: " + Convert.ToString(Math.Round(nightRate)));
                        Console.WriteLine("Nights Staying: " + Convert.ToString(nightNum));
                        Console.WriteLine("Discount: " + Convert.ToString(discount));
                    }
                  
                    break;
                case 2:
                    if (isGuestReg == false)
                    {
                        Console.WriteLine("No Guests Registered ");

                    }
                    else
                    {
                        ChekInD = DateTime.Today;
                        CheckOutD = ChekInD.AddDays(nightNum);
                        isCheckedIn = true;
                        Console.WriteLine("Guest is Checked in at: " + ChekInD.ToString());
                    }
                    
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11: //Exit
                    Console.WriteLine("Exiting...");
                    exit = true;
                    break;
            }

            
            Console.WriteLine("press any key to continue..");
            Console.ReadKey();
            Console.Clear();

            
           
        }
       

    }
}