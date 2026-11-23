namespace PraticandoConceitos;

public class Exercicio4
{
    public void Run()
    {
        Console.WriteLine("Digite a palavra ou frase:");
        string frase = Console.ReadLine();

        int qtdCaracteres = frase.Length;

        Console.WriteLine("Quantidade de caracteres: " + qtdCaracteres);
    }
}