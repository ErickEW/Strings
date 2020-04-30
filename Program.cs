using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld ="Hello World";
            System.Console.WriteLine(helloworld.Substring(6));
            System.Console.WriteLine(helloworld.Substring(6,5));

            string a = "AAA";
            string b ="BBB";

            a += b;
            System.Console.WriteLine(a);

            string pineapple ="pineapple";
            string apple = "apple";
            string pen = "pen";

            System.Console.WriteLine(pineapple + apple + pen);

            System.Console.WriteLine("\n\nReplace");
            apple = apple.Replace("a", "A");

            System.Console.WriteLine((pineapple + apple + pen).Replace("apple", "Apple (tm)", true, null));
            System.Console.WriteLine(apple);
            
            System.Console.WriteLine("\n\nSplit");
            string nombres = "Johon, Johnny, Jason, Jimy";

            string[] nombresArray = nombres.Split(",");
            foreach (string nombre in nombresArray)
            {
                System.Console.WriteLine($"nombre => {nombre}");
            }
            
            System.Console.WriteLine("\n\nJoin");
            string nombresJoined = string.Join(",", nombresArray);
            System.Console.WriteLine(nombresJoined);

            System.Console.WriteLine("\n\nFormating");
            System.Console.WriteLine("[" + nombresArray[0] + "," + nombresArray[1]+ ",");

            System.Console.WriteLine($"[{nombresArray[0]}, {nombresArray[1]}");

            String.Format("[{0}, {1}]", nombresArray[1]);

            System.Console.WriteLine(String.Format("[{0}, {1}]", nombresArray[0], nombresArray[1]));
            System.Console.WriteLine(String.Format("{[0], {1}, {2}, {3}]", nombresArray));

            System.Console.WriteLine("\n\nEscaped chars");
            System.Console.WriteLine("System.Console.Writeline(\"\n\\nFormating\");");
        }
    }
}
