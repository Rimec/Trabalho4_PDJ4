namespace Pizzeria
{
    public abstract class Pizza{
        protected string sauce;
        public string Sauce {get {return sauce;} set{sauce = value;}}
        protected string toppings;
        public string Toppings {get {return toppings;} set{toppings = value;}}
        protected string crust;
        public string Crust {get {return crust;} set{crust = value;}}

        public abstract void Assemble();
        public abstract void QualityCheck();
    }
    public class PepperoniPizza : Pizza
    {
    
        public override void Assemble()
        {
            Console.WriteLine($"Adding Sauce: {sauce}");
            Console.WriteLine($"Adding Toppings: {toppings}");
            Console.WriteLine($"Adding Pepperoni");
            
        }
        public override void QualityCheck(){
            Console.WriteLine($"Crust is: {crust}");
        }
    }
    public class VeggiePizza : Pizza
    {
    
        public override void Assemble()
        {
            Console.WriteLine($"Adding Sauce: {sauce}");
            Console.WriteLine($"Adding Toppings: {toppings}");
            Console.WriteLine($"Adding Veggie Pepperoni");
            
        }
        public override void QualityCheck(){
            Console.WriteLine($"Crust is: {crust}");
        }
    }
    public abstract class Restaurant
    {
        protected Pizza pizza;
        protected Restaurant(Pizza pizza){
            this.pizza = pizza;
        }
        
        public abstract void AddSauce();
        public abstract void AddToppings();
        public abstract void MakeCrust();

        public void Deliver(){
            MakeCrust();
            AddSauce();
            AddToppings();
            pizza.Assemble();
            pizza.QualityCheck();
            Console.WriteLine($"Order in Progress!");
            Console.WriteLine();
        }
    }
    public class ItalianRestaurant : Restaurant {
        public ItalianRestaurant(Pizza pizza) : base(pizza){}

        public override void AddSauce()
        {
            pizza.Sauce = "Oil";
        }
        public override void AddToppings()
        {
            pizza.Toppings = "Nothing";
        }
        public override void MakeCrust()
        {
            pizza.Crust = "Thin";
        }
    }
    public class AmericanRestaurant : Restaurant {
        public AmericanRestaurant(Pizza pizza) : base(pizza){}

        public override void AddSauce()
        {
            pizza.Sauce = "Super Secret Recipe";
        }
        public override void AddToppings()
        {
            pizza.Toppings = "Everything";
        }
        public override void MakeCrust()
        {
            pizza.Crust = "Thick";
        }
    }
}