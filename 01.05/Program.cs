using CustomBuilder;
using System;
//stringBuilder.Append("S");
//stringBuilder.Append("a");
//stringBuilder.Append("l");
//stringBuilder.Append("a");
//stringBuilder.Append("m");
//Console.WriteLine(stringBuilder);


//CustomStringBuilder stringBuilder = new CustomStringBuilder();
//stringBuilder.Append("lorem ipsum dolor sit amet, consectetur adipiscing elit.");

//Console.WriteLine(); ("before removing characters:");
//Console.WriteLine(); (stringBuilder.ToString());

//stringBuilder.Remove(6, 5);

//Console.WriteLine(); ("after removing characters:");
//Console.WriteLine(); (stringBuilder.ToString());

internal class Program
{
    private static void Main(string[] args)
    {
        CustomStringBuilder stringBuilder = new CustomStringBuilder();
        stringBuilder.Append("Neque porro quisquam est qui dolorem ipsum.");

        Console.WriteLine("Before replace:");
        Console.WriteLine(stringBuilder.ToString());

        stringBuilder.Replace("impus", "laylay");

        Console.WriteLine("After replace:");
        Console.WriteLine(stringBuilder.ToString());
    }
}