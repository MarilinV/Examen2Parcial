using System;

namespace Examen
{
    public class Program
    {
        public static void Main(string[] arg)
        {

            var Helado1 = new HeladoChocolate();
            Console.WriteLine("$"+Helado1.CalculoTotalPrecioOrden());
            //Console.WriteLine();

            var Topping = new ToppingGomitas(Helado1);
            Console.WriteLine("$"+Topping.CalculoTotalPrecioOrden());

            Console.WriteLine();

            /*
            var Helado2 = new HeladoFresa();
            Console.WriteLine(Helado2.CalculoTotalPrecioOrden());
            Console.WriteLine();
            */

            /*
            var toppingomas = new HeladoFresa();
            Console.WriteLine(toppinggomas.CalculoTotalPrecioOrden());
            Console.WriteLine();
            */

            //Console.WriteLine();


            /*
            var Helado3 = new HeladoCoco();
            Console.WriteLine(Helado3.CalculoTotalPrecioOrden());
            Console.WriteLine();
            */

            /*
            var toppinggalleta = new HeladoFresa();
            Console.WriteLine(toppinggalleta.CalculoTotalPrecioOrden());
            Console.WriteLine();
            */

            //Console.WriteLine();
        }
    }
}