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

    //Other
    static string booksearch;
    static void SearchBook()
    {
        Console.Write("Enter Book Name: ");
        booksearch = Console.ReadLine().Substring(1).ToLower();
        bTitle = bTitle.Substring(1).ToLower();
        
        if (booksearch == bTitle)
        {
            Console.WriteLine("Book: " + bTitle);
        }
        else
        {
            Console.WriteLine("Book Not Found");
        }
    }

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
        if (isMReg == true)
        {
            Console.WriteLine("Member is already registered");
        }
        else
        {
            Console.Write("Enter member name: ");
            mName = Console.ReadLine();
            Console.Write("Enter Member Email: ");
            mEmail = Console.ReadLine();
            RegDate = DateTime.Now;
        }
    }

    static void DisplayMemberInfo()
    {
        Console.WriteLine("Enter Member's Name");
        if (Console.ReadLine() == mName)
        { Console.WriteLine("---- Member Info -----");
            Console.WriteLine("");
            Console.WriteLine("Member Id: " + mId);
            Console.WriteLine("");
            Console.WriteLine("Member Name: " + mName);
            Console.WriteLine("");
            Console.WriteLine("Member Email: " + mEmail);
            Console.WriteLine("");
            Console.WriteLine("Member Register Date: " + Convert.ToString(RegDate));
            Console.WriteLine("");
        }
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
                case 0:
                    RegisterMember();
                    break;
                case 1:
                    DisplayMemberInfo();
                    break;
                case 2:
                    SearchBook();
                    break;
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }


    }
}