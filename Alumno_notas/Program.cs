int can = 0;
int var = 0;
int suma = 0;
string nombre;
Console.WriteLine("Introduce el nombre del alumno");
nombre = Console.ReadLine();
Console.WriteLine("Cuantas notas: ");
can = int.Parse(Console.ReadLine());
int[] vec = new int[can + 1];

int k = 0;
while (k < can)
{
    do
    {
        Console.WriteLine("Introduce una nota: ");
        var = int.Parse(Console.ReadLine());

    } while (var < 1 || var > 100);
    vec[k] = var;
    suma += vec[k];
    k++;
}
Console.WriteLine("Fin del programa");
Console.ReadKey(true);