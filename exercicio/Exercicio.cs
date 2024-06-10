using System;
using System.Linq.Expressions;

class Exercicio 
{
    public static void Main(string[] args) 
    {
        //forma braço curto de if else, no caso "?" é if, ":" é else
        int time = 20;
        string result = (time < 18) ? "Good day." : "Good Evening.";
        Console.WriteLine(result);
    }
}