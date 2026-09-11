using Herenca;

class Retangulo : Formageometrica
{
    public double Largura;
    public double Altura;

    public Retangulo(double Largura, double Altura)
    {
        Largura = Largura;
        Altura = Altura;
    }

    public override double CalcularArea()
    {
        return Largura + Altura;
    }
}