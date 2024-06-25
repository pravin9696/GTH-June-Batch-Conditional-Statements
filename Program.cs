using System.Numerics;
using System.Threading.Channels;

namespace Conditional_statements_240624
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            #region
            //int x = 5;
            //int y;
            //string city = "pune";
            //string state = "Maha";
            //string abc=x >= 5 ? city : state;
            //var xyz = x >= 5 ? 111 : 222;
            //int ans = x < 10 ? 1000 : 2000;
            //Console.WriteLine("Ans="+ans);
            //int no;

            //Console.WriteLine("Enter no:");
            //no = int.Parse(Console.ReadLine());//34
            //if (no%2==0)
            //{
            //    Console.WriteLine(no+" is even"); // 34 is even
            //}
            //else
            //{
            //    Console.WriteLine(no+"is odd");
            //}
            #endregion
            #region
            //int n1, n2;

            ////accept two nos and store into n1 & n2;
            //Console.WriteLine("Enter n1 & n2");
            //n1 = int.Parse(Console.ReadLine());//4
            //n2 = int.Parse(Console.ReadLine());//6
            //if (n1 > n2)
            //{
            //    Console.WriteLine(n1 + " is greater:");
            //}
            //else
            //{
            //    Console.WriteLine(n2 + " is greater:");
            //}
            #endregion
            #region greater 3 using only if
            int n1 = 400;
          int n2 = 555;
          int n3 = 90;

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine(n1 + "is greater number:");
            //}
            //if (n2 > n1 && n2 > n3)
            //{
            //    Console.WriteLine(n2 + "is greater number:");
            //}
            //if (n3 > n1 && n3 > n2)
            //{
            //    Console.WriteLine(n3 + "is greater number:");
            //}
            #endregion
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + "is greater number:");
            }
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine(n2 + "is greater number:");
                }
                else
                {
                    Console.WriteLine(n3 + "is greater number:");
                }
            }

        }

    }
}

