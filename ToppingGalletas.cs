
public class ToppingGalletas : Decorator
{
    public ToppingGalletas(OrdenBase orden) : base(orden)
    {
    }

    public override double CalculoTotalPrecioOrden()
    {
        //Console.WriteLine("Se añade topping de galletas");
        //Console.Write("Precio del ");
        var valor = base.CalculoTotalPrecio() + 0.45;
        
        return valor;
    }
}


