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

        static Animal CriarAnimal(string tipoDeAnimal)
        {
            return CriarAnimal(Enum.Parse<AnimalEspecie>(tipoDeAnimal, true));
        }
        //Fabrica
        static Animal CriarAnimal(AnimalEspecie tipoDeAnimal)
        {
            switch (tipoDeAnimal)
            {
                case AnimalEspecie.Boi:
                    return new Boi();
                case AnimalEspecie.Cachorro:
                    return new Cachorro();
                case AnimalEspecie.Leopardo:
                    return new Leopardo();
                case AnimalEspecie.Tartaruga:
                    return new Tartaruga();
                default:
                    throw new Exception("Desculpe, não conheço este animal.");
            }
        }
    }
}

