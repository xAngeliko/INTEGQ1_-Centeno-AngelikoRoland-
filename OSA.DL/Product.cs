using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSA.DL
{
    public class Product
    {
        public string frameBrand;
        private string price;
        private string framesize;
        private DateTime date;

        public Product(string shirtBrand, string price, string size, DateTime date)
        {
            this.frameBrand = shirtBrand;
            this.price = price;
            this.framesize = size;
            this.date = date;
        }
        public string ShirtBrand
        {
            get { return frameBrand; }
            set { frameBrand = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string FrameSize
        {
            get { return framesize; }
            set { framesize = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
