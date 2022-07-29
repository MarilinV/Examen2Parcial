using System;

namespace Examen {
public class Decorator : OrdenBase
{
    protected OrdenBase orden;
    public Decorator (OrdenBase orden)
    {
        this.orden = orden;
        
    }

    public override double CalculoTotalPrecioOrden()
    {
        //Console.WriteLine("Calculo del precio total desde la clase decorator");
        return orden.CalculoTotalPrecioOrden();
    }

}
}