using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO
{
    public abstract class CalculatorFreightByMail : ICalculatorFreight
    {
        public abstract string Name();
        public abstract decimal Valor();
        public abstract int Deadline();
        public OptionFreight Calculate(Bag bag)
        {
            var serviceName = Name();
            if (String.IsNullOrWhiteSpace(serviceName))
            {
                return null;
            }

            return new OptionFreight(Name(), Valor(), Deadline());
        }
    }
}