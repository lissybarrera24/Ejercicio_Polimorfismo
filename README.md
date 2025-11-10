# Ejercicio_Polimorfismo
Forma.cs

public class forma
{
    public string Nombre { get; set; }
    public Forma (String nombre)
    {
        Nombre = nombre; 
    }
    //Metodo virtual que las clase hijas podran sobrescribir
    public virtual double CalcularArea()
    {
        return 0.0;
    }
}

Circulo.cs

public class Circulo
{
    public class Circulo : Forma 
    {
        public double Radio { get; set; }
        public Circulo(double radio) : base("Circulo")
        {
            Radio = radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }

Rectangulo.cs

public class Rectangulo
{
    public class Rectangulo : Forma
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo (double ancho, double alto) : base("Rectangulo")
        {
            Ancho = ancho;
            Alto = alto;

        }

        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }

    Program.cs

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
