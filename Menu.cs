using LINQtoCSV;
using QuanLyTinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu

    {
        User user = new User();
        public Menu()
        {

        }

        public void ShowLogIn()
        {
            //Login User = new Login();
            Database DB = new Database();
            int choice;
            do
            {
                Console.WriteLine("1. CREATE ACCOUNT");
                Console.WriteLine("2. SIGN IN");
                Console.WriteLine("3. FORGOT PASSWORD");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Console.WriteLine("Email: ");
                        //string email = Console.ReadLine();
                        Console.WriteLine("Username: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        string password = Console.ReadLine();
                        User newAcc = new User(username, password);
                        if (DB.SignUp(newAcc, username))
                        {
                            DB.AddAnAccount(newAcc);
                            Console.WriteLine("Sign Up Success!!");
                            Console.WriteLine("To continue, please complete your profile");
                            Console.WriteLine("Please enter your");
                            Console.WriteLine("First name: ");
                            string firstname = Console.ReadLine();
                            Console.WriteLine("Last name: ");
                            string lastname = Console.ReadLine();
                            Console.WriteLine("Where do you live(city): ");
                            string city = Console.ReadLine();
                            Console.WriteLine("What's your age: ");
                            int age = Int32.Parse(Console.ReadLine());
                            User newUser = new User(username, firstname, lastname, city, age);
                            DB.AddANewUser(newUser);
                        }
                        //Console.WriteLine("Sign Up Success!!");
                        //Console.WriteLine("To continue, please complete your profile");
                        //Console.WriteLine("First name: ");
                        break;
                    case 2:
                        Console.WriteLine("Username: ");
                        string my_username = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        string my_password = Console.ReadLine();
                        User tmp = new User(my_username, my_password);
                        if (DB.SignIn(my_username, my_password))
                        {
                            Console.WriteLine("Sign In Success!!");
                            ShowMenu(tmp);
                        }
                        else
                            Console.WriteLine("Wrong username/password");
                        break;
                    case 3:
                        Console.WriteLine("Enter your email/username");
                        string email_or_username = Console.ReadLine();
                        user.ForgetPassword(email_or_username);
                        Console.WriteLine("Your password has successfully changed");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (true); 
        }
        public void ShowMenu(User tmp)
        {
            do
            {
                Console.WriteLine("1. Make new friends");
                Console.WriteLine("2. Swiping");
                Console.WriteLine("3. View who you liked");
                Console.WriteLine("4. View your friends");
                Console.WriteLine("5. View my profile");
                Console.WriteLine("6. Log out");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Search for your friend");
                        string ten2 = Console.ReadLine();
                        User nguoidung2 = new User(ten2);
                        tmp.KetBan(nguoidung2);
                        break;
                    case 2:
                        tmp.Swipe(tmp);
                        break;
                    case 3:
                        tmp.ShowPPYouInterestedIn();
                        break;
                    case 4:
                        tmp.ShowFriends();
                        break;
                    case 5:
                        tmp.MyProfile(tmp.Username);
                        break;
                    case 6:
                        ShowLogIn();
                        break;
                }
            } while (true);
        }
    }
}
