using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.Items;
using GAME2.Items.Products;

namespace GAME2.GameObjects.MosterObjects
{
    public class  MosterObjectFactory
    {
        private MosterObject mosterObject;
        private MosterName mosterName;
        public float balance;
        private Vector vector;
        
        private ProductBuilder productBuilder;
        public MosterObject Create(MosterName mosterName,int x , int y)
        {
            vector = new Vector(x,y);
            productBuilder = new ProductBuilder();
            switch (mosterName)
            {
                case MosterName.Slime:
                    productBuilder.NameSet("물컹물컹한 액체").NoSet(5);
                    mosterObject = new MosterObject("슬라임", 100, 5,
                        productBuilder.Builder(),100,'S',vector);
                    break;
            }
            mosterObject.hp =(int)(mosterObject.hp * balance);
            mosterObject.ap = (int)(mosterObject.hp * balance);
            mosterObject.gold = (int)(mosterObject.gold * balance);
            return mosterObject;
        }

    }
}
