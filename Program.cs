using Wallet.Models;

namespace Wallet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Billetera billetera1 = new Billetera();
            Billetera billetera2 = new Billetera();


            billetera1.BilleteDe100 = 4;
            billetera1.BilleteDe500 = 2;
            billetera2.BilleteDe1000 = 200;

            billetera1.MostrarTotal();

            billetera1.Combinar(billetera2);

            billetera1.MostrarTotal();


        }
    }
}