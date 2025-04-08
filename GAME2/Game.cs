using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME2
{
    public static class Game
    {
        private static bool gameEnd;
        private static Dictionary<ScreenLocal, Screen> screenDic;
        private static Screen curSceen;
        public static ScreenLocal screen;
        public static void Start()
        {
            gameEnd = false;

            screenDic = new Dictionary<ScreenLocal, Screen>();
        }
        public static void Run()
        {
            while (gameEnd == false)
            {
                Console.Clear();
                curSceen.Render();
                Utility.ReadKey(out ReadingKey key);
                curSceen.Result(key);
                curSceen.Next();
                curSceen.Wait();
                
            }
        }
        public static void ChangeScene(ScreenLocal changeScreen)
        {
            screen = curSceen.name;

            curSceen.Exit();
            curSceen = screenDic[changeScreen];
            curSceen.Enter();

        }
        public static void End()
        {

        }

    }


}
