using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckGrade
{
    class Program
    {
        #region Methods
        public static void GradeA()
        {
            Console.WriteLine("A");
            Console.WriteLine("You are such a Perfect Student.");
        }
        public static void GradeB()
        {
            Console.WriteLine("B");
        }
        public static void GradeC()
        {
            Console.WriteLine("C");
        }
        public static void GradeD()
        {
            Console.WriteLine("D");
        }
        public static void GradeE()
        {
            Console.WriteLine("E");
        }
        public static void GradeF()
        {
            Console.WriteLine("F");
            Console.WriteLine("OLODO!!!");
        }
        #endregion 
        static void Main(string[] args)
        {
            #region Checking Grade without methods
            Console.Write("Enter your Score: ");
            int yourGrade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Grade is: ");
            if (yourGrade <= 100)
            {
                if (yourGrade >= 70)
                {
                    Console.WriteLine("A");
                    if (yourGrade == 100)
                    {
                        Console.WriteLine("Your are such a Perfect Student.");
                    }
                }
                else if (yourGrade >= 60)
                {
                    Console.WriteLine("B");
                }
                else if (yourGrade >= 50)
                {
                    Console.WriteLine("C");
                }
                else if (yourGrade >= 45)
                {
                    Console.WriteLine("D");
                }
                else if (yourGrade >= 40)
                {
                    Console.WriteLine("E");
                }
                else
                {
                    Console.WriteLine("F");
                    Console.WriteLine("OLODO!!!");
                }
                Console.ReadLine();
            }
            #endregion
            #region Checking Grade with methods
            Console.Write("Enter your score: ");
            int yourScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Grade is: ");
            if (yourScore <= 100)
            {
                if (yourScore >= 70)
                {
                    GradeA();
                }
                else if(yourScore >= 60)
                {
                    GradeB();
                }
                else if (yourScore >= 50)
                {
                    GradeC();
                }
                else if(yourScore >= 45)
                {
                    GradeD();
                }
                else if(yourScore >= 40)
                {
                    GradeE();
                }
                else
                {
                    GradeF();
                }
            }

            Console.ReadLine();
            #endregion
            #region Checking Grade with case
            Console.Write("Enter yoyr Score: ");
            string yourMark = Console.ReadLine();
            int yourRealScore = Convert.ToInt32(yourMark);

            int number = yourMark.Length; 
            switch (number)
            {
                case 1:
                    Console.WriteLine("Your Grade is: F");
                    Console.WriteLine("OLODO!!!");
                    break;
                case 2:
                    if (yourRealScore <= 39)
                    {
                        Console.WriteLine("Your Grade is: F");
                        Console.WriteLine("OLODO!!!");
                    }
                    else if (yourRealScore <= 44)
                    {
                        Console.WriteLine("Your Grade is: E");
                    }
                    else if (yourRealScore <= 49)
                    {
                        Console.WriteLine("Your Grade is: D");
                    }
                    else if (yourRealScore <= 59)
                    {
                        Console.WriteLine("Your Grade is: C");
                    }
                    else if (yourRealScore <= 69)
                    {
                        Console.WriteLine("Your Grade is: B");
                    }
                    else
                    {
                        Console.WriteLine("Your Grade is: A");
                    }
                    break;
                case 3:
                    Console.WriteLine("Your Grade is: A");
                    Console.WriteLine("You are such a Perfect Student.");
                    break;

            }
            Console.ReadLine();
            #endregion
        }


    }
}
