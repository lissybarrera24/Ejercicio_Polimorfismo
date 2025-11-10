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