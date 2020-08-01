using System;

namespace LAB_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from LAB_9_4");

            HtmlPageBuilder htmlPageBuilder = new HtmlPageBuilder();
            htmlPageBuilder.CollectThenCreateHTML();

        }
    }
}
