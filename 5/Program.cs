Usuario good = new Usuario("10293847abcdefg");
Usuario bad = new Usuario("123ABC");
Console.WriteLine(good.Contrasena);
Console.WriteLine(bad.Contrasena);

class Usuario
{
    private string contrasena;

    public Usuario(string contrasena)
    {
        this.contrasena = contrasena;
    }

    public string Contrasena
    {
        get
        {
            if (contrasena.Length < 8)
            {
                return "Contraseña insegura...";
            } else
            {
                for (int i = 1; i <= contrasena.Length; i++)
                {
                    Console.Write("*");
                }
                return "";
            }
        }
    }
}
