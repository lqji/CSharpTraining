namespace ClinicManegment;

class Program
{
    static void Main(string[] args)
    {
                // ══════════════════════════════════════════════════════════════
        // ── REGION 1: System Storage ──────────────────────────────────
        // ══════════════════════════════════════════════════════════════

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
        string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status = ""; bool a1Active = false;
        string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status = ""; bool a2Active = false;
        string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status = ""; bool a3Active = false;
        int appointmentCount = 0;

        // ══════════════════════════════════════════════════════════════
        // ── REGION 2: Main Menu ───────────────────────────────────────
        // ══════════════════════════════════════════════════════════════

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

            switch (mainChoice)
            {
                // ══════════════════════════════════════════════════════
                // ── REGION 3: Patient Sub-Menu ─────────────────────────
                // ══════════════════════════════════════════════════════
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
                        Console.Write("Enter your choice: ");

                        int patChoice = Convert.ToInt32(Console.ReadLine());

                        // ── REGION 4: Patient Operations ──────────────
                        switch (patChoice)
                        {
                            // ADD Patient
                            case 1:
                                Console.WriteLine("\n── Add New Patient ──");

                                if (patientCount == MAX_PATIENTS)
                                {
                                    Console.WriteLine("Clinic is full. Cannot add more patients.");
                                    break;
                                }

                                Console.Write("Enter patient name: ");
                                string newPName = Console.ReadLine();
                                if (newPName == "")
                                {
                                    Console.WriteLine("Error: Name cannot be empty.");
                                    break;
                                }

                                Console.Write("Enter patient age: ");
                                int newPAge = Convert.ToInt32(Console.ReadLine());
                                if (newPAge < 1 || newPAge > 120)
                                {
                                    Console.WriteLine("Error: Age must be between 1 and 120.");
                                    break;
                                }

                                Console.Write("Enter patient phone: ");
                                string newPPhone = Console.ReadLine();

                                if (!p1Active)
                                {
                                    p1Name = newPName; p1Age = newPAge; p1Phone = newPPhone; p1Active = true;
                                }
                                else if (!p2Active)
                                {
                                    p2Name = newPName; p2Age = newPAge; p2Phone = newPPhone; p2Active = true;
                                }
                                else if (!p3Active)
                                {
                                    p3Name = newPName; p3Age = newPAge; p3Phone = newPPhone; p3Active = true;
                                }

                                patientCount++;
                                Console.WriteLine("Patient added successfully.");
                                break;

                            // DISPLAY ALL Patients
                            case 2:
                                Console.WriteLine("\n── Patient List ──");

                                if (patientCount == 0)
                                {
                                    Console.WriteLine("No patients registered.");
                                    break;
                                }

                                int pDisplayNum = 1;

                                if (p1Active)
                                {
                                    Console.WriteLine("─────────────────────────────────────────");
                                    Console.WriteLine(" Patient #" + pDisplayNum);
                                    Console.WriteLine(" Name  : " + p1Name);
                                    Console.WriteLine(" Age   : " + p1Age);
                                    Console.WriteLine(" Phone : " + p1Phone);
                                    pDisplayNum++;
                                }
                                if (p2Active)
                                {
                                    Console.WriteLine("─────────────────────────────────────────");
                                    Console.WriteLine(" Patient #" + pDisplayNum);
                                    Console.WriteLine(" Name  : " + p2Name);
                                    Console.WriteLine(" Age   : " + p2Age);
                                    Console.WriteLine(" Phone : " + p2Phone);
                                    pDisplayNum++;
                                }
                                if (p3Active)
                                {
                                    Console.WriteLine("─────────────────────────────────────────");
                                    Console.WriteLine(" Patient #" + pDisplayNum);
                                    Console.WriteLine(" Name  : " + p3Name);
                                    Console.WriteLine(" Age   : " + p3Age);
                                    Console.WriteLine(" Phone : " + p3Phone);
                                    pDisplayNum++;
                                }
                                Console.WriteLine("─────────────────────────────────────────");
                                break;

                            // UPDATE Patient Phone
                            case 3:
                                Console.WriteLine("\n── Update Patient Phone ──");
                                Console.Write("Enter patient name to update: ");
                                string updPName = Console.ReadLine();

                                if (p1Active && p1Name == updPName)
                                {
                                    Console.Write("Enter new phone: ");
                                    p1Phone = Console.ReadLine();
                                    Console.WriteLine("Updated successfully.");
                                }
                                else if (p2Active && p2Name == updPName)
                                {
                                    Console.Write("Enter new phone: ");
                                    p2Phone = Console.ReadLine();
                                    Console.WriteLine("Updated successfully.");
                                }
                                else if (p3Active && p3Name == updPName)
                                {
                                    Console.Write("Enter new phone: ");
                                    p3Phone = Console.ReadLine();
                                    Console.WriteLine("Updated successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Patient not found.");
                                }
                                break;

                            // DELETE Patient
                            case 4:
                                Console.WriteLine("\n── Delete Patient ──");
                                Console.Write("Enter patient name to delete: ");
                                string delPName = Console.ReadLine();

                                if (p1Active && p1Name == delPName)
                                {
                                    p1Active = false; p1Name = ""; p1Age = 0; p1Phone = "";
                                    patientCount--;
                                    Console.WriteLine("Patient deleted.");
                                }
                                else if (p2Active && p2Name == delPName)
                                {
                                    p2Active = false; p2Name = ""; p2Age = 0; p2Phone = "";
                                    patientCount--;
                                    Console.WriteLine("Patient deleted.");
                                }
                                else if (p3Active && p3Name == delPName)
                                {
                                    p3Active = false; p3Name = ""; p3Age = 0; p3Phone = "";
                                    patientCount--;
                                    Console.WriteLine("Patient deleted.");
                                }
                                else
                                {
                                    Console.WriteLine("Patient not found.");
                                }
                                break;

                            case 0:
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }

                        Console.WriteLine("\nPress Enter to continue...");
                        Console.ReadLine();
                        if (patChoice == 0) break;
                    }
                    break;

                // ══════════════════════════════════════════════════════
                // ── REGION 3: Doctor Sub-Menu ──────────────────────────
                // ══════════════════════════════════════════════════════
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

                        int docChoice = Convert.ToInt32(Console.ReadLine());

                        // ── REGION 4: Doctor Operations ───────────────
                        switch (docChoice)
                        {
                            // ADD Doctor
                            case 1:
                                Console.WriteLine("\n── Add New Doctor ──");

                                if (doctorCount == MAX_DOCTORS)
                                {
                                    Console.WriteLine("No available doctor slots.");
                                    break;
                                }

                                Console.Write("Enter doctor name: ");
                                string newDName = Console.ReadLine();
                                if (newDName == "")
                                {
                                    Console.WriteLine("Error: Name cannot be empty.");
                                    break;
                                }

                                Console.Write("Enter specialization: ");
                                string newDSpec = Console.ReadLine();
                                if (newDSpec == "")
                                {
                                    Console.WriteLine("Error: Specialization cannot be empty.");
                                    break;
                                }

                                Console.Write("Enter consultation fee: ");
                                double newDFee = Convert.ToDouble(Console.ReadLine());
                                if (newDFee < 0)
                                {
                                    Console.WriteLine("Error: Fee cannot be negative.");
                                    break;
                                }

                                if (!d1Active)
                                {
                                    d1Name = newDName; d1Spec = newDSpec; d1Fee = newDFee; d1Active = true;
                                }
                                else if (!d2Active)
                                {
                                    d2Name = newDName; d2Spec = newDSpec; d2Fee = newDFee; d2Active = true;
                                }

                                doctorCount++;
                                Console.WriteLine("Doctor added successfully.");
                                break;

                            // DISPLAY ALL Doctors
                            case 2:
                                Console.WriteLine("\n── Doctor List ──");

                                if (doctorCount == 0)
                                {
                                    Console.WriteLine("No doctors registered.");
                                    break;
                                }

                                int dDisplayNum = 1;

                                if (d1Active)
                                {
                                    Console.WriteLine("─────────────────────────────────────────");
                                    Console.WriteLine(" Doctor #" + dDisplayNum);
                                    Console.WriteLine(" Name           : " + d1Name);
                                    Console.WriteLine(" Specialization : " + d1Spec);
                                    Console.WriteLine(" Fee            : " + d1Fee + " OMR");
                                    dDisplayNum++;
                                }
                                if (d2Active)
                                {
                                    Console.WriteLine("─────────────────────────────────────────");
                                    Console.WriteLine(" Doctor #" + dDisplayNum);
                                    Console.WriteLine(" Name           : " + d2Name);
                                    Console.WriteLine(" Specialization : " + d2Spec);
                                    Console.WriteLine(" Fee            : " + d2Fee + " OMR");
                                    dDisplayNum++;
                                }
                                Console.WriteLine("─────────────────────────────────────────");
                                break;

                            // UPDATE Consultation Fee
                            case 3:
                                Console.WriteLine("\n── Update Consultation Fee ──");
                                Console.Write("Enter doctor name to update: ");
                                string updDName = Console.ReadLine();

                                if (d1Active && d1Name == updDName)
                                {
                                    Console.Write("Enter new fee: ");
                                    double newFee1 = Convert.ToDouble(Console.ReadLine());
                                    if (newFee1 < 0) { Console.WriteLine("Error: Fee cannot be negative."); break; }
                                    d1Fee = newFee1;
                                    Console.WriteLine("Fee updated.");
                                }
                                else if (d2Active && d2Name == updDName)
                                {
                                    Console.Write("Enter new fee: ");
                                    double newFee2 = Convert.ToDouble(Console.ReadLine());
                                    if (newFee2 < 0) { Console.WriteLine("Error: Fee cannot be negative."); break; }
                                    d2Fee = newFee2;
                                    Console.WriteLine("Fee updated.");
                                }
                                else
                                {
                                    Console.WriteLine("Doctor not found.");
                                }
                                break;

                            // DELETE Doctor
                            case 4:
                                Console.WriteLine("\n── Delete Doctor ──");
                                Console.Write("Enter doctor name to delete: ");
                                string delDName = Console.ReadLine();

                                if (d1Active && d1Name == delDName)
                                {
                                    d1Active = false; d1Name = ""; d1Spec = ""; d1Fee = 0;
                                    doctorCount--;
                                    Console.WriteLine("Doctor removed.");
                                }
                                else if (d2Active && d2Name == delDName)
                                {
                                    d2Active = false; d2Name = ""; d2Spec = ""; d2Fee = 0;
                                    doctorCount--;
                                    Console.WriteLine("Doctor removed.");
                                }
                                else
                                {
                                    Console.WriteLine("Doctor not found.");
                                }
                                break;

                            case 0:
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }

                        Console.WriteLine("\nPress Enter to continue...");
                        Console.ReadLine();
                        if (docChoice == 0) break;
                    }
                    break;

                // ══════════════════════════════════════════════════════
                // ── REGION 3: Appointment Sub-Menu ─────────────────────
                // ══════════════════════════════════════════════════════
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

                        int apptChoice = Convert.ToInt32(Console.ReadLine());

                        // ── REGION 4: Appointment Operations ──────────
                        switch (apptChoice)
                        {
                            // BOOK Appointment
                            case 1:
                                Console.WriteLine("\n── Book New Appointment ──");

                                if (appointmentCount == MAX_APPOINTMENTS)
                                {
                                    Console.WriteLine("No available appointment slots.");
                                    break;
                                }

                                if (patientCount == 0 || doctorCount == 0)
                                {
                                    Console.WriteLine("Please add patients and doctors first.");
                                    break;
                                }

                                // Show active patients
                                Console.WriteLine("\nAvailable Patients:");
                                if (p1Active) Console.WriteLine("  1. " + p1Name);
                                if (p2Active) Console.WriteLine("  2. " + p2Name);
                                if (p3Active) Console.WriteLine("  3. " + p3Name);

                                Console.Write("Select patient slot number: ");
                                int pSlotChoice = Convert.ToInt32(Console.ReadLine());

                                string chosenPatient = "";
                                if      (pSlotChoice == 1 && p1Active) { chosenPatient = p1Name; }
                                else if (pSlotChoice == 2 && p2Active) { chosenPatient = p2Name; }
                                else if (pSlotChoice == 3 && p3Active) { chosenPatient = p3Name; }
                                else { Console.WriteLine("Invalid patient selection."); break; }

                                // Show active doctors
                                Console.WriteLine("\nAvailable Doctors:");
                                if (d1Active) Console.WriteLine("  1. " + d1Name);
                                if (d2Active) Console.WriteLine("  2. " + d2Name);

                                Console.Write("Select doctor slot number: ");
                                int dSlotChoice = Convert.ToInt32(Console.ReadLine());

                                string chosenDoctor = "";
                                if      (dSlotChoice == 1 && d1Active) { chosenDoctor = d1Name; }
                                else if (dSlotChoice == 2 && d2Active) { chosenDoctor = d2Name; }
                                else { Console.WriteLine("Invalid doctor selection."); break; }

                                Console.Write("Enter appointment date (DD/MM/YYYY): ");
                                string newApptDate = Console.ReadLine();

                                // Duplicate check
                                bool isDuplicate = false;
                                if (a1Active && a1Patient == chosenPatient && a1Doctor == chosenDoctor && a1Date == newApptDate)
                                    isDuplicate = true;
                                else if (a2Active && a2Patient == chosenPatient && a2Doctor == chosenDoctor && a2Date == newApptDate)
                                    isDuplicate = true;
                                else if (a3Active && a3Patient == chosenPatient && a3Doctor == chosenDoctor && a3Date == newApptDate)
                                    isDuplicate = true;

                                if (isDuplicate)
                                {
                                    Console.WriteLine("Duplicate appointment. This booking already exists.");
                                    break;
                                }

                                // Assign to first free slot
                                if (!a1Active)
                                {
                                    a1Patient = chosenPatient; a1Doctor = chosenDoctor;
                                    a1Date = newApptDate; a1Status = "Scheduled"; a1Active = true;
                                }
                                else if (!a2Active)
                                {
                                    a2Patient = chosenPatient; a2Doctor = chosenDoctor;
                                    a2Date = newApptDate; a2Status = "Scheduled"; a2Active = true;
                                }
                                else if (!a3Active)
                                {
                                    a3Patient = chosenPatient; a3Doctor = chosenDoctor;
                                    a3Date = newApptDate; a3Status = "Scheduled"; a3Active = true;
                                }

                                appointmentCount++;
                                Console.WriteLine("Appointment booked successfully.");
                                break;

                            // DISPLAY ALL Appointments
                            case 2:
                                Console.WriteLine("\n── Appointments ──");

                                if (appointmentCount == 0)
                                {
                                    Console.WriteLine("No appointments booked.");
                                    break;
                                }

                                int aDisplayNum = 1;

                                if (a1Active)
                                {
                                    Console.WriteLine("─────────────────────────────────────────");
                                    Console.WriteLine(" Appointment #" + aDisplayNum);
                                    Console.WriteLine(" Patient : " + a1Patient);
                                    Console.WriteLine(" Doctor  : " + a1Doctor);
                                    Console.WriteLine(" Date    : " + a1Date);
                                    Console.WriteLine(" Status  : " + a1Status);
                                    aDisplayNum++;
                                }
                                if (a2Active)
                                {
                                    Console.WriteLine("─────────────────────────────────────────");
                                    Console.WriteLine(" Appointment #" + aDisplayNum);
                                    Console.WriteLine(" Patient : " + a2Patient);
                                    Console.WriteLine(" Doctor  : " + a2Doctor);
                                    Console.WriteLine(" Date    : " + a2Date);
                                    Console.WriteLine(" Status  : " + a2Status);
                                    aDisplayNum++;
                                }
                                if (a3Active)
                                {
                                    Console.WriteLine("─────────────────────────────────────────");
                                    Console.WriteLine(" Appointment #" + aDisplayNum);
                                    Console.WriteLine(" Patient : " + a3Patient);
                                    Console.WriteLine(" Doctor  : " + a3Doctor);
                                    Console.WriteLine(" Date    : " + a3Date);
                                    Console.WriteLine(" Status  : " + a3Status);
                                    aDisplayNum++;
                                }
                                Console.WriteLine("─────────────────────────────────────────");
                                break;

                            // UPDATE Appointment Status
                            case 3:
                                Console.WriteLine("\n── Update Appointment Status ──");

                                Console.WriteLine("Active Appointment Slots:");
                                if (a1Active) Console.WriteLine("  Slot 1 | " + a1Patient + " - " + a1Doctor + " | " + a1Date + " | " + a1Status);
                                if (a2Active) Console.WriteLine("  Slot 2 | " + a2Patient + " - " + a2Doctor + " | " + a2Date + " | " + a2Status);
                                if (a3Active) Console.WriteLine("  Slot 3 | " + a3Patient + " - " + a3Doctor + " | " + a3Date + " | " + a3Status);

                                Console.Write("\nEnter slot number to update (1/2/3): ");
                                int updSlot = Convert.ToInt32(Console.ReadLine());

                                bool slotIsActive = false;
                                if      (updSlot == 1 && a1Active) slotIsActive = true;
                                else if (updSlot == 2 && a2Active) slotIsActive = true;
                                else if (updSlot == 3 && a3Active) slotIsActive = true;

                                if (!slotIsActive)
                                {
                                    Console.WriteLine("Invalid slot.");
                                    break;
                                }

                                Console.WriteLine("\nSelect new status:");
                                Console.WriteLine("  1. Scheduled");
                                Console.WriteLine("  2. Completed");
                                Console.WriteLine("  3. Cancelled");
                                Console.Write("Enter status choice: ");
                                int statusChoice = Convert.ToInt32(Console.ReadLine());

                                string newStatus = "";
                                switch (statusChoice)
                                {
                                    case 1: newStatus = "Scheduled"; break;
                                    case 2: newStatus = "Completed"; break;
                                    case 3: newStatus = "Cancelled"; break;
                                    default: Console.WriteLine("Invalid status choice."); break;
                                }

                                if (newStatus != "")
                                {
                                    if      (updSlot == 1) { a1Status = newStatus; Console.WriteLine("Status updated to: " + a1Status); }
                                    else if (updSlot == 2) { a2Status = newStatus; Console.WriteLine("Status updated to: " + a2Status); }
                                    else if (updSlot == 3) { a3Status = newStatus; Console.WriteLine("Status updated to: " + a3Status); }
                                }
                                break;

                            // CANCEL Appointment
                            case 4:
                                Console.WriteLine("\n── Cancel Appointment ──");
                                Console.Write("Enter patient name: ");
                                string cancelPatient = Console.ReadLine();
                                Console.Write("Enter appointment date (DD/MM/YYYY): ");
                                string cancelDate = Console.ReadLine();

                                // Keep record visible — only change status to Cancelled
                                if (a1Active && a1Patient == cancelPatient && a1Date == cancelDate)
                                {
                                    a1Status = "Cancelled";
                                    Console.WriteLine("Appointment cancelled.");
                                }
                                else if (a2Active && a2Patient == cancelPatient && a2Date == cancelDate)
                                {
                                    a2Status = "Cancelled";
                                    Console.WriteLine("Appointment cancelled.");
                                }
                                else if (a3Active && a3Patient == cancelPatient && a3Date == cancelDate)
                                {
                                    a3Status = "Cancelled";
                                    Console.WriteLine("Appointment cancelled.");
                                }
                                else
                                {
                                    Console.WriteLine("Appointment not found.");
                                }
                                break;

                            case 0:
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }

                        Console.WriteLine("\nPress Enter to continue...");
                        Console.ReadLine();
                        if (apptChoice == 0) break;
                    }
                    break;

                // ── EXIT ──────────────────────────────────────────────
                case 0:
                    // BONUS: Final summary using if-else only (no loops)
                    Console.Clear();
                    Console.WriteLine("╔══════════════════════════════════════╗");
                    Console.WriteLine("║          SESSION SUMMARY             ║");
                    Console.WriteLine("╠══════════════════════════════════════╣");

                    if (patientCount == 0)      Console.WriteLine("║  Total Patients     : 0              ║");
                    else if (patientCount == 1) Console.WriteLine("║  Total Patients     : 1              ║");
                    else if (patientCount == 2) Console.WriteLine("║  Total Patients     : 2              ║");
                    else if (patientCount == 3) Console.WriteLine("║  Total Patients     : 3              ║");

                    if (doctorCount == 0)      Console.WriteLine("║  Total Doctors      : 0              ║");
                    else if (doctorCount == 1) Console.WriteLine("║  Total Doctors      : 1              ║");
                    else if (doctorCount == 2) Console.WriteLine("║  Total Doctors      : 2              ║");

                    if (appointmentCount == 0)      Console.WriteLine("║  Total Appointments : 0              ║");
                    else if (appointmentCount == 1) Console.WriteLine("║  Total Appointments : 1              ║");
                    else if (appointmentCount == 2) Console.WriteLine("║  Total Appointments : 2              ║");
                    else if (appointmentCount == 3) Console.WriteLine("║  Total Appointments : 3              ║");

                    Console.WriteLine("╠══════════════════════════════════════╣");
                    Console.WriteLine("║  Thank you for using CMS. Goodbye!   ║");
                    Console.WriteLine("╚══════════════════════════════════════╝");
                    return;

                default:
                    Console.WriteLine("\nInvalid choice. Please select 0-3.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }

    }
}