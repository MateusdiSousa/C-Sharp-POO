using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO
{
    public class CalculatorFreightPAC : CalculatorFreightByMail
    {
        public override int Deadline()
        {
            return 8;
        }

        public override string Name()
        {
            return "PAC";
        }

        public override decimal Valor()
        {
            return 15M;
        }
    }
}