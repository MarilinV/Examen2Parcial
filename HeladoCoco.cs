using System;

namespace Examen {
public class HeladoCoco : OrdenBase
{
    public override double CalculoTotalPrecioOrden()
    {
        Console.Write("Total del Helado: ");
        var Helado2 = 1.10;
        return Helado2;
    }
}
}


/*
public class HeladoCoco : OrdenBase
{
    public override double CalculoTotalPrecioOrden()
    {
        Console.Write("Helado Coco: ");
        return Helados.Sum(x => x.Precio);
    }
}
}
*/