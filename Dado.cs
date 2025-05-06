using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Dado
    {
        private string ladoGirado = "um";
        private int soma;

        public string LadoGirado { get => ladoGirado; set => ladoGirado = value; }
        public int Soma { get => soma; set => soma = value; }

        public Dado() { }

        public string Girar()
        {
            Random sortear = new Random();
            int resultado = sortear.Next(1, 7); 

            
            switch (resultado)
            {
                case 1: LadoGirado = "um"; break;
                case 2: LadoGirado = "dois"; break;
                case 3: LadoGirado = "tres"; break;
                case 4: LadoGirado = "quatro"; break;
                case 5: LadoGirado = "cinco"; break;
                case 6: LadoGirado = "seis"; break;
            }

            
            Soma += 7 - resultado;

            return LadoGirado;
        }
    }
}
