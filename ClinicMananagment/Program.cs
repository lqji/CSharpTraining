using System.Diagnostics;

namespace ClinicMananagment;

class Program
{
    static void Main(string[] args)
    {
        // CMS (Clinic Management system)
        
        
                //Region 1 — System Storage: all variable declarations
                // Capacity constants
                const int MAX_PATIENTS = 3;
                const int MAX_DOCTORS = 2;
                const int MAX_APPOINTMENTS = 3;
// Patient slots
                string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
                string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
                string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;
                int patientCount = 0;
// Doctor slots
                string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
                string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;
                int doctorCount = 0;
// Appointment slots
                string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status =
                    ""; bool a1Active = false;
                string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status =
                    ""; bool a2Active = false;
                string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status =
                    ""; bool a3Active = false;
                int appointmentCount = 0;
                
                //Region 2 — Main Menu: the outer while loop + switch-case
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("╔══════════════════════════════════════╗");
                    Console.WriteLine("║      CLINIC MANAGEMENT SYSTEM        ║");
                    Console.WriteLine("╠══════════════════════════════════════╣");
                    Console.WriteLine("║  1. Patient Management               ║");
                    Console.WriteLine("║  2. Doctor Management                ║");
                    Console.WriteLine("║  3. Appointment Management           ║");
                    Console.WriteLine("║  0. Exit                             ║");
                    Console.WriteLine("╚══════════════════════════════════════╝");
                    Console.Write("Enter your choice: ");
                    int mainChoice = Convert.ToInt32(Console.ReadLine());
                    //Region 3 — Sub-Menus: one while loop per entity (inside the main menu switch-case case)

                    switch (mainChoice)
                    {
                        // patient management view
                        case 1:
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════════════╗");
                                Console.WriteLine("║        PATIENT MANAGEMENT            ║");
                                Console.WriteLine("╠══════════════════════════════════════╣");
                                Console.WriteLine("║  1. Add New Patient                  ║");
                                Console.WriteLine("║  2. Display All Patients             ║");
                                Console.WriteLine("║  3. Update Patient Phone             ║");
                                Console.WriteLine("║  4. Delete Patient                   ║");
                                Console.WriteLine("║  0. Back to Main Menu                ║");
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
                                            break;
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
                                                p1Name = inputPatName; p1Age = inputAge; p1Phone = inputPatPhone; p1Active = true;
                                            }
                                            else if (!p2Active)
                                            {
                                                p2Name = inputPatName; p2Age = inputAge; p2Phone = inputPatPhone; p2Active = true;
                                            }
                                            else if (!p3Active)
                                            {
                                                p3Name = inputPatName; p3Age = inputAge; p3Phone = inputPatPhone; p3Active = true;
                                            }
                                            Console.WriteLine("patient added Succefully");
                                         


                                            patientCount++;
                                            break;

                                        }
                                    case 2: // Diplaying patients
                                        if (patientCount == 0)
                                        {
                                            Console.WriteLine("No patients registered");
                                            break;
                                        }
                                      
                                        int num = 1;
                                            if (p1Active) { Console.WriteLine(num + ". " + p1Name + "age: " + p1Age + "phone num: " + p1Phone); num++; }
                                            if (p2Active) { Console.WriteLine(num + ". " + p2Name + "age: " + p2Age + "phone num: " + p2Phone); num++; }
                                            if (p3Active) { Console.WriteLine(num + ". " + p3Name + "age: " + p3Age + "phone num: " + p3Phone); num++; }
                                        break;
                                    case 3: // Updating patient phone
                                        Console.Write("Enter Patient Name: ");
                                        string targtPatName = Console.ReadLine();
                                        if (p1Active && p1Name == targtPatName)
                                        {
                                            Console.Write("Enter the patient new phone: ");
                                            string newPatPhone = Console.ReadLine();
                                            newPatPhone = p1Phone;
                                            Console.WriteLine("phone Updated");
                                        }
                                        else if (p2Active && p2Name == targtPatName)
                                        {
                                            Console.Write("Enter the patient new phone: ");
                                            string newPatPhone = Console.ReadLine();
                                            newPatPhone = p2Phone;
                                            Console.WriteLine("phone Updated");
                                        }
                                        else if (p3Active && p3Name == targtPatName)
                                        {
                                            Console.Write("Enter the patient new phone: ");
                                            string newPatPhone = Console.ReadLine();
                                            newPatPhone = p3Phone;
                                            Console.WriteLine("phone Updated");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Patient not found.");
                                        }
                                        break;
                                    case 4: // Delete Patient
                                        Console.Write("Enter patient number to delete it: ");
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
                                    case 0:
                                        Console.WriteLine("going back to main menu... ");
                                        break;
                                    default:
                                        Console.WriteLine("invalid input");
                                        break;
                                }
                                Console.WriteLine("Press Enter to continue...");
                                Console.ReadLine();
                                if (patientChoice == 0) break;
                                
                            }

                            break;
                        // doctor management view
                        case 2:
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════════════╗");
                                Console.WriteLine("║        DOCTOR MANAGEMENT             ║");
                                Console.WriteLine("╠══════════════════════════════════════╣");
                                Console.WriteLine("║  1. Add New Doctor                   ║");
                                Console.WriteLine("║  2. Display All Doctors              ║");
                                Console.WriteLine("║  3. Update Consultation Fee          ║");
                                Console.WriteLine("║  4. Delete Doctor                    ║");
                                Console.WriteLine("║  0. Back to Main Menu                ║");
                                Console.WriteLine("╚══════════════════════════════════════╝");
                                Console.Write("Enter your choice: ");
                                int doctorChoice = Convert.ToInt32(Console.ReadLine());
                                switch (doctorChoice)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        break;
                                    case 3:
                                        break;
                                    case 4:
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        
                                        break;
                                }
                            }
                            break;
                        //appointment management view
                        case 3:
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("╔══════════════════════════════════════╗");
                                Console.WriteLine("║      APPOINTMENT MANAGEMENT          ║");
                                Console.WriteLine("╠══════════════════════════════════════╣");
                                Console.WriteLine("║  1. Book New Appointment             ║");
                                Console.WriteLine("║  2. Display All Appointments         ║");
                                Console.WriteLine("║  3. Update Appointment Status        ║");
                                Console.WriteLine("║  4. Cancel Appointment               ║");
                                Console.WriteLine("║  0. Back to Main Menu                ║");
                                Console.WriteLine("╚══════════════════════════════════════╝");
                                Console.Write("Enter your choice: ");
                                int appointmentChoice = Convert.ToInt32(Console.ReadLine());
                                switch (appointmentChoice)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        break;
                                    case 3:
                                        break;
                                    case 4:
                                        break;
                                    case 0:
                                        break;
                                    default:

                                        break;
                                }
                            }

                            break;
                        case 0:
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("do NOT exit the program");
                            break;
                    }
                }
                
                
                
                //Region 4 — Operations: the if-else logic for each CRUD action
    }
}