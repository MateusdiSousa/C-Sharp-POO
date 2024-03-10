using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO
{
    public class OptionFreight
    {
        private string _name;
        private decimal _valor;
        private int _deadline;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public decimal Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public int Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }

        public OptionFreight(string name, decimal valor, int deadline)
        {
            Name = name;
            Valor = valor;
            Deadline = deadline;
        }
    }
}