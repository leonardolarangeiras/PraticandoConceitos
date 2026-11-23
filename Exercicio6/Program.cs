namespace PraticandoConceitos;

public class Exercicio6
{
    public void Run()
    {
        Console.WriteLine("Em que formato deseja ver a data atual ?");
        Console.WriteLine("1-Completo: dddd dd/MM/yyyy HH:mm:ss");
        Console.WriteLine("2-Data: dd/MM/yyyy");
        Console.WriteLine("3-Hora: HH:mm:ss");
        Console.WriteLine("4-Extenso: dd de MMMM de yyyy");
        Console.WriteLine("Digite o número correspondente ao formato desejado:");
        string formato = Console.ReadLine();

        DateTime dataAtual = DateTime.Now;

        switch (formato)
        {
            case "1":
                Console.WriteLine(dataAtual.ToString("dddd dd/MM/yyyy HH:mm:ss"));
                break;
            case "2":
                Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
                break;
            case "3":
                Console.WriteLine(dataAtual.ToString("HH:mm:ss"));
                break;
            case "4":
                Console.WriteLine(dataAtual.ToString("dd MMMM yyyy"));
                break;
            default:
                Console.WriteLine("Formato inválido.");
                break;
        }
    }
}