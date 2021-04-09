namespace Models
{
    public abstract class SandwichBuilder
    {        
        public Sandwich SingleSandwich { get; protected set; }

        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }
}