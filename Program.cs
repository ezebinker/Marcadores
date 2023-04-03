namespace Marcadores;
class Program
{
    static void Main(string[] args)
    {
        Marcador m1 = new Marcador("AAA123", "Verde");
        Marcador m2 = new Marcador("BBB456", "Rojo");

        Console.WriteLine(m1.Codigo + " " + m1.NivelTinta);
        Console.WriteLine(m2.Codigo + " " + m2.NivelTinta);

        m1.Escribir("Hola como estas");
        m2.Escribir("Hola que tal");
    }
}
