using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO
{
    public class Bag
    {
        //Compose é quando um objeto é composto por outros objetos
        // EXEMPLO: A bag é composta por vários itens dentro dela
        public List<Item> Itens;

        private decimal totalPrice;
        public Bag()
        {
            Itens = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Itens.Add(item);
        }

        public void ListItens()
        {
            foreach (Item item in Itens)
            {
                System.Console.WriteLine($"\nName: {item.Name}");
                System.Console.WriteLine($"Unity Price: {item.Price}");
                System.Console.WriteLine($"Quantity: {item.Quantity}");
                totalPrice += item.Total;
            }
            System.Console.WriteLine($"\nTotal: {totalPrice.ToString("C")}");
        }
    }
}