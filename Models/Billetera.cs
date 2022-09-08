using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Wallet.Models
{
    internal class Billetera
    {
        public int BilleteDe10 { get; set; }
        public int BilleteDe20 { get; set; }
        public int BilleteDe50 { get; set; }
        public int BilleteDe100 { get; set; }
        public int BilleteDe200 { get; set; }
        public int BilleteDe500 { get; set; }
        public int BilleteDe1000 { get; set; }

     



        public decimal Total()
        {
            decimal pesosBilleteDe10 = BilleteDe10 * 10;
            decimal pesosBilleteDe20 = BilleteDe20 * 20;
            decimal pesosBilleteDe50 = BilleteDe50 * 50;
            decimal pesosBilleteDe100 = BilleteDe100 * 100;
            decimal pesosBilleteDe200 = BilleteDe200 * 200;
            decimal pesosBilleteDe500 = BilleteDe500 * 500;
            decimal pesosBilleteDe1000 = BilleteDe1000 * 1000;
           

            decimal importeTotal = pesosBilleteDe10 + pesosBilleteDe20 + pesosBilleteDe50 + pesosBilleteDe100 + pesosBilleteDe200 + pesosBilleteDe500 + pesosBilleteDe1000;

        
            return importeTotal;
        }

        public void VaciarBilletera()
        {
            BilleteDe10 = 0;
            BilleteDe20 = 0;
            BilleteDe50 = 0;
            BilleteDe100 = 0;
            BilleteDe200 = 0;
            BilleteDe500 = 0;
            BilleteDe1000 = 0;
        }


        public Billetera Combinar(Billetera bille1)
        {   
            Billetera billetera3 = new Billetera();

            billetera3.BilleteDe10 = bille1.BilleteDe10 + BilleteDe10;
            billetera3.BilleteDe20 = bille1.BilleteDe20 + BilleteDe20;
            billetera3.BilleteDe50 = bille1.BilleteDe50 + BilleteDe50;
            billetera3.BilleteDe100 = bille1.BilleteDe100 + BilleteDe100;
            billetera3.BilleteDe200 = bille1.BilleteDe200 + BilleteDe200;
            billetera3.BilleteDe500 = bille1.BilleteDe500 + BilleteDe500;
            billetera3.BilleteDe1000 = bille1.BilleteDe1000 + BilleteDe1000;

            VaciarBilletera();
            bille1.VaciarBilletera();

            Console.WriteLine($"Está nueva billetera combinada tiene en total ${billetera3.Total()}. \n ${billetera3.BilleteDe10*10} en billetes de $10 \n ${billetera3.BilleteDe20*20} en billetes de $20 \n ${billetera3.BilleteDe50*50} en billetes de $50" +
                $"\n ${billetera3.BilleteDe100*100} en billetes de $100 \n ${billetera3.BilleteDe200*200} en billetes de $200 \n ${billetera3.BilleteDe500*500} en billetes de $500 \n y ${billetera3.BilleteDe1000*1000} en billetes de $1000");
            return billetera3;

        }

        public void MostrarTotal()
        {
            Console.WriteLine($"Está billetera tiene en total ${Total()}. \n ${BilleteDe10*10} en billetes de $10 \n ${BilleteDe20*20} en billetes de $20 \n ${BilleteDe50*50} en billetes de $50" +
                $"\n ${BilleteDe100*100} en billetes de $100 \n ${BilleteDe200*200} en billetes de $200 \n ${BilleteDe500*500} en billetes de $500 \n y ${BilleteDe1000*1000} en billetes de $1000");
        } 
    }
}
