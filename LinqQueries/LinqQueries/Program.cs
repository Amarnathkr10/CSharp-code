//using System;
//using System.Collections.Generic;
//using System.Linq;
//namespace LINQDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> integerList = new List<int>()
//            {
//                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
//            };

//            var QuerySyntax = integerList.Where(obj => obj > 5).ToList();

//            Console.WriteLine($"{QuerySyntax}");

//            foreach (var item in QuerySyntax)
//            {
//                Console.Write(item + " ");
//            }

//            Console.ReadKey();
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            IEnumerable<int> QuerySyntax = from obj in integerList
                                           where obj > 5
                                           select obj;

            Console.WriteLine(QuerySyntax);

            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("I'm adding new line in for new branch");
            Console.ReadKey();
        }
    }
}