using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _18_Constructor
{
    internal class program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry porter", "JK Rowling", 400);

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}
