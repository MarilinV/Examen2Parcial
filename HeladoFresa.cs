using System;

namespace Examen {
public class HeladoFresa : HeladoBase
{
    public override double CalculoTotalPrecio()
    {
        Console.Write("Total del Helado: ");
        var Helado3 = 2.25;
        return Helado3;
    }
}
}

/*
public class HeladoFresa : OrdenBase
{
    public override double CalculoTotalPrecioOrden()
    {
        Console.Write("Helado Fresa: ");
        return Helados.Sum(x => x.Precio);
    }
}
}
*/

