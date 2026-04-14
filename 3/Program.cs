Producto p1 = new Producto();
p1.Precio = 12.5;
Producto p2 = new Producto();
p2.Precio = -25;
Console.WriteLine($"p1.Precio es: {p1.Precio}");
Console.WriteLine($"p2.Precio es: {p2.Precio}");
class Producto
{
    private double precio;

    public double Precio
    {
        get
        {
            if (precio < 0)
            {
                return 0;
            } else
            {
                return precio;
            }
        }
        set
        {
            precio = value; 
        } 
    }
}