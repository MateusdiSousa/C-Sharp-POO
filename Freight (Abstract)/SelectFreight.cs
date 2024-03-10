namespace C_Sharp_POO
{
    public class SelectFreght
    {
        public static CalculatorFreightByMail Start()
        {
            CalculatorFreightByMail option = null;
            option = SelectMail();
            if (option != null)
            {
                System.Console.WriteLine("=====================================");
                System.Console.WriteLine($"\nCorreio : {option.Name()}");
                System.Console.WriteLine($"Prazo   : {option.Deadline()}");
                System.Console.WriteLine($"Preço   : {option.Valor()}");
                System.Console.WriteLine("\n=====================================");

                System.Console.WriteLine("\nDeseja finalizar a operação? (s/n)\n");
                System.Console.Write("r: ");
                string answer = Console.ReadLine();

                if (!String.IsNullOrEmpty(answer) && answer.ToLower() == "n")
                {
                    return Start();
                }
                else
                {
                    return option;
                }
            }
            else
            {
                return Start();
            }
        }

        public static CalculatorFreightByMail SelectMail()
        {
            System.Console.WriteLine("Selecione a opção de entrega: ");
            System.Console.WriteLine("1 - SEDEX");
            System.Console.WriteLine("2 - PAC ");
            System.Console.Write("r: ");
            string answer = Console.ReadLine();


            CalculatorFreightByMail selected;

            switch (answer)
            {
                case "1":
                    return new CalculatorFreghtSEDEX();
                    
                case "2":
                    return new CalculatorFreightPAC();
                    
                default:
                    System.Console.WriteLine("Valor não reconhecido tente novamente!");
                    return SelectMail();
                    
            }
        }
    }
}