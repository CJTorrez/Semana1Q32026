try
{
    // Console.WriteLine("Ingrese primerr numero");
    // double n1 = double.Parse(Console.ReadLine() ?? "0");

    // Console.WriteLine("Ingrese segundo numero:");
    // double n2 = double.Parse(Console.ReadLine() ?? "0");

    // double division = n1 / n2;

    // Console.WriteLine("La diision es: " + division);
    // Console.WriteLine($"La fivision es: {division}"); //interrpellacion

    List<string> lista = new List<string>()
    {
        "Matematias",
        "Español",
        "Musica",
    };
    lista.Add("Programacion II");
    lista.Add("Ciencias Naturales");
    lista.Insert(0,"Historia de honduras");
    lista.Add("Programacion II");
    lista.Add("Programacion II");
    lista.Add("Programacion II");
    
    //lista.Remove("Programacion II");
    //lista.RemoveAll(nombre => nombre.Contains("Programacion II"));

    foreach(var item in lista)
    {
        Console.WriteLine(item);
    }
    //Console.WriteLine(lista[10]);
    Console.WriteLine();

    Dictionary<string, int> edades = new Dictionary<string, int>()
    {
        {"Juan Perez", 18},
        {"Carlos Perrez", 25}
    };
    edades.Add("Sandra Perrez", 30);
    edades.Add("juan perez", 18);

    foreach(var item in edades)
    {
        Console.WriteLine($"key:{item.Key}, valor: {item.Value}");
    }

    Console.WriteLine(edades["Juan Perez"]);
}
catch (FormatException fe){

Console.WriteLine($"Error de tipo de formato: {fe.Message}");
}

catch (ArgumentOutOfRangeException fe)
{
    Console.WriteLine($"Error de indice incorrrecto: {fe.Message}");
}

// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }