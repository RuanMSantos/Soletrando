Console.Clear();

Console.WriteLine("\n-----Soletrando-----\n");
Console.WriteLine("Digite o texto a ser soletrado: ");

string texto = Console.ReadLine()!;

Console.WriteLine("\nSoletrando fica...\n");

Console.WriteLine(
String.Join("-", texto.ToUpper().ToCharArray())
);

Console.WriteLine();