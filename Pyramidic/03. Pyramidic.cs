using System;
using System.Collections.Generic;
using System.Linq;

namespace PyramidicDEmo
{
    public class Program
    {
        public static void Main()
        {
            var pyramids = new List<string>();

            var n = int.Parse(Console.ReadLine());

            string[] lines = new string[n];
            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentCharacter = currentLine[j];
                    int layer = 1;
                    string currentPyramid = string.Empty;
                    for (int k = i; k < lines.Length; k++)
                    {
                        string currentLayer = new string(currentCharacter, layer);
                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramid += currentLayer + Environment.NewLine;
                        }
                        else
                        {
                            break;
                        }
                        layer += 2;
                    }
                    pyramids.Add(currentPyramid.Trim());
                }
            }
            Console.WriteLine(string.Join("", pyramids.OrderByDescending(x => x.Length).First()));
        }
    }
}