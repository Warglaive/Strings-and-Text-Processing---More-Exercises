using System;
using System.Collections.Generic;

namespace _01.Serialize_String
{
    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            var character = new HashSet<char>();
            var toChar = input.ToCharArray();
            foreach (var item in input)
            {
                character.Add(item);
            }
            var result = string.Empty;
            foreach (var itemChar in character)
            {
                result += itemChar + ":";
                var index = input.IndexOf(itemChar);
                while (index >= 0) 
                {
                    result += index + "/";
                    index = input.IndexOf(itemChar, index + 1);
                }
                Console.WriteLine(result.Trim('/'));
                result = string.Empty;
            }
        }
    }
}