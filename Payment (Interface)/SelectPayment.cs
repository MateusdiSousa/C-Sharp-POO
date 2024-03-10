using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO.Classes
{
    public class SelectPayment
    {
        public static IPayment Select()
        {
            System.Console.WriteLine("Informe o tipo de pagamento: ");
            System.Console.WriteLine("1- Boleto ");
            System.Console.WriteLine("2- Cartão de crédito");

            string option = Console.ReadLine();

            switch (option.ToLower())
            {
                case "1":
                    return new PaymentByTicket();
                case "2":
                    return new PaymentByCreditCard();
                default:
                    System.Console.WriteLine("Valor inválido, informe o número correspondente a opção");
                    return Select();
            }
        }
    }
}