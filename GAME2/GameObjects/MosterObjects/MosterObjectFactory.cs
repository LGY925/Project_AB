using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.Items;

namespace GAME2.GameObjects.MosterObjects
{
    internal class  MosterObjectFactory
    {
        private MosterObject mosterObject;
        MosterName mosterName;
        float balance;
        Vector vector;
        public MosterObject Create(MosterName mosterName,int x , int y)
        {
            vector = new Vector(x,y);

            switch (mosterName)
            {
                case MosterName.Slime:
                    mosterObject = new MosterObject("슬라임", 100, 20, 'S',vector);
                    break;
            }
            mosterObject.hp =(int)(mosterObject.hp * balance);
            mosterObject.ap = (int)(mosterObject.hp * balance);
            return mosterObject;
        }

    }
}
