using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_POO
{
    public class Item
    {
        //Constantes são usados geralmente para definir valores padrões utilizadas na regra de negócio
        private const int PADRAO_QUANTIDADE = 1;

        /// <summary>
        /// Modificadores de acesso
        /// Public -> o atributo pode ser acessado fora da classe
        /// Private -> o atributo pode ser acessado apenas pelos métodos da classe, podendo aplicar regras de negócio
        ///     exemplo: Impedir que o atributo preco seja um número negativo 
        /// </summary>

        // Uma convençãoo de nomenclatura é utilizar o "_" começo do nome de atributos privatos
        private string _name;
        private int _quantity;
        private decimal _price;
        //Compose -> quando um objeto é composto por outro objeto
        public decimal Total { get { return _price * _quantity; } }

        public string TotalForma => Total.ToString("C");

        // Construtores
        public Item(string name, int quantity, decimal price)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is empty");
            }
            else
            {
                _name = name;
            }
            if (quantity > 0)
            {
                _quantity = quantity;
            }
            else
            {
                _quantity = PADRAO_QUANTIDADE;
            }

            if (price > 0)
            {
                _price = price;
            }
            else
            {
                _price = 50.00M;
            }
        }

        public Item(string name, int quantity)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is empty");
            }
            _name = name;

            _price = decimal.Zero;

            if (quantity > 0)
            {
                _quantity = quantity;
            }
            else
            {
                _quantity = PADRAO_QUANTIDADE;
            }
        }

        //NO .NET utilizamos as propriedades, os atributos privados são acessados apartir dela
        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name is empty");
                }
                _name = value;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    _quantity = PADRAO_QUANTIDADE;
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 10.00M;
                }
            }
        }
        // Membros estáticos, são aqueles que não são instaciados, ou seja , não precisa de um objeto para utlizar esses métodos porque está no nivél de classe
        // Instacia é um objeto criado apartir de uma classe
        // Exemplo 1 = Console.WriteLine();
        // Exemplo 2:
        public static Item CreateBall()
        {
            var ball = new Item("Ball", 1, 99.99M);
            return ball;
        }

        /// <summary>
        /// NO JAVA O ACESSO A PROPRIEDADES PRIVADOS É ATRÁVES DOS MÉTODOS GET E SET
        // public string GetName()
        // {
        //     return _name;
        // }

        // public void SetName(string name)
        // {
        //     if (String.IsNullOrEmpty(name))
        //     {
        //         throw new ArgumentNullException("Nome está vazio");
        //     }
        //     this._name = name;
        // }
        /// </summary>
        /// <returns></returns>
    }
}