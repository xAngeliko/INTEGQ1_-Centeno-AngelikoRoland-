using System;
using OSA.BL;

namespace onlineShoppingApplication.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            userLogIn user = new userLogIn();
            Console.WriteLine("================================================");
            Console.WriteLine("      WECOME TO FIXIE FRAME ONLINE SHOPPING     ");
            Console.WriteLine("================================================");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("          PRESS --->>(1)<<---LOG IN             ");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("          PRESS --->>(2)<<--REGISTER            ");
            Console.WriteLine("================================================");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.logIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }

        }
    }
}
