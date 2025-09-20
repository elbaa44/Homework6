namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            /*
            var Even = new List<int>();
            var Odd = new List<int>();
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                if(i % 2 == 0)
                {
                    Even.Add(i);
                }
                else
                {
                    Odd.Add(i);
                }
            }
            Console.WriteLine("Even numbers:");
            foreach (var item in Even)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Odd numbers:");
            foreach (var item in Odd)
            {
                Console.WriteLine(item);
            }
            */

            #endregion

            #region Task 2

            
              
             
            Dictionary<string , string> Contacts = new Dictionary<string, string>();
            while (true)
            {
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Delete Contact");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Contact List");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        string phoneNumber = Console.ReadLine();
                        if (!Contacts.ContainsKey(name))
                        {
                            Contacts.Add(name, phoneNumber);
                            Console.WriteLine("Contact added.");
                        }
                        else
                        {
                            Console.WriteLine("Contact already exists.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter name to delete: ");
                        string deleteName = Console.ReadLine();
                        if(Contacts.Remove(deleteName))
                        {
                            Console.WriteLine("Contact deleted.");
                        }
                        else
                        {
                            Console.WriteLine("There is no such contact.");
                        }

                        break;

                    case "3":
                        Console.WriteLine("Enter name to update: ");
                        string updateName = Console.ReadLine();
                        if (Contacts.ContainsKey(updateName))
                        {
                            Console.Write("Enter new phone number: ");
                            string newPhoneNumber = Console.ReadLine();
                            Contacts[updateName] = newPhoneNumber;
                            Console.WriteLine("Contact updated.");
                        }
                        else
                        {
                            Console.WriteLine("There is no such contact.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Contact List: ");
                        foreach(var contact in Contacts)
                        {
                            Console.WriteLine($"Name : {contact.Key} , Phone Number: {contact.Value}");

                        }

                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;

                    default:

                        Console.WriteLine("Invalid option. Please try again.");
                        
                        break;

                }
            }


            

            #endregion

            #region Task 3

            // Console.WriteLine("Enter how many numbers you want to enter: ");

            // int numCount = int.Parse(Console.ReadLine());
            // for(int i=0; i<numCount; i++)
            // {

            //             }






            #endregion

            #region Task 4
            /*
            int[] points  = {45, 67, 89, 23, 90, 56, 78, 12, 34, 100 };
            Console.WriteLine("Enter number to see top n sportsman's points: ");
            int n = int.Parse(Console.ReadLine());
            
            Array.Sort(points);
            Array.Reverse(points);
            int[] top = points.Take(n).ToArray();

            Console.WriteLine("Tops: ");
            foreach(var item in top)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


        }
    }
}
