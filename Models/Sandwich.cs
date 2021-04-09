using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Sandwich
    {
        public string SandwichType { get; private set; }

        private Dictionary<string, string> ingredients = new();
        

        public Sandwich(string sandwichType)
        {
            SandwichType = sandwichType;
        }

        public string this[string key]
        {
            get { return ingredients[key]; }
            set { ingredients[key] = value; }
        }

        public string Show()
        {
            StringBuilder sb = new();

            sb.Append("Sandwich: ");
            sb.Append(SandwichType);
            sb.AppendLine();

            sb.Append("Bread: ");
            sb.Append(ingredients["bread"]);
            sb.AppendLine();

            sb.Append("Meat: ");
            sb.Append(ingredients["meat"]);
            sb.AppendLine();

            sb.Append("Cheese: ");
            sb.Append(ingredients["cheese"]);
            sb.AppendLine();

            sb.Append("Veggies: ");
            sb.Append(ingredients["veggies"]);
            sb.AppendLine();

            sb.Append("Condiments: ");
            sb.Append(ingredients["condiments"]);
            sb.AppendLine();


            return sb.ToString();
        }
    }
}