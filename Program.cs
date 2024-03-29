﻿using System.Runtime.InteropServices;
using C_Sharp_POO;
using C_Sharp_POO.Classes;

namespace C_Sharp_POO
{
    class program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n===========================================\n");

            System.Console.WriteLine("Objeto bag sendo instânciado e retornando os objetons itens: \n");

            //Crio itens 
            Item ball = new Item("Ball", 0, 0);
            Item car = new Item("Car", 4, 22.00M);
            Item doy = new Item("Doy", 3, 15.55M);

            //Crio uma bag para guardar os itens
            Bag bag = new Bag();

            //Adiciono os itens a mochila
            bag.AddItem(doy);
            bag.AddItem(car);
            bag.AddItem(ball);

            // Mostro todos os itens que estão na minha bag
            bag.ListItens();


            //Variavél armazenada por valor, são os tipos primitivos, que copiam o valor e passam para a sua memoria
            //Isso ocorre apenas com valores primitivos
            int v1 = 10;
            int v2 = 20;

            v2 = v1;
            v1 = 30;
            System.Console.WriteLine("\n===========================================\n");
            System.Console.WriteLine("Variável por valor (Tipo primitivo):");
            System.Console.WriteLine($"V1 : {v1}");
            System.Console.WriteLine($"V2 : {v2}");

            //Valor por referencia, são variáveis que estão apontando para algum local da memória, casa o valor mude,
            //todas a variáveis que apontam para esse local serão alteradas
            //Isso acontece com os objetos de uma classe

            Item caneta1 = new Item("Caneta", 1, 1M);

            Item caneta_azul = caneta1;

            caneta1.Name = "Caneta azul";

            System.Console.WriteLine("\nVariável por referência (Classe)");
            System.Console.WriteLine($"Caneta1: {caneta1.Name}");
            System.Console.WriteLine($"Caneta_azul: {caneta_azul.Name}");

            System.Console.WriteLine("\n===========================================\n");
            // bola.quantidade = 1;
            // bola.preco = 90.00M;

            // CarrinhoItem camseta = new CarrinhoItem();
            // bola.name = "Camiseta preta";
            // bola.quantidade = 1;
            // bola.preco = 150M;

            ICalculatorFreight calculator = SelectFreght.Start();

            var optionFreight = calculator.Calculate(bag);

            if (optionFreight != null)
            {
                System.Console.WriteLine($"Frete selecionado: {optionFreight.Name}");
            }

            //Outros exemplos de classe pai e filho 
            //Stream => Pai
            //  FileStream => filho
            //  MemoryStream => filho

            IPayment payment = SelectPayment.Select();
            payment.Process(bag);
        }
    }
}