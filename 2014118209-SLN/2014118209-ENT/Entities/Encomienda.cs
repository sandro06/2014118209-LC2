using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118209_ENT.Entities
{
    public class Encomienda : Servicio
    {

        public string Beneficiario { get; set; }
        public double Peso { get; set; }
        public override void Service()
        {
            Console.WriteLine("Encomiendas");
            Console.WriteLine("------------------------------------------------------------------------------");
            for (int i = 0; i < 2; i++)
            {
                int x;
                switch (i) { case 0: x = r.Next(3); break; default: x = r.Next(2, 6); break; }
                var encomiendas = (Encomiendas)x;
                string encomienda = encomiendas.ToString();
                if (encomienda.Equals("Arroz")) Peso = 30;
                else if (encomienda.Equals("Papa")) Peso = 40;
                else if (encomienda.Equals("Camote")) Peso = 25;
                else if (encomienda.Equals("Piña")) Peso = 45;
                else if (encomienda.Equals("Cebolla")) Peso = 35;
                else Peso = 15;
                Console.WriteLine("Encomienda : {0}      Peso: {1}kg", encomienda, Peso);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.ReadLine();
        }
        public enum Encomiendas { Arroz, Papa, Camote, Piña, Cebolla, Limon }

        Random r = new Random();


    }
}
