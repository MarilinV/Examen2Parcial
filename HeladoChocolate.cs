using System;

namespace Examen {
public class HeladoChocolate : HeladoBase
{
    public override double CalculoTotalPrecio()
    {
        Console.Write("Total del Helado: ");
        var Helado1 = 1.60;
        return Helado1;
    }
}
}

/*
public class HeladoChocolate : OrdenBase
{
    public override double CalculoTotalPrecioOrden()
    {
        Console.Write("Helado Chocolate: ");
        return Helados.Sum(x => x.Precio);
    }
}
}
*/