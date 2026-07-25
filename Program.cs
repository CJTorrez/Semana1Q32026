using System.Transactions;

try
{
    Console.WriteLine("Ingrese primerr numero");
    double n1 = double.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Ingrese segundo numero:");
    double n2 = double.Parse(Console.ReadLine() ?? "0");

    double division = n1 / n2;

    Console.WriteLine("La diision es: " + division);
    Console.WriteLine($"La fivision es: {division}"); //interrpellacion
}
catch (FormatException fe){

Console.WriteLine($"Error de tipo de formato: {fe.Message}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}