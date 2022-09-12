using MazoCartas.Models;



namespace MazoCartas
{
    internal class Program
    {
        static void Main(string[] args) {

            Mazo mazo1 = new Mazo();

            int opcionElegida = 0;
            mazo1.inicializarBaraja();

            do
            {
                Console.WriteLine("Elija una acción a realizar con la baraja de cartas:");
                Console.WriteLine("1 - Barajar\r\n2 - Mostrar siguiente carta\r\n3 - Mostrar cartas disponibles\r\n4 - Dar cartas\r\n5 - Mostrar cartas del monton\r\n6 - Mostrar baraja\r\n7 - Salir\r\n");
                opcionElegida = int.Parse(Console.ReadLine());

                switch (opcionElegida)
                {
                    case 1:
                        mazo1.Barajar();
                        break;
                    case 2:
                        mazo1.SiguienteCarta();
                        break;
                    case 3:
                        mazo1.CartasDisponibles();
                        break;
                    case 4:
                        Console.WriteLine("Cuántas cartas desea retirar?");
                        int cantidad = int.Parse(Console.ReadLine());
                        mazo1.DarCartas(cantidad);
                        break;
                    case 5:
                        mazo1.CartasMonton();
                        break;
                    case 6:
                        mazo1.MostrarBaraja();
                        break;
                }
            }
            while (opcionElegida != 7);

        }
     

        
     
       
    }

}
        

    

