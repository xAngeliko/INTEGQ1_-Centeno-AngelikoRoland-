using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSA.DL;

namespace OSA.BL
{
    class productManagement
    {
        public List<Product> ProductInfo = new List<Product>()
        {
            new Product ("MANILA ANIMAL","$300","51",new DateTime(2021,6,26)),
            new Product ("CELT 2K17","$100","52",new DateTime(2021,6,26)),
            new Product ("THE PROJECT","$300","53",new DateTime(2021,6,26)),
        };

        public void viewProducts()
        {
            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("\nFRAME BRAND: {0}|\nPRICE: {1}|\nFRAME SIZE: {2} |\nDATE: {3}|", product.frameBrand, product.Price, product.FrameSize, product.Date);
            }
        }
        public void addNewProduct()
        {
            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("\nFRAME BRAND:{0}|\nPrice: {1}|\nFRAME SIZE: {2}|\nDATE: {3}|", product.frameBrand, product.Price, product.FrameSize, product.Date);
            }

            Console.WriteLine("ENTER A FRAME BRAND: ");
            string newProduct = Console.ReadLine();

            Console.WriteLine("ENTER PRICE:$ ");
            string newPrice = Console.ReadLine();

            Console.WriteLine("FRAME SIZE; ");
            string newframeSize = Console.ReadLine();
            DateTime newDate = DateTime.Now;


            ProductInfo.Add(new Product(newProduct, newPrice, newframeSize, newDate));
            Console.WriteLine("\nFRAME BRAND:{0}|\nPRICE:${1}|\nFRAME SIZE: {2}|\nDATE: {3}|\nITEM SUCCESSFULLY ADDED", newProduct, newPrice, newframeSize, newDate);

            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("\nFRAME BRAND:{0}|\nPRICE: {1}|\nFRAME SIZE: {2}|\nDATE: {3}|", product.frameBrand, product.Price, product.FrameSize, product.Date);
            }
        }
        public void removeItem()
        {
            Console.WriteLine("ENTER INDEX POSITION: ");
            int indexPosition = int.Parse(Console.ReadLine());

            ProductInfo.RemoveAt(indexPosition);

            foreach (Product product in ProductInfo)
            {
                Console.WriteLine("\nFRAME BRAND:{0}|\nPRICE: {1}|\nFRAME SIZE: {2} |\nDATE: {3}|", product.frameBrand, product.Price, product.FrameSize, product.Date);
            }
        }
    }
}
