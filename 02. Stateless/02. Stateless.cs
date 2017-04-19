using System;

namespace _02.Stateless
{
    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            while (input!= "collapse")
            {
                var states = input;
                var fiction = Console.ReadLine();
                while (fiction.Length > 0)
                {
                    states = states.Replace(fiction, "");
                    fiction = fiction.Remove(0, 1);
                    if (fiction.Length > 0) 
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }                }
                if (states == string.Empty)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(states.Trim());
                }
                input = Console.ReadLine();
            }
        }
    }
}