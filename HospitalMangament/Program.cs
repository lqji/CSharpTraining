namespace HospitalMangament;

class Program
{
    static void Main(string[] args)
    {

        //declaring values
        const int MAX_PATIENTS = 3;
        string p1Name = "";
        int p1Age = 0;
        string p1Phone = "";
        bool p1Active = false;
        string p2Name = "";
        int p2Age = 0;
        string p2Phone = "";
        bool p2Active = false;
        string p3Name = "";
        int p3Age = 0;
        string p3Phone = "";
        bool p3Active = false;
        int patientCount = 0;
        bool exit = false;

            while (exit == false)
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════╗");
                Console.WriteLine("║        PATIENT MANAGEMENT            ║");
                Console.WriteLine("╠══════════════════════════════════════╣");
                Console.WriteLine("║  1. Add New Patient                  ║");
                Console.WriteLine("║  2. Display All Patients             ║");
                Console.WriteLine("║  3. Display One Patient              ║");
                Console.WriteLine("║  4. Update Patient Phone             ║");
                Console.WriteLine("║  5. Delete Patient                   ║");
                Console.WriteLine("║  0. Exit                             ║");
                Console.WriteLine("╚══════════════════════════════════════╝");
                Console.WriteLine("");
                Console.Write("Enter your choice: ");
                int patientChoice = Convert.ToInt32(Console.ReadLine());

                switch (patientChoice)
                {
                    case 1: // Adding patients

                        if (patientCount == MAX_PATIENTS)
                        {
                            Console.WriteLine("Clinic is full. Cannot add more patients.");
                        }
                        else
                        {
                            Console.Write("patient name: ");
                            string inputPatName = Console.ReadLine();
                            if (inputPatName == "")
                            {
                                Console.Write("error, invalid name");
                                break;
                            }

                            Console.Write("age: ");
                            int inputAge = Convert.ToInt32(Console.ReadLine());
                            if (inputAge < 1 || inputAge >= 120)
                            {
                                Console.WriteLine("error, invalid age");
                                break;
                            }

                            Console.Write("phone: ");
                            string inputPatPhone = Console.ReadLine();
                            if (!p1Active)
                            {
                                p1Name = inputPatName;
                                p1Age = inputAge;
                                p1Phone = inputPatPhone;
                                p1Active = true;
                            }
                            else if (!p2Active)
                            {
                                p2Name = inputPatName;
                                p2Age = inputAge;
                                p2Phone = inputPatPhone;
                                p2Active = true;
                            }
                            else if (!p3Active)
                            {
                                p3Name = inputPatName;
                                p3Age = inputAge;
                                p3Phone = inputPatPhone;
                                p3Active = true;
                            }
                            Console.WriteLine("patient added Succefully");
                            patientCount++;
                            break;
                        }
                        break;
                    case 2: // Diplaying patients
                        if (patientCount == 0)
                        {
                            Console.WriteLine("No patients registered");
                            break;
                        }
                        int num = 1;
                        if (p1Active)
                        {
                            Console.WriteLine(num + ". " + p1Name + " age: " + p1Age + " phone num: " + p1Phone);
                            num++;
                        }

                        if (p2Active)
                        {
                            Console.WriteLine(num + ". " + p2Name + " age: " + p2Age + " phone num: " + p2Phone);
                            num++;
                        }

                        if (p3Active)
                        {
                            Console.WriteLine(num + ". " + p3Name + " age: " + p3Age + " phone num: " +
                                              p3Phone);
                            num++;
                        }

                        break;
                    case 3: // Diplaying one patients
                        if (patientCount == 0)
                        {
                            Console.WriteLine("No patients registered");
                            break;
                        }
                        Console.Write("enter patients name: ");
                        string targetPat = Console.ReadLine();
                        if (targetPat == p1Name)
                        {
                            Console.WriteLine( ". " + p1Name + " age: " + p1Age + " phone num: " + p1Phone);
                        }

                        if (targetPat == p2Name)
                        {
                            Console.WriteLine(". " + p2Name + " age: " + p2Age + " phone num: " + p2Phone);
                        }

                        if (targetPat == p3Name)
                        {
                            Console.WriteLine( ". " + p3Name + " age: " + p3Age + " phone num: " + p3Phone);
                        }
                        break;
                    case 4: // Updating patient phone
                        Console.Write("Enter Patient Name: ");
                        string targtPatName = Console.ReadLine();
                        if (p1Active && p1Name == targtPatName)
                        {
                            Console.Write("Enter the patient new phone: ");
                            p1Phone = Console.ReadLine();
                            Console.WriteLine("phone Updated");
                        }
                        else if (p2Active && p2Name == targtPatName)
                        {
                            Console.Write("Enter the patient new phone: ");
                            p2Phone = Console.ReadLine();

                            Console.WriteLine("phone Updated");
                        }
                        else if (p3Active && p3Name == targtPatName)
                        {
                            Console.Write("Enter the patient new phone: ");
                            p3Phone = Console.ReadLine();
                            Console.WriteLine("phone Updated");
                        }
                        else
                        {
                            Console.WriteLine("Patient not found.");
                        }

                        break;
                    case 5: // Delete Patient
                        Console.Write("Enter patient name to delete it: ");
                        string delPatName = Console.ReadLine();
                        if (p1Active && delPatName == p1Name)
                        {
                            p1Active = false;
                            p1Name = "";
                            p1Age = 0;
                            p1Phone = "";
                            Console.WriteLine("patient deleted succesfully");
                        }
                        else if (p2Active && delPatName == p2Name)
                        {
                            p2Active = false;
                            p2Name = "";
                            p2Age = 0;
                            p2Phone = "";
                            Console.WriteLine("patient deleted succesfully");

                        }
                        else if (p3Active && delPatName == p3Name)
                        {
                            p3Active = false;
                            p3Name = "";
                            p3Age = 0;
                            p3Phone = "";
                            Console.WriteLine("patient deleted succesfully");

                        }
                        else
                        {
                            Console.WriteLine("patient not found");
                        }

                        break;
                    case 0: // Exit
                        Console.WriteLine("Exiting.. ");
                        exit = true;
                        break;
                    default: // invalid
                        Console.WriteLine("invalid input");
                        break;
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadKey();
            }
        }
    }


                
