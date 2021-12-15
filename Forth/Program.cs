using System;
using System.Collections.Generic;


var p = "100 LOG .";// Console.ReadLine();
var s = new Stack<double>();

foreach (var c in p.Split(' '))
{
    if (double.TryParse(c, out var n))
        s.Push(n);
    else switch (c)
        {
            case "+":
                s.Push(s.Pop() + s.Pop());
                break;

            case "DUP":
                s.Push(s.Peek());
                break;

            case "LOG":
                s.Push(Math.Log10(s.Pop()));
                break;

            case ".":
                Console.WriteLine(s.Pop());
                break;

            default:
                Console.WriteLine($"Unknown operation '{c}'.");
                break;
        }
}
