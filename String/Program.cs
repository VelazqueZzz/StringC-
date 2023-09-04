using System;

class StringDemo
{
    static void Main()
    {
        char[] symbs = { 'Я', 'з', 'ы', 'к', ',', 'C', '#' };
        Console.WriteLine("symvolnii massiv:");
            Console.Write(symbs);
        String A = new String(symbs);
        Console.WriteLine("A: \"{0}\"", A);
        String B = new String(symbs, 1, 5);
        Console.WriteLine("B: \"{0}\"", B);
        String C = new String('ы', 7);
        Console.WriteLine("C:\"{0}\"", C);
        A = getText('A', 'H');
        Console.WriteLine("A:  \"{0}\"", A);
        B = getText('H', 'A');
        Console.WriteLine("B:  \"{0}\"", B);
        C = getText(symbs);
        Console.WriteLine("C: \"{0}\"", C);
    }
    static String getText(char[] symbs)
    {
        String txt = "";
        for(int k = 0; k < symbs.Length; k++)
        {
            txt += symbs[k];
        }
        return txt;
    }
    static String getText(char a,char b)
    {
        String txt = "";
        char s = a;
        while (s <= b)
        {
            txt += s;
        }
        return txt;
    }
}