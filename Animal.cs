using System;
using System.Threading;

namespace Animais
{
    public class Animal
    {
        public string Tipo { get; set; }

        public int TempoDoPasso { get; set; }

        public void Comer(string comida)
        {
            Console.WriteLine($"{Tipo} está comendo {comida}");
        }

        public void Andar()
        {
            Console.WriteLine($"O {Tipo} vai andar!");

            for (int cont = 10; cont > 0; cont--)
            {
                Console.WriteLine($"{Tipo} deu {cont} passo(s).");
                Thread.Sleep(TempoDoPasso);
            }

            Console.WriteLine($"O {Tipo} andou!");
        }
    }
}

