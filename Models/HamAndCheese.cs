using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HamAndCheese : SandwichBuilder
    {
        public HamAndCheese()
        {
            SingleSandwich = new("Ham and cheese");
        }

        public override void AddBread()
        {
            SingleSandwich["bread"] = "White";
        }

        public override void AddCheese()
        {
            SingleSandwich["meat"] = "Ham";
        }

        public override void AddCondiments()
        {
            SingleSandwich["cheese"] = "American";
        }

        public override void AddMeats()
        {
            SingleSandwich["veggies"] = "None";
        }

        public override void AddVeggies()
        {
            SingleSandwich["condiments"] = "Mayo";
        }
    }
}
