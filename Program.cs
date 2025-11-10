public class Program
{
    static void Main(string[] args)
    {
        //Crear lista de formas
        List<Forma> formas = new List<Forma>();

        //Instancias de clases derivadas
        Circulo circulo = new Circulo(5.0);
        Rectangulo rectangulo = new Rectangulo(4.0, 6.0);

        //Agregarlas a la lista
        formas.Add(circulo);
        formas.Add(rectangulo);

        //Recorrer la lista y mostrar las areas 
        foreach (Forma forma in fromas)
        {

            Console.WriteLine($"Forma: {forma.Nombre}, Area: {forma.CalcularArea():0.00}" );

        }

        Console.ReadKey();
    }
}