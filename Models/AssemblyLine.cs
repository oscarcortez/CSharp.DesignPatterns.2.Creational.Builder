using System;

namespace Models
{
    public class AssemblyLine
    {
        public void Assemble(SandwichBuilder sandwichBuilder)
        {
            // este es el que arma el orden de como iran las ejecuciones
            // entra un objeto abstracto asi que dependiendo de la instancia creada cambia su comportamiento
            // todos estos cambios los tiene el sandwich builder, Assemble no hace mas que ejecutar los metodos
            // en el orden correspondientee
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeats();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddCondiments();
        }
    }
}
