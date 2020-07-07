using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOOP_V2
{
    class Program
    {
        public static RectangleOOP_V2 M = new RectangleOOP_V2();
        public static RectangleOOP_V2 S = new RectangleOOP_V2();
        public static RectangleOOP_V2 P = new RectangleOOP_V2();
        public static RectangleOOP_V2 R = new RectangleOOP_V2();
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhap toa do HCN S:");
            //S = new RectangleOOP_V2();
            /*
            Console.WriteLine("1. Khoi tao M gom 9 diem");
            Console.WriteLine("2. Khoi tao M gom tam va do dai canh");
            
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    M = new RectangleOOP_V2();
                    break;
                case 2:
                    Console.WriteLine("Toa do tam x:");
                    int xM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Toa do tam y:");
                    int yM = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kich thuoc:");
                    int size = int.Parse(Console.ReadLine());
                    M = new RectangleOOP_V2(xM, yM, size);
                    break;
                default:
                    break;

            }
            */
            S.SetS();
            Console.WriteLine("Print S");
            PrintResult(S);

            M.SetM();
            Console.WriteLine("Print M");
            PrintResult(M);

            Console.WriteLine("Nhap toa do va kich thuoc HCN P:");
            Console.WriteLine("Toa do tam x:");
            int xP = int.Parse(Console.ReadLine());
            Console.WriteLine("Toa do tam y:");
            int yP = int.Parse(Console.ReadLine());
            Console.WriteLine("Kich thuoc:");
            int sizeP = int.Parse(Console.ReadLine());
            P = new RectangleOOP_V2(xP, yP, sizeP);

            R = new RectangleOOP_V2("R");

            M.Adjust();
            Console.WriteLine("M full!");
            PrintResult(M);
            Console.WriteLine("P full!");
            PrintResult(P);

            S.PreHandle(sizeP, M.Size, M.Rect[5], S);
            S.MoveR(P.Rect[5], M.Rect[5]);
            S.PrintResult();
            Console.ReadLine();
        }

        private static void PrintResult(RectangleOOP_V2 m)
        {
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine("X: " + m.Rect[i].X + " " + "Y: " + m.Rect[i].Y);
            }
        }
    }
}
