using System;
using System.Diagnostics;

namespace ConsoleApp2_Core_ {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");


            int[] myArr = new int[5] { 1, 2, 3, 4, 5 };
            int myResult = 0;
            SumAll(out myResult, myArr);

            Console.WriteLine($"결과: {myResult}");
            Debug.WriteLine($"결과: {myResult}");
            Debugger.Break();

            //Console.ReadLine();
        }


        static void SumAll(out int result, params int[] args) {
            result = 0;
            for (int i = 0; i < args.Length; i++) {
                result = result + args[i];
            }
        }
    }
}
