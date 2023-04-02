using System;

Console.WriteLine("Ingrese dos frases para iniciar comparación");
Console.WriteLine("Ingrese frase 1");
string frasea = Console.ReadLine();
Console.WriteLine("Ingrese frase 2");
string fraseb = Console.ReadLine();

if (frasea.CompareTo(fraseb) == 0)
{
    Console.WriteLine("Las dos frases son idénticas");
}
else
{
    Console.WriteLine("Las frases son distintas");
}