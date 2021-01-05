using System;

namespace AddressBookSystem_Linq_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_AddressBookSystem_Linq***");
            AddressBookModel model = new AddressBookModel();
            AddressBookDataTable adddataTable = new AddressBookDataTable();
            adddataTable.CreateTable(model);
            
            while (true)
            {
                Console.WriteLine("\nEnter Choice  \n1. Add Contact \n2. Display \n3. Edit Contact  \n4. DeletContact \n5. ContactFrom_City \n6. ContactsFrom_State \n7. CountByCityOrState \n8. Sort_Contacts\n9. Exit ");
                int choise = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choise)
                    {
                        case 1:
                            Console.Write("Enter the first name: ");
                            model.First_Name = Console.ReadLine();
                            Console.Write("Enter the last name :");
                            model.Last_Name = Console.ReadLine();
                            Console.Write("Enter the Address : ");
                            model.Address = Console.ReadLine();
                            Console.Write("Enter the city : ");
                            model.City = Console.ReadLine();
                            Console.Write("Enter the state :");
                            model.State = Console.ReadLine();
                            Console.Write("Enter the zip code : ");
                            model.Zip = Console.ReadLine();
                            Console.Write("Enter the phone number : ");
                            model.Phone_Number = Console.ReadLine();
                            Console.Write("Enter the E-mail : ");
                            model.Email = Console.ReadLine();
                            adddataTable.AddContact(model);
                            break;
                        case 2:
                            adddataTable.Display();
                            break;
                        case 3:
                            Console.Write("Enter the first name: ");
                            model.First_Name = Console.ReadLine();
                            Console.Write("Enter the last name :");
                            model.Last_Name = Console.ReadLine();
                            Console.Write("Enter the Address : ");
                            model.Address = Console.ReadLine();
                            Console.Write("Enter the city : ");
                            model.City = Console.ReadLine();
                            Console.Write("Enter the state :");
                            model.State = Console.ReadLine();
                            Console.Write("Enter the zip code : ");
                            model.Zip = Console.ReadLine();
                            Console.Write("Enter the phone number : ");
                            model.Phone_Number = Console.ReadLine();
                            Console.Write("Enter the E-mail : ");
                            model.Email = Console.ReadLine();
                            adddataTable.EditContact(model);
                            break;
                        case 4:
                            Console.Write("Enter First Name: ");
                            model.First_Name = Console.ReadLine();
                            adddataTable.DeleteContact(model);
                            break;
                        case 5:
                            Console.WriteLine("Enter the city :");
                            model.City = Console.ReadLine();
                            adddataTable.RetrievePersonByUsingCity(model);
                            Console.WriteLine("Contacts_From_City");
                            break;
                        case 6:
                            Console.WriteLine("Enter the State : ");
                            model.State = Console.ReadLine();
                            adddataTable.RetrievePersonByUsingState(model);
                            Console.WriteLine("Contacts_From_State");
                            break;
                        case 7:
                            adddataTable.CountByCityAndState();
                            break;
                        case 8:
                            Console.WriteLine("Enter the city: ");
                            model.City = Console.ReadLine();
                            adddataTable.SortContactAlphabeticallyForGivenCity(model);
                            break;
                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid option....");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }
        }
    }
}
