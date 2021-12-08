using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    internal class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }
        public int Mes 
        {
            get
            {
                return this.mes;
            }
            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            } 
        }

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                Console.WriteLine(this.mes);
            }
            else
            {
                Console.WriteLine("Mês inválido!");
            }
        }
    }
}
