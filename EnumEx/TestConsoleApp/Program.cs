using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumEx;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEnum v;
            v = TestEnum.Test1;
            Console.WriteLine(v.IsFlaged(TestEnum.Test2));
            Console.WriteLine(v.IsAnyFlaged(TestEnum.Test2, TestEnum.Test3));
            Console.WriteLine(v.IsAllFlaged(TestEnum.Test1, TestEnum.Test2));
            v |= TestEnum.Test2;
            Console.WriteLine(v.IsFlaged(TestEnum.Test2));
            Console.WriteLine(v.IsAnyFlaged(TestEnum.Test2, TestEnum.Test3));
            Console.WriteLine(v.IsAllFlaged(TestEnum.Test1, TestEnum.Test2));


            Console.WriteLine("Press Any Key...");
            Console.ReadKey(true);
        }

        enum TestEnum
        {
            Test1 = 1<<1,
            Test2 = 1 << 2,
            Test3 = 1 << 3
        }
    }
}
