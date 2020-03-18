//#define TEST_ENV



using System;
using System.Diagnostics;

namespace ConsoleApp1 {


    public struct Rect {
        public int Left;
        public int Right;
        public int Top;
        public int Bottom;
    }


    class Program {
        static void Main(string[] args) {

            Rect rect = new Rect();
            rect.Top = 10;
            rect.Bottom = 10;
            rect.Left = 10;
            rect.Right = 10;


#if (TEST_ENV)
            System.Console.WriteLine("TEST_ENV == true");
            Debug.WriteLine("TEST_ENV == true");
#else
            Console.WriteLine("TEST_ENV == false");
            Debug.WriteLine("TEST_ENV == false");
#endif
        }
    }
}
