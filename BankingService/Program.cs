namespace BankingService;

class Program
{

    
    
    static void Main(string[] args)
    {
        int option = 0;
        // Account Profile
        int accountNumber = 0;
        string holderName = "[Not Set]";
        double balance = 0.000;
        bool isActive = false;
        char accountType = '-';
        // customer profile
        bool isEmployed = false;
        double salary = 0.000;
        int creditScore = 0;
        int age = 0;
        // Transaction Data
        double deposit = 0.000;
        double withdrawal = 0.000;
        double annualRate = 0.000;
        double avgBalance = 0.000;
        
        Console.WriteLine("--- Account Profile ---");

        Console.WriteLine("1) Account Number (int) current: " + accountNumber );
        Console.WriteLine("2) Holder Name (string) current: " + holderName);
        Console.WriteLine("3) Balance (double) current: " + balance + "OMR");
        Console.WriteLine("4) Account Active? (bool) current: " + isActive + "[enter 1=yes / 0=no]");
        Console.WriteLine("5) Account Type (char) current: " + accountType + "[enter S / C / F]");
        Console.WriteLine("--- Customer Profile ---");
        Console.WriteLine("6) Employed? (bool) current: " + isEmployed + "[enter 1=yes / 0=no]");
        Console.WriteLine("7) Monthly Salary (double) current: " + salary + "OMR");
        Console.WriteLine("8) Credit Score (int) current: " + creditScore);
        Console.WriteLine("9) Age (int) current: " + age);
        Console.WriteLine("--- Transaction Data ---");
        Console.WriteLine("10) Last Deposit Amount (double) current:" + deposit + "OMR");
        Console.WriteLine("11) Last Withdrawal (double) current: " + withdrawal + "OMR" );
        Console.WriteLine("12) Annual Interest Rate (double) current: " + annualRate + "[e.g. 0.035 = 3.5%]" );
        Console.WriteLine("13) Avg Monthly Balance " + avgBalance + "OMR" );
        
        Console.WriteLine("");
        
        Console.WriteLine("0) Setup complete — launch Main Menu");

        Console.Write("please select an option from 0-13 ");
        option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1: 
                Console.WriteLine("Enter your Acc number");
                accountNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Account number set to: " + accountNumber);
                break;
            case 2:
                Console.Write("Enter holder name: ");
                holderName = Console.ReadLine();
                Console.WriteLine("Holder name set to: " + holderName);
                break;
            case 3:
                Console.WriteLine("Enter balance (OMR): ");
                balance = double.Parse(Console.ReadLine());
                Console.WriteLine("Balance set to: " + balance);
                break;
            case 4:
                Console.WriteLine("is your Account Active (0 = False, 1 = True)");
                int activeNum = int.Parse(Console.ReadLine());
                if (activeNum == 1)
                {
                    isActive = true;
                }
                else if(activeNum == 0)
                {
                    isActive = false;
                }
                else
                {
                    Console.WriteLine("invalid number");
                }
                Console.WriteLine("your account status set to: " + isActive);
                
                break;
            case 5:
                Console.WriteLine("Enter Account Type [enter S / C / F]");
                accountType = char.Parse(Console.ReadLine());
                if (accountType == 'S' || accountType == 'C' || accountType == 'F')
                {
                    Console.WriteLine("account type set to: " + accountType);
                }
                else
                {
                    Console.WriteLine("invalid Char");
                }
                break;
            case 6:
                Console.WriteLine("are you employed? [enter 1=yes / 0=no]");
                int employedNum = int.Parse(Console.ReadLine());
                if (employedNum == 0)
                {
                    isEmployed = false;
                }
                else if (employedNum == 1)
                {
                    isEmployed = true;
                }
                else
                {
                    Console.WriteLine("invaild number");
                }
                Console.WriteLine("emplyment status set to: " + isEmployed);
                break;
            case 0:
                Console.WriteLine("Setup complete. Launching Main Menu...");
                break;
        }



    }
}