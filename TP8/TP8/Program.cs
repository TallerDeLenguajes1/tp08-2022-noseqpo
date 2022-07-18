// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el ruta de carpeta valida:");
string path = Console.ReadLine();
if (Directory.Exists(path))
{
    List<string> archivos = new List<string>();
    archivos = Directory.GetFiles(path).ToList();
    Console.WriteLine("Archivos en el path:");
    foreach (string item in archivos)
    {
        Console.WriteLine(item);
    }
    List<string> directorios = new List<string>();
    int i = 0;
    foreach (var item in archivos)
    {
        string nombre = Path.GetFileNameWithoutExtension(item);
        string extension = Path.GetExtension(item);
        string linea = i + "," + nombre + "," + extension;
        i++;
        directorios.Add(linea);
    }
    File.WriteAllLines(@"C:\Users\Acer Aspire 5\Codigos\TallerDeLenguajesI\tp08-2022-noseqpo\TP8\TP8\index.csv", directorios);
}
else
{
    Console.WriteLine("No existe");
}