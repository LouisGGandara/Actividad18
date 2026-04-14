Empleado e1 = new Empleado(3000);
Empleado e2 = new Empleado(4500);
Console.WriteLine(e2.Salario);
Console.WriteLine(e1.Salario);

class Empleado
{
    private double salario;
    double salarioMinimo = 4500;

    public Empleado(double salario)
    {
        this.salario = salario;
    }

    public string Salario
    {
        get
        {
            if (salario < salarioMinimo)
            {
                return "Salario inválido";
            } else
            {
                return "Q" + salario.ToString();
            }
        }
    }
}