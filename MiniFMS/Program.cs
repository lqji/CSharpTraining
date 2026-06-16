namespace MiniFMS;

class Program
{
    //VARIABLES 
 
    static List<string> passengerNames = new List<string>() { "Ahmed Al-Balushi", "Fatma Al-Riyami", "Mohammed Al-Siyabi", "Aisha Al-Zadjali", "Omar Al-Kharusi" };

    static List<string> ticketNumbers = new List<string>() { "TKT-001", "TKT-002", "TKT-003", "TKT-004", "TKT-005" };

    static string[] flightNumbers = new string[] { "OA101", "OA102", "OA103", "OA104", "OA105", "OA106" };

    static List<string> availableDates = new List<string>()
        { "12-Jan-2026", "15-Feb-2026", "20-Mar-2026", "10-Apr-2026" };

    static Dictionary<string, string> bookingRecord = new Dictionary<string, string>();
    static Queue<string> checkedInQueue = new Queue<string>();
    static Stack<string> boardingStack = new Stack<string>();
    static List<string> cancelledTickets = new List<string>();
    static Dictionary<string, string> passengerSeatMap = new Dictionary<string, string>();
    static Queue<string> waitlistQueue = new Queue<string>();

    // Sequential Seat tracking variables
    static int currentSeatRow = 10;
    static char currentSeatLetter = 'A';

    // Boarding log tracking 
    static List<string> boardedHistoryNames = new List<string>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("   SKY WINGS FLIGHT MANAGEMENT SYSTEM   ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Register New Passenger");
            Console.WriteLine("2. View All Passengers");
            Console.WriteLine("3. Book a Flight Ticket");
            Console.WriteLine("4. View Booking Details");
            Console.WriteLine("5. Update a Booking");
            Console.WriteLine("6. Cancel a Ticket");
            Console.WriteLine("7. Passenger Check-In");
            Console.WriteLine("8. Board Passengers (Boarding Stack)");
            Console.WriteLine("9. Generate Flight Manifest");
            Console.WriteLine("10. Manage Waitlist & Seat Assignment");
            Console.WriteLine("0. Exit");
            Console.WriteLine("========================================");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": ExecuteCase01(); break;
                case "2": ExecuteCase02(); break;
                case "3": ExecuteCase03(); break;
                case "4": ExecuteCase04(); break;
                case "5": ExecuteCase05(); break;
               case "6": ExecuteCase06(); break;
             //    case "7": ExecuteCase07(); break;
             //    case "8": ExecuteCase08(); break;
             //    case "9": ExecuteCase09(); break;
             //    case "10": ExecuteCase10(); break;
                case "0": running = false; break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 10.");
                    break;
            }
        }
        static void ExecuteCase01()
        {
            Console.WriteLine("--- [Case 01] Register New Passenger ---");
            Console.Write("Enter passenger full name: ");
            string name = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Error: Name cannot be empty.");
                return;
            }

            // Manual case-insensitive duplication check (No LINQ)
            for (int i = 0; i < passengerNames.Count; i++)
            {
                if (passengerNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Error: A passenger with this name already exists.");
                    return;
                }
            }

            // Auto-generate ticket index format TKT-XXX
            int nextSequenceNumber = passengerNames.Count + 1;
            string ticketId = "TKT-" + nextSequenceNumber.ToString("D3");

            passengerNames.Add(name);
            ticketNumbers.Add(ticketId);

            Console.WriteLine($"Success: Passenger '{name}' registered with Ticket ID: {ticketId}");
        }
        static void ExecuteCase02()
        {
            Console.WriteLine("--- [Case 02] View All Passengers ---");
            if (passengerNames.Count == 0)
            {
                Console.WriteLine("No passengers registered yet.");
                return;
            }

            Console.WriteLine(string.Format("{0,-4} | {1,-20} | {2,-10} | {3,-10}", "No.", "Passenger Name", "Ticket ID", "Status"));
            Console.WriteLine(new string('-', 55));

            for (int i = 0; i < passengerNames.Count; i++)
            {
                string tkt = ticketNumbers[i];
                string status = "Active";

                // Manual check for cancellation status
                for (int c = 0; c < cancelledTickets.Count; c++)
                {
                    if (cancelledTickets[c] == tkt)
                    {
                        status = "CANCELLED";
                        break;
                    }
                }

                Console.WriteLine(string.Format("{0,-4} | {1,-20} | {2,-10} | {3,-10}", i + 1, passengerNames[i], tkt, status));
            }

            Console.WriteLine(new string('-', 55));
            Console.WriteLine($"Total Passengers Registered: {passengerNames.Count}");
        }
        static void ExecuteCase03()
    {
        Console.WriteLine("--- [Case 03] Book a Flight Ticket ---");
        Console.Write("Enter Ticket ID (e.g., TKT-001): ");
        string tkt = Console.ReadLine().Trim().ToUpper();

        // Validate structural existence
        int targetIndex = -1;
        for (int i = 0; i < ticketNumbers.Count; i++)
        {
            if (ticketNumbers[i] == tkt)
            {
                targetIndex = i;
                break;
            }
        }

        if (targetIndex == -1)
        {
            Console.WriteLine("Error: Ticket ID does not exist.");
            return;
        }

        // Check for cancellations
        for (int i = 0; i < cancelledTickets.Count; i++)
        {
            if (cancelledTickets[i] == tkt)
            {
                Console.WriteLine("Error: Cannot book a flight for a cancelled ticket.");
                return;
            }
        }

        // Check for existing booking
        if (bookingRecord.ContainsKey(tkt))
        {
            Console.WriteLine("Error: Ticket already has a booking. Use Case 05 to update.");
            return;
        }

        // Select Flight Code
        Console.WriteLine("\nAvailable Flights:");
        for (int i = 0; i < flightNumbers.Length; i++)
        {
            Console.WriteLine($"[{i}] {flightNumbers[i]}");
        }
        Console.Write("Select flight index: ");
        if (!int.TryParse(Console.ReadLine(), out int flightIndex) || flightIndex < 0 || flightIndex >= flightNumbers.Length)
        {
            Console.WriteLine("Error: Invalid flight selection.");
            return;
        }

        // Select Travel Date
        Console.WriteLine("\nAvailable Booking Dates:");
        for (int i = 0; i < availableDates.Count; i++)
        {
            Console.WriteLine($"[{i}] {availableDates[i]}");
        }
        Console.Write("Select date index: ");
        if (!int.TryParse(Console.ReadLine(), out int dateIndex) || dateIndex < 0 || dateIndex >= availableDates.Count)
        {
            Console.WriteLine("Error: Invalid date selection.");
            return;
        }

        // Persist to Dictionary
        string flightChoice = flightNumbers[flightIndex];
        string dateChoice = availableDates[dateIndex];
        string compositeValue = flightChoice + "|" + dateChoice;

        bookingRecord[tkt] = compositeValue;

        Console.WriteLine("\nBooking Confirmed!");
        Console.WriteLine($"Ticket: {tkt} | Passenger: {passengerNames[targetIndex]} | Flight: {flightChoice} | Date: {dateChoice}");
    }
        static void ExecuteCase04()
        {
            Console.WriteLine("--- [Case 04] View Booking Details ---");
            Console.Write("Enter Ticket ID: ");
            string tkt = Console.ReadLine().Trim().ToUpper();

            int targetIndex = -1;
            for (int i = 0; i < ticketNumbers.Count; i++)
            {
                if (ticketNumbers[i] == tkt)
                {
                    targetIndex = i;
                    break;
                }
            }

            if (targetIndex == -1)
            {
                Console.WriteLine("Error: Ticket ID not found.");
                return;
            }

            for (int i = 0; i < cancelledTickets.Count; i++)
            {
                if (cancelledTickets[i] == tkt)
                {
                    Console.WriteLine("Status Notice: This ticket has been cancelled.");
                    return;
                }
            }

            
            if (!bookingRecord.ContainsKey(tkt))
            {
                Console.WriteLine("No booking found for this ticket.");
                return;
            }

            string rawRecord = bookingRecord[tkt];
            string[] tokens = rawRecord.Split('|');
            string flight = tokens[0];
            string date = tokens[1];

            Console.WriteLine("\n========================================");
            Console.WriteLine("             BOARDING CARD              ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Passenger Name : {passengerNames[targetIndex]}");
            Console.WriteLine($"Ticket ID      : {tkt}");
            Console.WriteLine($"Assigned Flight: {flight}");
            Console.WriteLine($"Departure Date : {date}");
            Console.WriteLine("========================================");
        }
        static void ExecuteCase05()
    {
        Console.WriteLine("--- [Case 05] Update a Booking ---");
        Console.Write("Enter Ticket ID: ");
        string tkt = Console.ReadLine().Trim().ToUpper();

        if (!bookingRecord.ContainsKey(tkt))
        {
            Console.WriteLine("Error: Only tickets with an existing booking can be updated.");
            return;
        }

        for (int i = 0; i < cancelledTickets.Count; i++)
        {
            if (cancelledTickets[i] == tkt)
            {
                Console.WriteLine("Error: Cancelled tickets cannot be updated.");
                return;
            }
        }

        string currentRecord = bookingRecord[tkt];
        string[] currentTokens = currentRecord.Split('|');
        string currentFlight = currentTokens[0];
        string currentDate = currentTokens[1];

        Console.WriteLine($"\nCurrent Booking State: Flight {currentFlight} on {currentDate}");
        Console.WriteLine("1. Change flight only\n2. Change date only\n3. Change both\n0. Cancel update");
        Console.Write("Select update mode: ");
        string subChoice = Console.ReadLine();

        if (subChoice == "0")
        {
            Console.WriteLine("Update aborted.");
            return;
        }

        string nextFlight = currentFlight;
        string nextDate = currentDate;

        if (subChoice == "1" || subChoice == "3")
        {
            Console.WriteLine("\nAvailable Flights:");
            for (int i = 0; i < flightNumbers.Length; i++) Console.WriteLine($"[{i}] {flightNumbers[i]}");
            Console.Write("Select flight index: ");
            if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 0 && idx < flightNumbers.Length)
                nextFlight = flightNumbers[idx];
            else { Console.WriteLine("Invalid input. Aborting."); return; }
        }

        if (subChoice == "2" || subChoice == "3")
        {
            Console.WriteLine("\nAvailable Dates:");
            for (int i = 0; i < availableDates.Count; i++) Console.WriteLine($"[{i}] {availableDates[i]}");
            Console.Write("Select date index: ");
            if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 0 && idx < availableDates.Count)
                nextDate = availableDates[idx];
            else { Console.WriteLine("Invalid input. Aborting."); return; }
        }

        bookingRecord[tkt] = nextFlight + "|" + nextDate;

        Console.WriteLine("\nUpdate Execution Confirmed!");
        Console.WriteLine(string.Format("{0,-25} | {1,-25}", "OLD BOOKING", "NEW BOOKING"));
        Console.WriteLine(string.Format("{0,-25} | {1,-25}", $"{currentFlight} ({currentDate})", $"{nextFlight} ({nextDate})"));
    }
        static void ExecuteCase06()
    {
        Console.WriteLine("--- [Case 06] Cancel a Ticket ---");
        Console.Write("Enter Ticket ID to cancel: ");
        string tkt = Console.ReadLine().Trim().ToUpper();

        int targetIndex = -1;
        for (int i = 0; i < ticketNumbers.Count; i++)
        {
            if (ticketNumbers[i] == tkt) { targetIndex = i; break; }
        }

        if (targetIndex == -1)
        {
            Console.WriteLine("Error: Ticket ID execution failed. Not found.");
            return;
        }

        for (int i = 0; i < cancelledTickets.Count; i++)
        {
            if (cancelledTickets[i] == tkt)
            {
                Console.WriteLine("Error: A ticket already inside cancelled registry cannot be re-cancelled.");
                return;
            }
        }

        string passengerName = passengerNames[targetIndex];

        if (bookingRecord.ContainsKey(tkt))
        {
            bookingRecord.Remove(tkt);
            Console.WriteLine($"[System Update]: Active booking link dropped for {tkt}.");
        }

        cancelledTickets.Add(tkt);

        Queue<string> tempQueue = new Queue<string>();
        bool queueRemoved = false;
        while (checkedInQueue.Count > 0)
        {
            string item = checkedInQueue.Dequeue();
            if (item.Equals(passengerName, StringComparison.OrdinalIgnoreCase))
                queueRemoved = true;
            else
                tempQueue.Enqueue(item);
        }
        checkedInQueue = tempQueue;
        if (queueRemoved) Console.WriteLine($"[Queue Evacuation]: '{passengerName}' removed from Check-In Queue.");

        Stack<string> intermediateStack = new Stack<string>();
        Stack<string> tempStack = new Stack<string>();
        bool stackRemoved = false;

        while (boardingStack.Count > 0)
        {
            string p = boardingStack.Pop();
            if (p.Equals(passengerName, StringComparison.OrdinalIgnoreCase))
                stackRemoved = true;
            else
                intermediateStack.Push(p); 
        }
        while (intermediateStack.Count > 0)
        {
            tempStack.Push(intermediateStack.Pop()); 
        }
        boardingStack = tempStack;
        if (stackRemoved) Console.WriteLine($"[Stack Evacuation]: '{passengerName}' dropped out from Boarding Stack.");

        Console.WriteLine($"\nCancellation complete for: {passengerName} ({tkt})");
    }
    }
}