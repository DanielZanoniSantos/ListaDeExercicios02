Console.Write("Digite o valor de A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Digite o valor de B: ");
int b = int.Parse(Console.ReadLine());

int soma = a + b;
int mult = a * b;
int c = 0;

Console.WriteLine();
if(a == b)
{
    c = soma;
    Console.WriteLine("Resultado atríbuido (soma): " + c);
}
else
{
    c = mult;
    Console.WriteLine("Resultado atríbuido (multiplicação): " + c);
}
Console.ReadKey();