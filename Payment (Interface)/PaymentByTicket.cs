using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO
{
    public class PaymentByTicket : IPayment
    {
        public void Process(Bag bag)
        {
            System.Console.WriteLine($"Gerando Boleto da cesta com o valor total de: {bag.TotalPrice}");
        }
    }
}