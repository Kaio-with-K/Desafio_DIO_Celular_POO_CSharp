using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CELULAR_COM_POO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public virtual void Ligar() {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao(string tel) {
            Console.WriteLine($"Recebendo uma ligação de {tel}");
        }

        public abstract void InstalarAplicativo(string nomeAPP);
    }
}