// See https://aka.ms/new-console-template for more information
// int[] numeros = { 1, 2, 3, 4, 5 };
int[] numeros = Enumerable.Range(1, 5).ToArray();

// Sintaxis 1: Sintaxis de metodos
// var numerosPares = numeros.Where(n => n % 2 == 0).ToList();
var numerosPares = numeros.Where(n =>
{
    Console.WriteLine($"Evaluando si {n} es par");
    return n % 2 == 0;
}).ToList();


// Sintaxis 1: Sintaxis de queries

var numerosPares2 = (from n in numeros
                where n % 2 == 0
                select n).ToList();
foreach (var numero in numerosPares)
{
    Console.WriteLine($"Si, el {numero} es par.");
}                                
