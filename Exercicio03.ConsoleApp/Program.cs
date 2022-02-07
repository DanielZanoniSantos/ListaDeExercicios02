Console.Write("Digite seu peso em KG: ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Digite sua altura em metros: ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);
Console.WriteLine();

if (imc < 18.5)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Seu IMC é de " + Math.Round(imc, 2) + ", classificado como abaixo do peso.");
    Console.ResetColor();
}
else if(imc > 18.5 && imc < 25)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Seu IMC é de " + Math.Round(imc, 2) + ", classificado como peso normal.");
    Console.ResetColor();
}
else if(imc > 25 && imc < 30)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Seu IMC é de " + Math.Round(imc, 2) + ", classificado como acima do peso.");
    Console.ResetColor();
}
else if(imc >= 30)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Seu IMC é de " + Math.Round(imc, 2) + ", classificado como obeso.");
    Console.ResetColor();
}
Console.ReadKey();