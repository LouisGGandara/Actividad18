CuentaBancaria cuenta1 = new CuentaBancaria(500);
CuentaBancaria cuenta2 = new CuentaBancaria(-100);

Console.WriteLine(cuenta1.Saldo); 
Console.WriteLine(cuenta2.Saldo); 

class CuentaBancaria {
    private double saldo;

    public CuentaBancaria(double saldo)  // Probando con el constructor para poder visualizarlo
    {
        this.saldo = saldo;
    }

    public string Saldo
    {
        get
        {
            if (saldo > 0)
            {
                return saldo.ToString();
            }
            else
            {
                return "Saldo no disponible.";
            }
        }
    }
}

