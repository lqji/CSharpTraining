namespace BankingService;

class Program
{
    static void Main(string[] args)
    {
    
        {
            
        }
        
        int option = 1;
        int ATMOptions = 1;
        int bankOptions = 1;

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

      //Authintication
      const int correctPin = 4821;
      int MaxAttempts = 3;
      bool userLoggedIn = false;
      int PinOptions = 1;

      //transaction
      bool transactionIsTriggerd = false;


      while (bankOptions != 0)
      {

          Console.WriteLine("--- Welcome to NBO ---");
          Console.WriteLine("");
          Console.WriteLine("Unified Banking System v1.0");
          Console.WriteLine("");
          Console.WriteLine("Customer : " + holderName);
          Console.WriteLine("Balance :" + balance + "OMR");
          Console.WriteLine("");
          Console.WriteLine("1) ATM Services");
          Console.WriteLine("");
          Console.WriteLine("2) Account Management");
          Console.WriteLine("");
          Console.WriteLine("3) Loan Services");
          Console.WriteLine("");
          Console.WriteLine("4) Currency Exchange");
          Console.WriteLine("");
          Console.WriteLine("5) Credit Card Portal");
          Console.WriteLine("");
          Console.WriteLine("6) Branch Services");
          Console.WriteLine("");
          Console.WriteLine("7) Reports & Admin");
          Console.WriteLine("");
          Console.WriteLine("0) Exit");
          Console.WriteLine("");
          Console.WriteLine("Select module: _");
          bankOptions = int.Parse(Console.ReadLine());

          switch (bankOptions)
          {

              case 1: //Task 2
                  ATMOptions = 1;
                  while (ATMOptions != 0)

                  {
                      Console.WriteLine("=== ATM SERVICES ===");
                      Console.WriteLine("");
                      Console.WriteLine("1) Bank Info");
                      Console.WriteLine("");
                      Console.WriteLine("2) Branch Info");
                      Console.WriteLine("");
                      Console.WriteLine("3) Opening Hours");
                      Console.WriteLine("");
                      Console.WriteLine("0) Back to Main Menu");
                      Console.WriteLine("");


                      Console.WriteLine("Select ");
                      ATMOptions = int.Parse(Console.ReadLine());
                      switch (ATMOptions)
                      {
                          //printing bank info
                          case 1:
                              Console.WriteLine("Bank Name: National Bank of Oman");
                              Console.WriteLine("Tagline: Unlocking opportunities, as one.");
                              Console.WriteLine("Founding Year: 1973");
                              break;
                          //printing branch info

                          case 2:
                              Console.WriteLine("Branch Name: Head Office");
                              Console.WriteLine("City: Muscat");
                              Console.WriteLine("Address: Al Azaiba, 18th November St, NBO Building");
                              break;
                          //printing working hours info

                          case 3:
                              Console.WriteLine("Weekday (Sunday – Thursday)  -  Working Hours: 8:00 AM – 2:00 PM");
                              Console.WriteLine("Weekend (Friday – Saturday)  -  Working Hours: Closed");
                              break;
                          //printing working hours info

                          case 0:
                              Console.WriteLine("Returning to Main Menu...");
                              break;
                          default:
                              Console.WriteLine("Invalid selection. Please try again.");
                              break;

                      }

                  }

                  break;
              case 2:
                  //Task1
                  option = 1;
                  while (option != 0)
                  {
                      Console.WriteLine("--- Account Profile ---");

                      Console.WriteLine("1) Account Number (int) current: " + accountNumber);
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
                      Console.WriteLine("11) Last Withdrawal (double) current: " + withdrawal + "OMR");
                      Console.WriteLine(
                          "12) Annual Interest Rate (double) current: " + annualRate + "[e.g. 0.035 = 3.5%]");
                      Console.WriteLine("13) Avg Monthly Balance " + avgBalance + "OMR");

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
                              Console.WriteLine("Balance set to: " + balance + "OMR");
                              break;
                          case 4:
                              Console.WriteLine("is your Account Active (0 = False, 1 = True)");
                              int activeNum = int.Parse(Console.ReadLine());
                              if (activeNum == 1)
                              {
                                  isActive = true;
                              }
                              else if (activeNum == 0)
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
                          case 7:
                              Console.WriteLine("Enter your salary: ");
                              salary = double.Parse(Console.ReadLine());
                              Console.WriteLine("salary is set to :" + salary + "OMR");
                              break;
                          case 8:
                              Console.WriteLine("Enter you credit Score: ");
                              creditScore = int.Parse(Console.ReadLine());
                              Console.WriteLine("credit score is set to :" + creditScore);
                              break;
                          case 9:
                              Console.WriteLine("Enter your age");
                              age = int.Parse(Console.ReadLine());
                              Console.WriteLine("age is set to: " + age);
                              break;
                          case 10:
                              Console.WriteLine("Enter your last deposit amount ");
                              deposit = double.Parse(Console.ReadLine());
                              Console.WriteLine("deposit amount is set to " + deposit + "OMR");
                              break;
                          case 11:
                              Console.WriteLine("Enter your last withdrawl amount ");
                              withdrawal = double.Parse(Console.ReadLine());
                              Console.WriteLine("withdrawl amount is set to " + withdrawal + "OMR");
                              break;
                          case 12:
                              Console.WriteLine("enter you annual rate");
                              annualRate = int.Parse(Console.ReadLine());
                              Console.WriteLine("annual rate is set to " + annualRate + "OMR");
                              break;
                          case 13:
                              Console.WriteLine("enter your average monthly balance");
                              avgBalance = double.Parse(Console.ReadLine());
                              Console.WriteLine("the average montly balance is set to " + avgBalance + "OMR");
                              break;
                          case 0:
                              Console.WriteLine("Setup complete. Launching Main Menu...");
                              break;
                          default:
                              Console.WriteLine("Invalid selection. Please try again.");
                              break;

                      }
                  }

                  break;
              case 3:
                  option = 1;
                  while (option != 0)
                  {

                  }

                  break;
              case 4:
                  while (option != 0)
                  {

                  }

                  break;
              case 5:
                  while (option != 0)
                  {

                  }

                  break;
              case 6:
                  while (option != 0)
                  {

                  }

                  break;
              case 7:
                  while (option != 0)
                  {

                  }

                  break;
              case 0:

                  break;

          }

          //Task 3
          if (ATMOptions == 2)
          {
              Console.WriteLine("=== VIEW ACCOUNT DATA ===");
              Console.WriteLine("");
              Console.WriteLine("Data loaded from system setup");
              Console.WriteLine("");
              Console.WriteLine("1) Account Number → " + accountNumber);
              Console.WriteLine("");
              Console.WriteLine("2) Holder Name → " + holderName);
              Console.WriteLine("");
              Console.WriteLine("3) Balance → " + balance + "OMR");
              Console.WriteLine("");
              Console.WriteLine("4) Account Status → " + accountNumber);
              Console.WriteLine("");
              Console.WriteLine("5) Account Type → " + accountType);
              Console.WriteLine("");
              Console.WriteLine("0) Back");
              Console.WriteLine("");
              Console.WriteLine("Select field: _");
              int accDataNum = int.Parse(Console.ReadLine());
              switch (accDataNum)
              {
                  case 1:
                      Console.WriteLine("1) Account Number → " + accountNumber);
                      break;
                  case 2:
                      Console.WriteLine("2) Holder Name → " + holderName);
                      break;
                  case 3:
                      Console.WriteLine("3) Balance → " + balance + "OMR");
                      break;
                  case 4:
                      Console.WriteLine("4) Account Status → " + accountNumber);
                      break;
                  case 5:
                      Console.WriteLine("5) Account Type → " + accountType);
                      break;
                  case 0:
                      Console.WriteLine("Returning to Main Menu...");
                      break;
                  default:
                      Console.WriteLine("Field not available.");
                      break;

              }
          }

          if (transactionIsTriggerd = true)
          {
              Console.WriteLine("=== AUTHENTICATION ===");
              Console.WriteLine("");
              Console.WriteLine("1) Enter PIN");
              Console.WriteLine("");
              Console.WriteLine("2) Forgot PIN");
              Console.WriteLine("");
              Console.WriteLine("0) Back");
              Console.WriteLine("");
              Console.WriteLine("Select: _");
              int pin = 1;
              while (userLoggedIn == false)
              {
                  switch (PinOptions)
                  {
                      case 1:
                          Console.WriteLine("");
                          Console.Write("> Enter PIN: ");
                          pin = int.Parse(Console.ReadLine());
                          if (pin == correctPin && MaxAttempts > 0)
                          {
                              Console.WriteLine("Access granted. Welcome, " + holderName);
                              userLoggedIn = true;
                          }
                          else if (pin.ToString().Length != 4)
                          {
                              Console.WriteLine("Invalid PIN Format");

                          }
                          else if (pin != correctPin && MaxAttempts > 0)
                          {
                              MaxAttempts = MaxAttempts - 1;
                              Console.WriteLine("try again, remaining Attempts: " + MaxAttempts);
                              userLoggedIn = false;

                          }
                          else
                          {
                              Console.WriteLine("card is blocked, please visit your nearest branch");
                              userLoggedIn = false;

                          }

                          break;
                      case 2:
                          Console.WriteLine("Please visit the nearest branch with your National ID.");
                          break;
                      case 0:
                          Console.WriteLine("returning back to main menu");
                          break;
                  }
              }
          }

      }

    }
    }
