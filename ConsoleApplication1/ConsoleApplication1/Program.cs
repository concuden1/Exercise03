using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           DrawTriangle(4,'*');
            Console.ReadLine();
            
        }
        static void HLine(int n, char c )
        {
            for (int i = 0; i < n; i++)          
                Console.Write(c);          
        }
        static void VLine(int n, Char c)
        {
            for (int i = 0; i < n; i++)         
                Console.WriteLine(c);           
        }
        static void DLine(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                HLine(i - 1, ' ');
                Console.WriteLine(" " + n);
            }
        }
        //first line: n-1 spaces, 1 star
        //second line: n-2 spaces, 1 star, 1 space, 1 star
        //third line: n-3 spaces, 1 star, 3 spaces, 1 star
        //fourth line: n-4 spaces, 1 star, 5 spaces, 1 star
        // last line: 2n-1 stars
        static void DrawTriangle(int n, char c)
        {
           
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine("");

            }
        }
    }
}
