//See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

Console.WriteLine("Sandhya Sangave - ICE Code Test\n");

string text, subtext;
int count = 0; bool match;
List<int> lst = new List<int>();

Console.Write("Input text: ");
text = Console.ReadLine().ToLower();


Console.Write("Subtext: ");
subtext = Console.ReadLine().ToLower();



for (int i = 0; i < text.Length - subtext.Length + 1; i++)
{
    match = true;
    for (int j = 0; j < subtext.Length; j++)
    {
        if (text[i + j] != subtext[j])
        {
            match = false;
            break;
        }
    }
    if (match)
    {
        count = i + 1;
        lst.Add(count);        
    }
}


if (count == 0)
{
    Console.WriteLine("<no matches>");
    Console.ReadLine();
}
else
{
    Console.Write("Output: ");
    lst.ForEach(x => Console.Write("{0}, ", x ));
    Console.Write("\b\b ");
    Console.ReadLine();
}

