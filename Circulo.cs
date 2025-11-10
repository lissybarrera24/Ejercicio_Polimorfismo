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
