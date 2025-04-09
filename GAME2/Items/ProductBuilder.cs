using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2.Items
{
    public class ProductBuilder
    {
        public string name;
        public int No;

        public ProductBuilder()
        {
            name = "부산물";
            No = 1;
        }
        
        public ProductBuilder NameSet(string name)
        { 
            this.name = name; 
            return this;
        }
        public ProductBuilder NoSet(int no)
        {
            this.No = no;
            return this;
        }
        
    }
}
