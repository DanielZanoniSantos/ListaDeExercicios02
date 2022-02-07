double a = 0;
double b = 0;
double c = 0;

Console.Write("Digite o valor de A: ");
a = double.Parse(Console.ReadLine());
Console.Write("Digite o valor de B: ");
b = double.Parse(Console.ReadLine());
Console.Write("Digite o valor de C: ");
c = double.Parse(Console.ReadLine());

double soma = a + b;
Console.WriteLine("");

if (soma > c)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Soma de A e B é maior que C, resultado da soma: " + soma + "\n" + "Valor de C: " + c);
    Console.ReadKey();
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Soma de A e B é menor que C, resultado da soma: " + soma + "\n" + "Valor de C: " + c);
    Console.ReadKey();
    Console.ResetColor();
}