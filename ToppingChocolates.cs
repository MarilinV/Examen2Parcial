
public class ToppingChocolates : Decorator
{
    public ToppingChocolates(OrdenBase orden) : base(orden)
    {
    }

    public override double CalculoTotalPrecioOrden()
    {
        //Console.WriteLine("Se añade topping de chocolates");
        //Console.Write("Precio del ");
        var valor = base.CalculoTotalPrecio() + 0.25;
        return valor;
    }
}
