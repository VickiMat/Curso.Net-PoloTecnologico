using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazoCartas.Models
{
    public class Carta
    {
        public string Palo { get; set; }
        public int Numero { get; set; }

        Random rand = new Random();

        private string[] TipoDePalo = { "Basto", "Espada", "Oro", "Copa" };

        private int[] NumerosDeNaipe = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };

        //Constructor para inicializar las cartas con un palo y numero random. 
        public Carta()
        {
            Palo = TipoDePalo[rand.Next(0,4)];
            Numero = NumerosDeNaipe[rand.Next(0,10)];
        }

       
    }
}
