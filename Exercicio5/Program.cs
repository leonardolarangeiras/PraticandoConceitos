namespace PraticandoConceitos;

public class Exercicio5
{
    public void Run()
    {
        Console.WriteLine("Digite a placa do veículo a ser validada:");
        string placa = Console.ReadLine();

        string placaFormatada = placa.ToUpper().Replace("-", "").Replace(" ", "");

        if (placaFormatada.Length == 7)
        {
            string letras = placaFormatada.Substring(0, 3);
            if (!letras.All(char.IsLetter))
            {
                Console.WriteLine("Falso. Placa inválida. Os três primeiros caracteres devem ser letras.");
                return;
            }

            string numeros = placaFormatada.Substring(3, 4);
            if (!numeros.All(char.IsDigit))
            {
                Console.WriteLine("Falso. Placa inválida. Os quatro últimos caracteres devem ser números.");
                return;
            }

            Console.WriteLine("Verdadeiro. Placa válida.");
        }
        else
        {
            Console.WriteLine("Falso. Placa inválida. A placa deve ter 7 caracteres.");
        }

    }
}