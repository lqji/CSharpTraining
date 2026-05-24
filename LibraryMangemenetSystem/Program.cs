namespace LibraryMangemenetSystem;

class Program
{
    //declaring values
    //member values
    static string mName = "";
    static int mId = 0;
    static string mEmail = "";
    static string mExpierD = "";
    static string mTier = "";
    static bool isMReg = false;
    static DateTime RegDate;

    //book values
    static string bTitle = "";
    static string bAuthor = "";
    static string bGenere = "";
    static int bAvCopy = 0;
    static bool isBReg = false;
    static int totalBBorow = 0;
    static int totalFPaid = 0;
    static int option = 1;





    static void PrintMainMenu()
    {
        Console.WriteLine("---- Welcome To The library ----");
        Console.WriteLine("");
        Console.WriteLine(" 0) Register Member ");
        Console.WriteLine(" 1) Display Member Profile ");
        Console.WriteLine(" 2) Search Book by Title ");
        Console.WriteLine(" 3) Borrow a Book ");
        Console.WriteLine(" 4) Return a Book ");
        Console.WriteLine(" 5) Calculate Late Fine ");
        Console.WriteLine(" 6) Apply Member Discount ");
        Console.WriteLine(" 7) Check Borrowing Eligibility ");
        Console.WriteLine(" 8) Register Book ");
        Console.WriteLine(" 9) Generate Member ID ");
        Console.WriteLine(" 10) Display Book Details ");
        Console.WriteLine(" 11) Calculate Renewal Fee ");
        Console.WriteLine(" 12) Update Member Email ");
        Console.WriteLine(" 13) Session Summary ");
        Console.WriteLine(" 14) Exit ");
        Console.WriteLine("");
    }

    static void RegisterMember()
    {
        Console.Write("Enter member name: ");
        mName = Console.ReadLine();
        Console.Write("Enter Member Email: ");
        mEmail = Console.ReadLine();
        RegDate = DateTime.Now;
        isMReg = true;
    }


    static void DisplayMemberInfo()
    {
        Console.WriteLine("---- Member Info -----");
        Console.WriteLine("");
        Console.WriteLine("Member Id: ".PadLeft(15) + " " + mId);
        Console.WriteLine("Member Name: ".PadLeft(15) + " " + mName);
        Console.WriteLine("Member Email: ".PadLeft(15) + " " + mEmail);
        Console.WriteLine("");
        Console.WriteLine("Member Register Date: ".PadLeft(15) + Convert.ToString(RegDate));
        Console.WriteLine("---------------------------");
    }

    static bool SearchBook(string searchKeyword)
    {
        string bTitleLow = bTitle.ToLower();
        string SKLOW = searchKeyword.ToLower();

        if (bTitleLow.Contains(SKLOW))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static void BorrowBook(ref int count)
    {
        count = Math.Max(count - 1, 0);
        //to increase the total books borowed number
        totalBBorow++;
    }

    static void RegBook(string title, string author, int avCopy, string genre = "Unspecified")
    {
        bTitle = title.Trim();
        bAuthor = author.Trim();
        bAvCopy = avCopy;
        bGenere = genre.Trim();
        
        
        Console.WriteLine("Book is Registerd Succesfully");
        
        Console.WriteLine("System Note: Title is " + bTitle.Length + " characters long.");
    }

    static void DisBook(string title, string author, int avCopy, string genre)
    {
        Console.WriteLine("---- Registered Book Details -----");
        Console.WriteLine("Title:".PadRight(15) + title);
        Console.WriteLine("Author:".PadRight(15) + author);
        Console.WriteLine("Copies:".PadRight(15) + Convert.ToString(avCopy));
        Console.WriteLine("Genre:".PadRight(15) + genre);
        Console.WriteLine("----------------------------------");
    }
    
static void Main(string[] args)
    {
 
        //system values
        bool exit = false;
        
        while (exit == false)
        {
            PrintMainMenu();
            Console.Write("Enter your choice: ");
            option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case 0: // registiring member
                    if (isMReg == true)
                    {
                        Console.WriteLine("User is Already Registered");
                    }
                    else
                    {
                        RegisterMember();

                    }
                    break;
                case 1: // Display member info
                    if (!isMReg)
                    {
                        Console.WriteLine("Member is not Registered");
                    }
                    else
                    {
                        DisplayMemberInfo();
                    }
                    break;
                case 2: //searching for a book
                    Console.Write("Enter a keyword to search for a book: ");
                    string keyword = Console.ReadLine();
                    bool isFound = SearchBook(keyword);
                    if (isFound)
                    {
                        Console.WriteLine("the book is Found");
                    }
                    else if (!isBReg)
                    {
                        Console.WriteLine("the book is not Registerd");
                    }
                    else
                    {
                        Console.WriteLine("Eror, ");
                    }
                    break;
                case 3: // Borowing a book
                    if (isBReg && bAvCopy > 0)
                    {
;
                        BorrowBook(ref bAvCopy);
                        Console.WriteLine("book borrowed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("there are no available copies");
                    }
                    break;
                case 4:
                    break;
                case 5 :
                    
                    break;
                case 6 :
                    
                    break;
                case 7 :
                    
                    break;
                case 8 : // Registing a book
                    Console.Write("Enter Book Title: ");
                    string inputTitle = Console.ReadLine();
                    Console.Write("Enter Book Author name: ");
                    string inputAuthor = Console.ReadLine();
                    Console.Write("Enter Number Of Copies: ");
                    int inputCopies = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Book Genre (or press Enter to skip): ");
                    string inputGenre = Console.ReadLine();
                    isBReg = true;
    
                    if (inputGenre == "")
                    {
                        RegBook(inputTitle, inputAuthor, inputCopies);
                    }
                    else
                    {
                        RegBook(inputTitle, inputAuthor, inputCopies, inputGenre);
                    }
                    break;
                case 9 : 
                    
                    
                    break;
                case 10 : // Display Book Info
                    if (isBReg == true)
                    {
                        DisBook(title: bTitle, author: bAuthor, avCopy: bAvCopy, genre: bGenere);
                    }
                    else
                    {
                        Console.WriteLine("No Book Registerd yet");
                    }
                    break;
                case 11 :
                    
                    break;
                case 12 :
                    
                    break;
                case 13 : //Session Summary 
             
                    break;
                case 14 : //Exit 
                    Console.WriteLine("Exiting...");
                    exit = true;
                    break;
                default : //invalid
                    Console.WriteLine("Invalid Option, Try Again");
                    break;
           
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

    }
}