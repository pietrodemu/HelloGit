using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello cat!");

            var mylist = new List<int>() {0,1,2};
            string[] alphabet = {"a","b","c"};

            foreach (var item in mylist)
            {
                Console.WriteLine(alphabet[item]);
            }
        }
    }
}
