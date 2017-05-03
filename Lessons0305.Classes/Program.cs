using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0305.Classes
{
    class Program
    {
        //public delegate int PerformCalc(int num1, int num2);

        static void Main(string[] args)
        {            
            Console.WriteLine("Lesson 0305 Classes\n");
            var array = new[] {
                new Pen { Color = Color.Black, Brand = "Bic" },
                new Pen { Color = Color.Green, Brand = "Yer" },
                new Pen { Color = Color.Black, Brand = "Bic" },
                new Pen { Color = Color.Green, Brand = "Bic" },
                new Pen { Color = Color.Blue, Brand = "Bic" },
                new Pen { Color = Color.Black, Brand = "Loper" },
            };
            var pens = array.Any(x => x.Color == Color.Black && x.Brand != "Bic");
            var pens1 = array.Where(x => x.Brand == "Bic");//.ToList();
            var pen1 = array.FirstOrDefault(x => x.Color == Color.Red) ?? 
                new Pen { Color = Color.Red, Brand = "Re"};
            
             

            Console.WriteLine(pens);
            Console.WriteLine(pens1);
            Console.WriteLine(pen1?.ToString());//проверка на налл

            //Func<int, int, int> MyCalc = delegate (int a, int b)
            //{
            //    return a + b;
            //};
            //int N1;
            //int N2;
            //char OP;
            //string input;
            //string[] substring;
            //Console.WriteLine("Input numbers and opertaion");
            //input = Console.ReadLine();
            //substring = input.Split(' ');
            //N1 = Convert.ToInt32(substring[0]);
            //N2 = Convert.ToInt32(substring[1]);
            //OP = Convert.ToChar(substring[2]);
            ////PerformCalc myDelegate;
            //Func<int, int, int> myDelegate;
            //switch (OP)
            //{
            //    case '+':
            //        myDelegate = delegate (int a, int b)//myDelegate = Add;
            //        {
            //            return a + b;
            //        };
            //        break;
            //    case '-':
            //        myDelegate = delegate (int a, int b)//myDelegate = Subtr;
            //        {
            //            return a - b;
            //        };
            //        break;
            //    case '*':
            //        myDelegate = (a, b) => a * b;//myDelegate = Mult;
            //        break;
            //    case '/':
            //        myDelegate = (a, b) => a / b;//myDelegate = Div;
            //        break;
            //    default:
            //        myDelegate = null;
            //        break;

            //}
            //Console.WriteLine(myDelegate(N1, N2));
            Console.ReadLine();
        }
        public static Pen SearchRedPen(IEnumerable<Pen> pens)
        {
            return pens.FirstOrDefault(x => x.Color == Color.Red);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtr(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
