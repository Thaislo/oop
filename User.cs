using LINQtoCSV;
using QuanLyTinder;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
        private string firstname;
        private string lastname;
        private string email;
        private string username;
        private string password;
        private string city;
        private string gender;
        private int age;
        private bool follow;
        List<User> danhsachtaikhoan = new List<User>();
        List<User> friendL = new List<User>();
        List<User> interestedPList = new List<User>();
        Database DB = new Database();
        public User(string username, string firstName, string lastName, string city, string gender, int age)
        {
            this.username = username;
            this.firstname = firstName;
            this.lastname = lastName;
            this.city = city;
            this.gender = gender;
            this.age = age;
        }
        public User(string firstName, string lastName, string city, string gender, int age)
        {
            this.firstname = firstName;
            this.lastname = lastName;
            this.city = city;
            this.gender = gender;
            this.age = age;
        }
        public User()
        {

        }
        public User(string email, string username, string password)
        {
            this.email = email;
            this.username = username;
            this.password = password;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User(string name)
        {
            this.firstname = name;
        }
        /*public void SignUp(string email, string user, string password)
        {
            this.email = email;
            this.username = user;
            this.password = password;
        }*/
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string FirtsName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public void ForgetPassword(string email_or_username)
        {
            if (this.username == email_or_username || this.email == email_or_username)
            {
                Console.WriteLine("Enter your new password");
                string new_password = Console.ReadLine();
                this.password = new_password;
            }
        }
        public void Xuat(User u)
        {
            Console.WriteLine(u.firstname + " " + u.lastname + "," + u.age);
            Console.WriteLine(u.city);
            Console.WriteLine(u.gender);
        }

        public void KetBan(User user)
        {
            friendL.Add(user);
        }
        public void ShowFriends()
        {
            foreach (User item in friendL)
            {
                Console.WriteLine(item.firstname);
            }
        }
        public void ShowPPYouInterestedIn()
        {
            foreach (User item in interestedPList)
            {
                Console.WriteLine(item.firstname + " " + item.lastname);
            }
        }
        public void MyProfile(string my_username)
        {
            DB.UserManager();
            foreach (User user in DB.UserList)
            {
                if (user.username == my_username)
                {
                    Xuat(user);
                }
            }
        }
        public void Swipe(User tmp)
        {
            Database DB = new Database();
            //DB.AssignUser();
            int choice;
            do
            {
                foreach (User au in DB.GetUserByGenderAge())
                {
                    Xuat(au);
                    Console.WriteLine("1. Swipe right" + "    2. Swipe Left" + "    3. Quit");
                    choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            addInterestedPerson(au);
                            break;
                        case 2:
                            break;
                        case 3:
                            Menu mn = new Menu();
                            mn.ShowMenu(tmp);
                            break;
                    }
                }
            } while (true);
        }
        public void addInterestedPerson(User u)
        {
            interestedPList.Add(u);
        }
    }
}
