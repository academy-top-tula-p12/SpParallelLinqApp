using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpParallelLinqApp
{
    public class Example
    {
        public static void WelcomePLinqExample()
        {
            Random random = new Random();

            List<int> numbers = new();
            for (int i = 0; i < 10; i++)
                //numbers.Add(i + 1);
                numbers.Add(random.Next(1, 20));

            foreach (var n in numbers)
                Console.Write($"{n} ");
            Console.WriteLine();

            //var sqrs = from n in numbers
            //           select (n * n);

            //foreach (var sqr in sqrs)
            //    Console.Write($"{sqr} ");
            //Console.WriteLine();

            //var pSqrs = from n in numbers.AsParallel()
            //            select (n * n);

            //var pSqrs = numbers.AsParallel()
            //        .Select(n => n * n)
            //        .OrderBy(n => n);
            //.ForAll((n) => Console.Write($"{n} "));

            //foreach (var sqr in pSqrs)
            //    Console.Write($"{sqr} ");
            //Console.WriteLine();

            var more10 = numbers.AsParallel()
                                .Where(n => n > 10)
                                .Select(n => n * n);


            foreach (var n in more10)
                Console.Write($"{n} ");
            Console.WriteLine();

            more10 = numbers.AsParallel()
                                .AsOrdered()
                                .Where(n => n > 10)
                                .Select(n => n * n);

            foreach (var n in more10)
                Console.Write($"{n} ");
            Console.WriteLine();


            more10 = numbers.AsParallel()
                                .AsOrdered()
                                .Where(n => n > 10)
                                .AsUnordered()
                                .Select(n => n * n);

            foreach (var n in more10)
                Console.Write($"{n} ");
            Console.WriteLine();
        }
    }
}
