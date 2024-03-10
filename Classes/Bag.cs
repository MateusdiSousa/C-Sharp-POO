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
        private IList<Item> _itens;
        public IEnumerable<Item> Itens 
        {
            get { return _itens.AsEnumerable();}
        }

        private decimal totalPrice;

        public decimal TotalPrice
        {
            get
            { 
                return _itens.Sum(x => x.Total);
            }
        }
        public Bag()
        {
            _itens = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _itens.Add(item);
        }

        public void RemoveItem(Item item)
        {
            _itens.Remove(item);
        }

        public void ListItens()
        {
            foreach (Item item in _itens)
            {
                System.Console.WriteLine($"\nName: {item.Name}");
                System.Console.WriteLine($"Unity Price: {item.Price}");
                System.Console.WriteLine($"Quantity: {item.Quantity}");
            }
            System.Console.WriteLine($"\nTotal: {totalPrice.ToString("C")}");
        }
    }
}