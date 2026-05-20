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
        
    //book values
    static string bTitle = "";
    static string bAuthor = "";
    static string bGenere = "";
    static int bAvCopy = 0;
    static bool isBReg = false;
    static int totalBBorow = 0;
    static int totalFPaid = 0;

    static void PrintMainMenu()
    {
    }
    
    
    static void Main(string[] args)
    {
 
        //system values
        bool exit = false;
        int option = 1;
        
        while (exit == false)
        {
            PrintMainMenu();
            switch (option)
            {
                case 0:
                    break;
            }
        }


    }
}