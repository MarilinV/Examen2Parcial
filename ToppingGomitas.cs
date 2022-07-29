
public class ToppingGomitas : Decorator
{
    public ToppingGomitas(OrdenBase orden) : base(orden)
    {
    }

    public override double CalculoTotalPrecioOrden()
    {
        //Console.WriteLine("Se añade topping de gomitas");
        //Console.Write("Precio del ");
        var valor = base.CalculoTotalPrecio() + 0.30;
        
        return valor;
    }
}
