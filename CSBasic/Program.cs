using System;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "김" + "정" + "우";

            Console.WriteLine(name);

            Console.Write("Hello C#");//\n 없음
            Console.WriteLine("Hello World");//\n 있음
            Console.WriteLine("Hello World");
            Console.Write(3*4);
            Console.Write(3*4);

            Console.WriteLine("한빛 \t 아카데미");

            Console.WriteLine("안녕하세요 " + name + "님");

            Console.WriteLine(true);

            int a = 2000000000;
            int b = 1000000000;
            Console.WriteLine(a + b);
        }
    }
}
