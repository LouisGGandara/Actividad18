Estudiante e1 = new Estudiante();
e1.Edad = 25;
Console.WriteLine("e1.Edad es: " + e1.Edad);
Console.WriteLine($"e1.edad es: ...Inaccesible por su nivel de protección...");

Estudiante e2 = new Estudiante();
e2.Edad = 250;
Console.WriteLine($"e2.Edad es: {e2.Edad}");
Console.WriteLine("e2.edad es: ...Inaccesible por su nivel de protección...");


class Estudiante
{
    private int edad;

    public int Edad
    {

        // Aquí no es necesario un constructor porque int se asigna 0 por default
        get
        { if (edad < 0 || edad > 100)
            {
                return 0;
            }
            else { return edad; }
        }
        set { edad = value; }
    }
}