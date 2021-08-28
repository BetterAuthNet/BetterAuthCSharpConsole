using System;

namespace BetterAuthCSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            betterauth.LoadLibrary("BetterAuthUser.dll");
            if (betterauth.init_application("ExampleBetterAuth"))
            {
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Register");
                Console.WriteLine("3) Activate key");
                Console.WriteLine("4) Check subscription");
                Console.WriteLine("5) Get file from server");
                bool logged_in = false;
                while (true)
                {
                    string operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "1":
                            {
                                Console.WriteLine("Username: ");
                                string username = Console.ReadLine();
                                Console.WriteLine("Password: ");
                                string password = Console.ReadLine();
                                if (betterauth.c_login(username, password))
                                {
                                    logged_in = true;
                                }
                                break;
                            }

                        case "2":
                            {
                                Console.WriteLine("Username: ");
                                string username = Console.ReadLine();
                                Console.WriteLine("Password: ");
                                string password = Console.ReadLine();
                                if (betterauth.c_register(username, password))
                                {
                                    
                                }
                                break;
                            }
                        case "3":
                            {
                                if (logged_in)
                                {
                                    Console.WriteLine("Key: ");
                                    string key = Console.ReadLine();
                                    if (betterauth.c_activatekey(key))
                                    {

                                    }
                                }
                                break;
                            }
                        case "4":
                            {
                                if (logged_in)
                                {
                                    unsafe
                                    {
                                        Console.WriteLine("Product ID: ");
                                        string productid = Console.ReadLine();
                                        bool has_sub = false;
                                        string time_left = betterauth.has_sub(Convert.ToUInt32(productid), &has_sub);
                                        if (has_sub)
                                        {
                                            Console.WriteLine("User has a sub for this product it will expire on: " + time_left);
                                        }
                                    }
                                }
                                break;
                            }
                        case "5":
                            {
                                if (logged_in)
                                {
                                    unsafe
                                    {
                                        Console.WriteLine("Product ID: ");
                                        string productid = Console.ReadLine();
                                        bool has_sub = false;
                                        string time_left = betterauth.has_sub(Convert.ToUInt32(productid), &has_sub);
                                        if (has_sub)
                                        {
                                            UInt64 buffer;
                                            UInt32 size;
                                            if(betterauth.get_file(Convert.ToUInt32(productid), &buffer, &size))
                                            {
                                                Console.WriteLine("Downloaded file from Server");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Couldn't download file from server");
                                            }
                                       
                                        }
                                        else
                                        {
                                            Console.WriteLine("Couldn't download file because user doesn't have a sub for this product");
                                        }
                                    }
                                }
                                break;
                            }
                    }
                }
               
            }
            else
            {
                Console.WriteLine("Error");
              
            }
           
        }
    }
}
