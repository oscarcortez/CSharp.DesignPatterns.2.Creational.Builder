using Models;
using System;

namespace CSharp.DesignPatterns.Creational.Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder; // es un abstract

            AssemblyLine shop = new();

            // dependiendo que builder se instancie varia los elementos que se guardan en su attribute: SingleSandwich
            builder = new HamAndCheese();
            shop.Assemble(builder);

            // como se agrego hamAndCheese: se ha almacenado en la collection de singleSandwich todo respecto a hamAndCheese
            Console.WriteLine(builder.SingleSandwich.Show());

            // singleSandwich (sandwich) es una clase indexer que almacena lo que el builder HamAndCheese le ordena

            // ahora con el builder turkeyClub
            builder = new TurkeyClub();
            shop.Assemble(builder);
            Console.WriteLine(builder.SingleSandwich.Show()); 


        }
    }
}
