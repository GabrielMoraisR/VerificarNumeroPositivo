class VerificarNumeroPositivo
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else
        {
            Console.WriteLine("O número não é positivo.");
        }
    }
}
