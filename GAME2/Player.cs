using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2
{
    public class Player
    {
        public Vector position;

        private int cutHp;
        public int CutHp { get { return cutHp; } }
        private int maxHp;
        public int MaxHp {  get { return maxHp; } }
        private int ap;
        public int Ap { get { return ap; }  }
        private int dp;
        public int Dp { get { return dp; } }

        public bool[,] map;

        private bool keyUsing;
        public bool KeyUsing { get { return keyUsing; } }

        public Player()
        {

            maxHp = 100;
            cutHp = MaxHp;
            ap = 5;
            dp = 5;
            keyUsing = false;
        }
        public void Action(ReadingKey key)
        {
            Vector targetPos = position;
            switch (key)
            {
                case ReadingKey.Up:
                    targetPos.y--;
                    break;
                case ReadingKey.Down:
                    targetPos.y++;
                    break;
                case ReadingKey.Left:
                    targetPos.x--;
                    break;
                case ReadingKey.Right:
                    targetPos.x++;
                    break;
            }

            if (map[targetPos.y, targetPos.x] == true)
            {
                position = targetPos;
            }
        }
        public void PrintStat()
        {
            Console.WriteLine("  HP   : {0}/ {1}",cutHp,maxHp);
            Console.WriteLine("공격력 : {0}",ap);
            Console.WriteLine("방어력 : {0}",dp);
            
        }


        public void PrintPlayer()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("P");
            Console.ResetColor();
        }

        public int Attack()
        {
            Random random = new();
            int attackDamage = random.Next(ap/2,ap*2);
            Console.WriteLine("플레이어가 공격합니다",attackDamage);
            Console.WriteLine("{0} 데미지", attackDamage);
            return attackDamage;
        }
        public void Damage(int monsterAp)
        {
            int monsterDamge = monsterAp - dp;
            Console.WriteLine("{0} 만큼 방어합니다", dp);
            cutHp -= monsterDamge;
            Console.WriteLine("{0} 데미지",monsterDamge);
            Console.WriteLine("HP가 {0} 남았습니다", cutHp);
            if (cutHp < 0)
            {
                Game.GameOver("당신은 죽었습니다");
            }    
        }
        public void Heal(int amountp)
        {
            cutHp += amountp;
            if (cutHp > maxHp)
            {
                cutHp = maxHp;
                Console.WriteLine("체력이 꽉 차있습니다");
            }
            else
            {
                Console.WriteLine("현제채력이 {0} 입니다", cutHp);
            }
            ;
            
        }
        public void BoxReady(bool Ready)
        {
            keyUsing = Ready;
        }

        public void ApUp(int point)
        {
            ap += point;
            Console.WriteLine("현제 {0} {1} 입니다 ", "공격력이", Ap);
        }
        public void DpUp(int point)
        {
            dp += point;
            Console.WriteLine("현제 {0} {1} 입니다 ", "방어력이", Dp);
        }
    }
}
