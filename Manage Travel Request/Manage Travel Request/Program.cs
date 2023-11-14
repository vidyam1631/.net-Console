using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Travel_Request
{
    internal class Program
    {
        int reqId,empId;
        void RaiseTravelRequest()
        {
            Console.WriteLine("Raise travel request ");
            Console.WriteLine("Enter request id:");
             reqId=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee id:");
             empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter location form:");
            String location_from = Console.ReadLine();
            Console.WriteLine("Enter location to:");
            String location_to = Console.ReadLine();
            String approve_status = "Not Approved";
            Console.WriteLine("Your approve status is:"+approve_status);
            String confirm_booking = "NA";
            Console.WriteLine("Your approve status is:" + confirm_booking);
            String current_status = "Open";
            Console.WriteLine("Your approve status is:" + current_status);

        }

        void ViewTravelRequest()
        {
            Console.WriteLine("All travel requests");
            
            Console.WriteLine("Enter request id:"+ reqId);
      
            Console.WriteLine("Enter employee id:"+empId);
            
            Console.WriteLine("Enter location form:");
            String location_from = Console.ReadLine();
            Console.WriteLine("Enter location to:");
            String location_to = Console.ReadLine();
            String approve_status = "Not Approved";
            Console.WriteLine("Your approve status is:" + approve_status);
            String confirm_booking = "NA";
            Console.WriteLine("Your approve status is:" + confirm_booking);
            String current_status = "Open";
            Console.WriteLine("Your approve status is:" + current_status);
       
            String location_from = Console.ReadLine();
            Console.WriteLine("Enter location to:");
            String location_to = Console.ReadLine();
            String approve_status = "Not Approved";
            Console.WriteLine("Your approve status is:" + approve_status);
            String confirm_booking = "NA";
            Console.WriteLine("Your approve status is:" + confirm_booking);
            String current_status = "Open";
            Console.WriteLine("Your approve status is:" + current_status);
        }

        public static void DeleteTravelRequest()
        {
            Console.WriteLine("Delete travel request functionality implemented.");
        }

        public static void ApproveRequest()
        {
            Console.WriteLine("Approve request functionality implemented.");
        }

        public static void ConfirmBooking()
        {
            Console.WriteLine("Confirm booking functionality implemented.");
        }
        static void Main(string[] args)
        {
            bool continueMenu = true;

            do
            {
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
            } while (continueMenu);
        }
    }
}
