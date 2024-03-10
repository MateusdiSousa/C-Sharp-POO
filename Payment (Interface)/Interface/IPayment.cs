using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO
{
    public interface IPayment
    {
        public void Process(Bag bag);
    }
}