namespace PraticandoConceitos;

public class Exercicio3
{
    public void Run()
    {
        Console.WriteLine("Digite o primeiro número:");
        string numero1 = Console.ReadLine();

        Console.WriteLine("Digite o segundo número:");
        string numero2 = Console.ReadLine();

        double sum = double.Parse(numero1) + double.Parse(numero2);
        double sub = double.Parse(numero1) - double.Parse(numero2);
        double mult = double.Parse(numero1) * double.Parse(numero2);
        double div = double.Parse(numero2) != 0 ? double.Parse(numero1) / double.Parse(numero2) : 0;

        Console.WriteLine("Soma: " + sum);
        Console.WriteLine("Subtração: " + sub);
        Console.WriteLine("Multiplicação: " + mult);
        Console.WriteLine("Divisão: " + div);
    }
}
