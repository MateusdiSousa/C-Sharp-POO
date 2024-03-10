namespace C_Sharp_POO
{
    public class PaymentByCreditCard : IPayment
    {
        public void Process(Bag bag)
        {
            System.Console.WriteLine($"Realizando o pagamento da cesta no valor total de: {bag.TotalPrice}");
            System.Console.WriteLine($"Pagamento com cartão de crédito realizado com sucesso!");
        }
    }
}