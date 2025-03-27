using System;

    class Program
{
    static void Main()
    {
        Console.WriteLine("digite o numero: ");
        string numero = Console.ReadLine();
        int convertNum = Convert.ToInt32(numero);
        for (int i = 1; i <= 10;  i++)
        {
            int conta = i * convertNum;
            Console.WriteLine($" {convertNum} x {i}  = {conta}");
        }
    }
}