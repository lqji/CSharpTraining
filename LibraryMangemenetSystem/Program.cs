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
        Console.WriteLine("");
        Console.Write("Enter your choice: ");
        option = Convert.ToInt32(Console.ReadLine());
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

    static void RegBook(string Title, string Author, int AvCopy ,string Genere = "Unspecfied" )
    {
        Console.Write("Enter Book Title: ");
        Title = Console.ReadLine().Trim();
        Console.Write("Enter Book Author name: ");
        Author = Console.ReadLine().Trim();
        Console.Write("Enter Number Of Copies: ");
        AvCopy = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Book Genere: ");
        Genere = Console.ReadLine().Trim();
        isBReg = true;
        bTitle = Title;
        bAuthor = Author;
        bAvCopy = AvCopy ;
        bGenere = Genere;
        
        Console.WriteLine("Book is Registerd Succesfully");
        
        Console.WriteLine("System Note: Title is " + bTitle.Length + " characters long.");
    }
    
static void Main(string[] args)
    {
 
        //system values
        bool exit = false;
        
        while (exit == false)
        {
            PrintMainMenu();
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
                    }
                    else
                    {
                        Console.WriteLine("there are no available copies");
                    }
                    break;
                case 5 :
                    
                    break;
                case 6 :
                    
                    break;
                case 7 :
                    
                    break;
                case 8 : // Registing a book
                    if (isBReg == true)
                    {
                        Console.WriteLine("book is already registerd");
                    }
                    else
                    {
                        RegBook(bTitle,bAuthor,bAvCopy,bGenere);
                    }
                    break;
                case 9 :
                    
                    break;
                case 10 :
                    
                    break;
                case 11 :
                    
                    break;
                case 12 :
                    
                    break;
                case 13 : //exit
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