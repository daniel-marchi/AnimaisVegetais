using System;
using Vegetais;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual animal vc escolhe?");
            var animal = Console.ReadLine();

            var alface = new Alface().Tipo;

            if (animal == "tartaruga")
            {
                var tartaruga = new Tartaruga();
                tartaruga.Andar();
                tartaruga.Comer(alface);
            }
            else if (animal == "cachorro")
            {
                var cachorro = new Cachorro();
                cachorro.Andar();
                cachorro.Comer(alface);
            }
            else if (animal == "leopardo")
            {
                var leopardo = new Leopardo();
                leopardo.Andar();
                leopardo.Comer(alface);
            }
            else
            {
                Console.WriteLine("Desculpe, não conheço este animal.");
            }
        }
    }
}

