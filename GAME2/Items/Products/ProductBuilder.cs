using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Items.Products
{
    public class ProductBuilder
    {
        private string name;
        private int No;

        public ProductBuilder()
        {
            name = "부산물";
            No = 1;
        }
        public Product Builder()
        {
            Product product = new Product();
            product.name = name;
            product.No = No;
            return product;

        }
        public ProductBuilder NameSet(string name)
        { 
            this.name = name; 
            return this;
        }
        public ProductBuilder NoSet(int no)
        {
            No = no;
            return this;
        }
        
    }
}
