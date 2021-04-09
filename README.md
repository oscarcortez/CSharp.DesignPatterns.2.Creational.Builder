# CSharp.DesignPatterns.2.Creational.Builder

1. Debe existir una clase ensambladora que ejecute los metodos del builder en un orden especifico: AssemblyLine
```csharp
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
```
2. Necesitamos un builder (abstract) para ser ejecutado por el ensamblador: SandwichBuilder
```csharp
public abstract class SandwichBuilder
{        
    public Sandwich SingleSandwich { get; protected set; }

    public abstract void AddBread();
    public abstract void AddMeats();
    public abstract void AddCheese();
    public abstract void AddVeggies();
    public abstract void AddCondiments();
}
```
3. Coomo es abstract se debe implementar instancias builder donde en una collection se almacene elementos concretos, en este caso son strings
```csharp
public class HamAndCheese : SandwichBuilder
{
    public HamAndCheese() => SingleSandwich = new("Ham and cheese");

    public override void AddBread() => SingleSandwich["bread"] = "White";        

    public override void AddCheese() => SingleSandwich["meat"] = "Ham";        

    public override void AddCondiments() => SingleSandwich["cheese"] = "American";

    public override void AddMeats() => SingleSandwich["veggies"] = "None";

    public override void AddVeggies() => SingleSandwich["condiments"] = "Mayo";        
}
// -- -- -- //
public class TurkeyClub : SandwichBuilder
{
    public TurkeyClub() => SingleSandwich = new Sandwich("Turkey Club");        

    public override void AddBread() => SingleSandwich["bread"] = "12-Grain";        

    public override void AddCheese() => SingleSandwich["meat"] = "Turkey";        

    public override void AddCondiments() => SingleSandwich["cheese"] = "Swiss";        

    public override void AddMeats() => SingleSandwich["veggies"] = "Lettuce, Tomato";        

    public override void AddVeggies() => SingleSandwich["condiments"] = "Mayo";        
}
```
3. Una vez que el builder concreto haya sido ejecutado por el assemble verificamos en este caso desde el builder -> SingleSandwich( property de builder) -> show (metodo de objeto Sandwich
```csharp
Console.WriteLine(builder.SingleSandwich.Show()); 
```
