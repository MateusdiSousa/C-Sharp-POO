using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO
{
    //A classe CalculatorFreightSEDEX está herdando os métodos da classe abstrata CalculatorFreghtByMail
    // Logo Calculator FreightSEDEX => Classe filho , CalculatorFreghtByMail => Pai

    // A palavra reservada 'seaked' não permiti criar especializações dessas classe
    public sealed class CalculatorFreghtSEDEX : CalculatorFreightByMail
    {
        //Override é usado para sobreescrever o método da classe 'Pai' que é a classe abstraya
        public override int Deadline()
        {
            return 4;
        }

        public override string Name()
        {
            return "SEDEX";
        }

        public override decimal Valor()
        {
            return 20;
        }
    }
}