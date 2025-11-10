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