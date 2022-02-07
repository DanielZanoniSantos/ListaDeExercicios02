int i = 0;

List<int> numeros = new List<int>();

while (i <= 2)
{
    Console.Write("Digite o " + (i + 1) + "º número: ");
    numeros.Add(int.Parse(Console.ReadLine()));
    i++;
}

numeros.Sort();
numeros.Reverse();
Console.WriteLine("");
Console.Write("Números em ordem crescente: "); 

foreach(int ordem in numeros)
{
    Console.Write(ordem+" ");
}
Console.ReadKey();