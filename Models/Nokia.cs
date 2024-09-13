using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CELULAR_COM_POO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void Ligar() {
            Console.WriteLine("Ligando seu NOKIA...");
        }

        public override void InstalarAplicativo(string nomeAPP)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeAPP} no seu NOKIA");
        }
    }
}