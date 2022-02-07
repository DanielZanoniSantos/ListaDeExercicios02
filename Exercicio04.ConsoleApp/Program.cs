Console.Write("Digite um número qualquer: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

if(n != 0)
{
    if(n % 2 == 0)
    {
        Console.WriteLine("Número Par");
    }
    else
    {
        Console.WriteLine("Número Ímpar");
    }
}
Console.ReadKey();  