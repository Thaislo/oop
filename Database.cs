using QuanLyTinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Database
    {
        List<User> userList = new List<User>();
        List<User> assignUserList = new List<User>();
        List<User> accountList = new List<User>();
        public Database()
        {
        }
        public void UserManager()
        {
            User user1 = new User("thai", "Thai", "Nguyen", "Vung Tau", "Nam", 19);
            User user2 = new User("huy", "Huy", "Dinh", "Ho Chi Minh","Nam", 20);
            User user3 = new User("thinh", "Thinh", "Nguyen", "Ho Chi Minh", "Nam", 19);
            User user4 = new User("hong", "Hong", "Truong", "Ho Chi Minh", "Nu", 18);

            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);
            userList.Add(user4);
        }
        public void AccountManager()
        {
            User acc1 = new User("thai", "123");
            User acc2 = new User("huy", "321654");
            User acc3 = new User("thinh", "789153");
            User acc4 = new User("hong", "789654");

            accountList.Add(acc1);
            accountList.Add(acc2);
            accountList.Add(acc3);
            accountList.Add(acc4);

            //return accountList;
        }
        
        public void AssignUser()
        {
            User au1   = new User("Thong", "Truong", "Vung Tau", "Nam", 16);
            User au2   = new User("Trang", "Nguyen", "Ha Noi", "Nu", 21);
            User au3   = new User("Dat", "Nguyen", "Hai Phong", "Nam", 19);
            User au4   = new User("Binh", "Phan", "Vung Tau", "Nam", 21);
            User au5   = new User("Hang", "Nguyen", "Ho Chi Minh", "Nu", 18);
            User au6   = new User("Phuc", "Ngo", "Ho Chi Minh", "Nam", 22);
            User au7   = new User("Hang", "Trinh", "Can Tho", "Nu", 20);
            User au8   = new User("Nhan", "Tu", "Ha Noi", "Nam", 19);
            User au9   = new User("Lan", "Ngo", "Da Lat", "Nu", 27);
            User au10  = new User("Nhi", "Nguyen", "Vung Tau", "Nu", 30);

            assignUserList.Add(au1);
            assignUserList.Add(au2);
            assignUserList.Add(au3);
            assignUserList.Add(au4);
            assignUserList.Add(au5);
            assignUserList.Add(au6);
            assignUserList.Add(au7);
            assignUserList.Add(au8);
            assignUserList.Add(au9);
            assignUserList.Add(au10);
        }
        public List<User> GetUserByGenderAge()
        {
            AssignUser();
            Console.WriteLine("Are you looking to meet (M)ale or (F)emale: ");
            string choice = Console.ReadLine().ToUpper();
            Console.WriteLine("And at which age you want to look for");
            Console.WriteLine("Between ");
            int age1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("And ");
            int age2 = Int32.Parse(Console.ReadLine());
            string g;
            if (choice == "M")
                g = "Nam";
            else 
                g = "Nu";
            var result = from u in assignUserList
                         where u.Gender == g && u.Age >= age1 && u.Age <= age2
                         select u;
            return result.ToList<User>();
        }
        public bool SignUp(User newUser, string newusername)
        {
            AccountManager();
            foreach (User u in accountList)
            {
                if (u.Username == newusername)
                {
                    Console.WriteLine("This username have already existed");
                    return false;
                }
            }
            return true;
        }
        public bool SignIn(string my_username, string my_password)
        {
            //Database DB = new Database();
            AccountManager();
            foreach (User user in accountList)
            {
                if (my_username == user.Username && my_password == user.Password)
                    return true;
            }
            return false;
        }
        public void AddAnAccount(User acc)
        {
            accountList.Add(acc);
        }
        public void AddANewUser(User u)
        {
            userList.Add(u);
        }
        public List<User> AccountList
        {
            get { return accountList; }
            set { accountList = value; }
        }
        public List<User> UserList
        {
            get { return userList; }
            set { userList = value; }
        }
    }
}
