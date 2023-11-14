using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModelLibrary
{
    public class Menu
    {
        public static void MainMenu()
        {
            bool continueMenu = true;
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Main Menu");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Enter Choice No: \n1. Manage Employee\n2. Manage Travel Request\n3. Exit");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Manage Employee:-");
                        ManageEmployee();
                        break;
                    case 2:
                        Console.WriteLine("Manage Travel Request:-");
                        ManageTravelRequest();
                        break;
                    case 3:
                        Console.WriteLine("Exiting the menu.");
                        continueMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Do you want to continue? (y/n)");
                char response = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                continueMenu = (response == 'y' || response == 'Y');
                Console.WriteLine("------------------------------------------");


            } while (continueMenu);
        }

        public static void ManageEmployee()
        {
            bool continueMenu = true;
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Enter your choice: \n1. Add Employee\n2. Edit Employee\n3. Delete Employee\n4. View Employee\n5. Go Back\n6. Exit ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Employee");
                        AddEmployee();
                        break;
                    case 2:
                        Console.WriteLine("Edit Employee");
                        EditEmployee();
                        break;
                    case 3:
                        Console.WriteLine("Delete Employee");
                        DeleteEmployee();
                        break;
                    case 4:
                        Console.WriteLine("View Employee");
                        ViewEmployee();

                        break;
                    case 5:
                        Console.WriteLine("Go Back");
                        MainMenu();
                        break;
                    case 6:
                        Console.WriteLine("Exiting the menu now");
                        continueMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                char response = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                continueMenu = (response == 'y' || response == 'Y');
                Console.WriteLine("------------------------------------------");

            } while (continueMenu);


        }
        static int empId;
        static string empFname, empLName, empAddress, empContactNo;
        static DateTime empDob;

        public static void ManageTravelRequest()
        {
            bool continueMenu = true;

            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Manage Travel Request");
                Console.WriteLine("Enter your choice: \n1. Raise travel request\n2. View travel request\n3. Delete travel request\n4. Approve travel \n5. Confirm Booking\n6. Go back\n7. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Raise travel request");
                        RaiseTravelRequest();
                        break;
                    case 2:
                        Console.WriteLine("View travel request");
                        ViewTravelRequest();
                        break;
                    case 3:
                        Console.WriteLine("Delete travel request");
                        DeleteTravelRequest();
                        break;
                    case 4:
                        Console.WriteLine("Approve request");
                        ApproveRequest();
                        break;
                    case 5:
                        Console.WriteLine("Confirm booking");
                        ConfirmBooking();
                        break;
                    case 6:
                        Console.WriteLine("Go back");
                        MainMenu();
                        break;
                    case 7:
                        Console.WriteLine("Exiting the menu...");
                        continueMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                char response = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                continueMenu = (response == 'y' || response == 'Y');
                Console.WriteLine("------------------------------------------");
            } while (continueMenu);
        }
        
        //Add employee
        public static void AddEmployee()

        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter empId:");
            empId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Name:");
            empFname = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            empLName = Console.ReadLine();

            Console.WriteLine("Enter Date of Birth (e.g., yyyy-MM-dd):");
            if (DateTime.TryParse(Console.ReadLine(), out empDob))
            {
                Console.WriteLine("Enter Address:");
                empAddress = Console.ReadLine();

                Console.WriteLine("Enter Contact Number:");
                empContactNo = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Invalid date format. Employee not added.");
            }
            Console.WriteLine("------------------------------------------");
        }

        // Edit an employee 
        public static void EditEmployee()
        {

            //if (employeeToEdit != null)
            Console.WriteLine("------------------------------------------");
            {
                Console.WriteLine("Enter First Name:");
                string empFname = Console.ReadLine();

                Console.WriteLine("Enter Last Name:");
                string empLName = Console.ReadLine();

                Console.WriteLine("Enter Date of Birth (e.g., yyyy-MM-dd):");
                if (DateTime.TryParse(Console.ReadLine(), out empDob))
                {
                    Console.WriteLine("Enter Address:");
                    string empAddress = Console.ReadLine();

                    Console.WriteLine("Enter Contact Number:");
                    string empContactNo = Console.ReadLine();

                }
                //else
                {
                    Console.WriteLine("Invalid date format. Employee not edited.");
                }
                Console.WriteLine("------------------------------------------");
            }
        }

        // Delete an employee 
        public static void DeleteEmployee()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter empId you want to delete");
            Console.WriteLine("------------------------------------------");
        }

        // View all employees
        public static void ViewEmployee()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("All Employees:");
            Console.WriteLine("------------------------------------------");

        }
        static int reqId, emp_Id;
        static string location_from, location_to;
        public enum confirm_booking { Available, Notavailable, NA };
        public enum approve_status { approved, denied, NA };
        public enum current_status { open, close };
        static approve_status approveS = approve_status.NA;
        static confirm_booking confirmB = confirm_booking.NA;
        static current_status currentS = current_status.open;

        public static void RaiseTravelRequest()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Raise travel request ");
            Console.WriteLine("Enter request id:");
            reqId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee id:");
            emp_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter location form:");
            location_from = Console.ReadLine();
            Console.WriteLine("Enter location to:");
            String location_to = Console.ReadLine();

            Console.WriteLine("Your approve status is:" + approveS);

            Console.WriteLine("Your approve status is:" + confirmB);

            Console.WriteLine("Your approve status is:" + currentS);
            Console.WriteLine("------------------------------------------");

        }

        public static void ViewTravelRequest()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("All travel requests");

            Console.WriteLine("Your request id:" + reqId);

            Console.WriteLine("Your employee id:" + emp_Id);

            Console.WriteLine("Your location form:" + location_from);

            Console.WriteLine("Your location to:" + location_to);
            Console.WriteLine("Your approve status is:" + approveS);
            Console.WriteLine("Your approve status is:" + confirmB);
            Console.WriteLine("Your approve status is:" + currentS);
            Console.WriteLine("------------------------------------------");
        }

        public static void DeleteTravelRequest()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter request Id of travel request that you want to Delete :");
            int delReq = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");
        }

        public static void ApproveRequest()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("All travel request");
            Console.WriteLine("Enter travel request Id you want to approve: ");
            int approve = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

        }

        public static void ConfirmBooking()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("All travel request");
            Console.WriteLine("Enter travel request Id you want to confirm booking for: ");
            int confirm = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

        }
        
    }

}





