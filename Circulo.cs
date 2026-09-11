using Herenca;

class Circulo : Formageometrica
{
    public double Raio;

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}