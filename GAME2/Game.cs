using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAME2.Screens;

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
            screenDic.Add(ScreenLocal.Main,new MainSceen());

            curSceen = screenDic[ScreenLocal.Main];
        }
        public static void Run()
        {
            while (gameEnd == false)
            {
                Console.Clear();
                curSceen.Render();
                Utility.ReadKey(out ReadingKey key);
                curSceen.Result(key);
                curSceen.Wait();
                curSceen.Next();
                
            }
        }
        public static void ChangeScene(ScreenLocal changeScreen)
        {
            screen = curSceen.name;

            curSceen.Exit();
            curSceen = screenDic[changeScreen];
            curSceen.Enter();

        }
        public static void EndSwich()
        {
            gameEnd = true;
        }
        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("*          You Died...           *");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine(reason);
            Console.WriteLine();
            Console.WriteLine("처음으로 돌아갑니다.");

        }
        public static void End()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("다시 오시길 기원합니다");
            Console.WriteLine("수고하셨습니다");
            Console.ResetColor();
        }

    }


}
