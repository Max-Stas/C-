using System;
using System.Runtime.InteropServices;

namespace TestDll
{
    class Program
    {
        [DllImport("C:\\Users\\Dashk\\Desktop\\try\\try_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Min(int x, int y);

        [DllImport("C:\\Users\\Dashk\\Desktop\\try\\try_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Max(int x, int y);

        [DllImport("C:\\Users\\Dashk\\Desktop\\try\\try_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void Swap(ref int x, ref int y);

        [DllImport("C:\\Users\\Dashk\\Desktop\\try\\try_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Add(int x, int y);

        [DllImport("C:\\Users\\Dashk\\Desktop\\try\\try_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void Message(string str);

        [DllImport("C:\\Users\\Dashk\\Desktop\\try\\try_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void LMessage(string str);

        [DllImport("C:\\Users\\Dashk\\Desktop\\try\\try_lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int InputInt();

        static void Main(string[] args)
        {
            Message("Enter x and y:\nx = ");
            int x = InputInt();
            Message("y = ");
            int y = InputInt();

            LMessage($"Sum of numbers: {Add(x, y)}");
            LMessage($"Minimum number: {Min(x, y)}");
            LMessage($"Maximum of numbers: {Max(x, y)}");

            Swap(ref x, ref y);
            LMessage($"After exchanging the values x = {x}, y = {y}.");
        }
    }
}
