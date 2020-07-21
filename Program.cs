using System;
using Vegetais;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Qual animal vc escolhe?");
                var animal = CriarAnimal(Console.ReadLine());

                animal.Andar();
                animal.Comer(new Alface().Tipo);
            }
        }
        //Fabrica
        static Animal CriarAnimal(string tipoDeAnimal)
        {
            switch (tipoDeAnimal)
            {
                case "tartaruga":
                    return new Tartaruga();
                case "cachorro":
                    return new Cachorro();
                case "leopardo":
                    return new Leopardo();
                case "boi":
                    return new Boi();
                default:
                    throw new Exception("Desculpe, não conheço este animal.");
            }
        }
    }
}

