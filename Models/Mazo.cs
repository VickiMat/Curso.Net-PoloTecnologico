namespace MazoCartas.Models
{
    public class Mazo
    {
        public Mazo()
        {
            
        }
        public List<Carta> baraja = new List<Carta>();
        public List<Carta> monton = new List<Carta>();
        
        public void inicializarBaraja()
        {
            for (int i = 0; i < 40; i++)
            {
                var carta = new Carta();
                baraja.Add(carta);
            }

        }
        public void Barajar()
        {   Random rand = new Random();
            baraja = baraja.OrderBy(carta => rand.Next()).ToList();

            Console.WriteLine("Se está mezclando su baraja");
            Console.WriteLine();
        }

        public void MostrarBaraja()
        {
            Console.WriteLine("Sus cartas son: ");
            Console.WriteLine();
            int i = 0;
            foreach (var carta in baraja)
            {
                i++;
                Console.WriteLine($"{i}- {carta.Numero} de {carta.Palo} \r\n");
               
            }
        }

        public void SiguienteCarta()
        {
            if (baraja.Count == 0)
            {
                Console.WriteLine("Ya no le quedan cartas disponibles en el mazo");
            }

            Carta siguienteCarta = baraja[0];
            Console.WriteLine($@"La carta siguiente es {siguienteCarta.Numero} de {siguienteCarta.Palo}");
            Console.WriteLine();
            baraja.Remove(siguienteCarta);
            monton.Add(siguienteCarta);
        }

        public void CartasDisponibles()
        {
            int cartasDisponibles = baraja.Count;
            Console.WriteLine($"Le quedan {cartasDisponibles} cartas en el mazo");
            Console.WriteLine();

        }

        public void DarCartas(int cantidad)
        {
            if(cantidad <= baraja.Count)
            {
                Console.WriteLine("Estás son las cartas que sacó:");
                for (int i = 0; i < cantidad; i++)
                {
                    Carta retirada = baraja[0];
                    Console.WriteLine($@"{i+1} {retirada.Numero} de {retirada.Palo}.");
                    Console.WriteLine();
                    baraja.Remove(retirada);
                    monton.Add(retirada);
                }
            }
            else Console.WriteLine("No le quedan sufientes cartas en el mazo, pruebe a sacar menos cartas.");
            Console.WriteLine();

        }

        public void CartasMonton()
        {
            if (monton.Count != 0)
            {
                Console.WriteLine($"Tiene {monton.Count} cartas en el montón. \r\n");
                int i = 0;
                foreach (var carta in monton)
                {
                    i++;
                    Console.WriteLine($"{i}- {carta.Numero} de {carta.Palo}");
                }
            } else
            Console.WriteLine("No hay ninguna carta en el montón, pruebe a sacar una carta del mazo.");
            Console.WriteLine();
        }
         
}
}
