// See https://aka.ms/new-console-template for more information
using System.Linq;

string[] names = { "Tiana", "Dwayne", "Helena", "Ada", "Eve" };
var shortNames = names.Where(n => n.Length < 4);
foreach (string name in shortNames)
{
    Console.WriteLine("These are the shortest names: " + name);
}

string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };
 
// Query syntax
var queryResult = from x in heroes 
                                    where x.Contains('a')
                                    select $"{x} contains an 'a'";

// Method syntax
var methodResult = heroes
                                    .Where(x => x.Contains('a'))
                                    .Select(x => $"{x} contains an 'a");

// Printing....
Console.WriteLine("query result: ");
foreach (string s in queryResult)
{
    Console.WriteLine(s);
}

Console.WriteLine("\nmethod result: ");
foreach (string s in methodResult)
{
    Console.WriteLine(s);
}