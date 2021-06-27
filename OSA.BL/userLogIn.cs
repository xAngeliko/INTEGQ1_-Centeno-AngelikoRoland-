using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSA.DL;

namespace OSA.BL
{
     public class userLogIn
    {
        public List<User> userAccount = new List<User>()
        {
            new User("angeliko.centeno@gmail.com","123123")
        };
        public void logIn()
        {
            userInventory inventory = new userInventory();
            bool successfull = false;
            Console.WriteLine("_______________");
            Console.WriteLine("EMAIL: ");
            string userEmail = Console.ReadLine();
            Console.WriteLine("_______________");
            Console.WriteLine("PASSWORD: ");
            string userPassword = Console.ReadLine();

            foreach (User user in userAccount)
            {
                if (userEmail == user.Email && userPassword == user.Password)
                {
                    Console.WriteLine("================================================");
                    Console.WriteLine("                 LOGIN COMPLETE                 ");
                    Console.WriteLine("================================================");

                    successfull = true;

                    inventory.Inventory();
                }
            }
            if (!successfull)
            {
                Console.WriteLine(".............");
            }
        }
        public void Register()
        {
            Console.WriteLine("EMAIL: ");
            string userEmail = Console.ReadLine();
            Console.WriteLine("PASSWORD: ");
            string userPass = Console.ReadLine();

            userAccount.Add(new User(userEmail, userPass));
            Console.WriteLine("YOU'VE SUCCESSFULLY REGISTERED!");

            foreach (User user in userAccount)
            {
                Console.WriteLine("EMAIL:{0}, PASSWORD:{1}", user.Email, user.Password);
            }
        }
    }
}
