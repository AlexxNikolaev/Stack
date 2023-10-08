using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>();
        numbers.Push(1);
        numbers.Push(2);
        numbers.Push(3);
        numbers.Push(4);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nPopping '{0}'", numbers.Pop());

        Console.WriteLine("\nPeek at next item to destack: {0}", numbers.Peek());

        int[] array = new int[numbers.Count * 2];
        numbers.CopyTo(array, numbers.Count);

        Console.WriteLine("\nnumbers.Count = {0}", numbers.Count);

        numbers.Clear();

        Console.WriteLine("\nnumbers.Count after Clear = {0}", numbers.Count);
    }
}

