# C-Sharp-POO

# 4 Pilares 

## Abstração 
    É a habilidade de abstrair características essenciais de um objeto, ignorando detalhes menos relevantes.
    Exemplo:
        public abstract class Forma
        {
            public abstract double CalcularArea();
        }

        public class Quadrado : Forma
        {
            public double Lado { get; set; }
    
            public override double CalcularArea()
            {
                return Lado * Lado;
            }
        }

## Encapsulamento 
    É a técnica de fazer com que os detalhes internos de uma classe estejam ocultos para as outras classes
    Exemplo:
        public class Carro
        {
            private string modelo; // Propriedade encapsulada
    
            public string Modelo
            {
                get { return modelo; }
                set { modelo = value; }
            }
}
## Herança 
    Permite que uma classe herde características e comportamentos de outra classe.
    Exemplo:
        public class Animal { }

        public class Mamifero : Animal { } // Mamifero herda de Animal

## Polimorfismo
    Permite que uma classe herde características e comportamentos de outra classe
    Exemplo:
        public interface Animal
        {
            public virtual void EmitirSom()
        }

        public class Cachorro : Animal
        {
            public void EmitirSom()
            {
                Console.WriteLine("Latido");
            }
        }


