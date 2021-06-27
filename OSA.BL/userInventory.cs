using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSA.BL
{
    public class userInventory
    {
        public void Inventory()
        {
            productManagement productServices = new productManagement();

        START:
            Console.WriteLine("================================================");
            Console.WriteLine("        PRESS --->>(1)<<--- VIEW PRODUCTS       ");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("        PRESS --->>(2)<<--- ADD PRODUCTS        ");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("        PRESS --->>(3)<<--- REMOVE PRODUCTS     ");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("        PRESS --->>(4)<<--- EXIT                ");
            Console.WriteLine("================================================");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    productServices.viewProducts();
                    goto START;
                case 2:
                    productServices.addNewProduct();
                    goto START;
                case 3:
                    productServices.removeItem();
                    goto START;

                default:
                    break;
            }

        }
    }
}

