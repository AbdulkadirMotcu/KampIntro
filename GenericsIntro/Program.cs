using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Kadir");

            Console.WriteLine(isimler.Length);

            isimler.Add("Damla");

            Console.WriteLine(isimler.Length);
            foreach (var item in isimler.Items)
            {

                Console.WriteLine();
            }

        }
    }
}
