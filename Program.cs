namespace PraticandoConceitos;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual exercicio deseja executar? 1-6");
        string exercicio = Console.ReadLine();

        switch (exercicio)
        {
            case "1":
                var exercicio1 = new Exercicio1();
                exercicio1.Run();
                break;
            case "2":
                var exercicio2 = new Exercicio2();
                exercicio2.Run();
                break;
            case "3":
                var exercicio3 = new Exercicio3();
                exercicio3.Run();
                break;
            case "4":
                var exercicio4 = new Exercicio4();
                exercicio4.Run();
                break;
            case "5":
                var exercicio5 = new Exercicio5();
                exercicio5.Run();
                break;
            case "6":
                var exercicio6 = new Exercicio6();
                exercicio6.Run();
                break;
            default:
                Console.WriteLine("Exercício não encontrado.");
                break;
        }
    }
}
