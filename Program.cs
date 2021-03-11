using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CppAndCs
{
    class Program
    {
        public const string Project1Dll = @"..\..\..\Debug\CppFunctions.dll"; // поставить свой путь к dll
        [DllImport(Project1Dll, CallingConvention = CallingConvention.Cdecl)]
        public static extern int qsortRecursive(int[] a, int n);

        static void Main(string[] args)
        {
            int[] output1 = new int[4] { 1, 4, 2, 3 };
            int output2 = 4;
            qsortRecursive(output1, output2);
            for (int i = 0; i < output1.Length; i++)
            {
                Console.Write(output1[i]);
            }
            Console.ReadLine();
        }
    }
}
