using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TurkeyClub : SandwichBuilder
    {
        public TurkeyClub() => SingleSandwich = new Sandwich("Turkey Club");        

        public override void AddBread() => SingleSandwich["bread"] = "12-Grain";        

        public override void AddCheese() => SingleSandwich["meat"] = "Turkey";        

        public override void AddCondiments() => SingleSandwich["cheese"] = "Swiss";        

        public override void AddMeats() => SingleSandwich["veggies"] = "Lettuce, Tomato";        

        public override void AddVeggies() => SingleSandwich["condiments"] = "Mayo";        
    }
}
