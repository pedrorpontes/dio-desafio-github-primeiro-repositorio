using System;

namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double Comprimento { get; set; }
        private double Largura { get; set; }
        private bool Valido { get; set; }

        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                Comprimento = comprimento;
                Largura = largura;
                Valido = true;
            }
            else
            {
                Console.WriteLine("Valores inválidos");
            }
        }

        public double ObterArea()
        {
            if (Valido)
            {
                return Comprimento * Largura;
            }
            else
            {
                Console.WriteLine("Preencha valores válidos");
                return 0;
            }
        }
    }
}
