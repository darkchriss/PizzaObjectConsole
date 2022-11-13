namespace PizzaObjectConsole
{
    internal class Program
    {
        // Nom, prix, Afficher()

        class Pizza
        {
            string nom;
            int prix;

            // Constructeur
            public Pizza(string nom, int prix)
            {
                this.nom = nom;
                this.prix = prix;
            }

            public void Afficher()
            {
                Console.WriteLine("Pizza: " + nom + " - " + prix + "€");
            }
        }
        static void Main(string[] args)
        {
            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(new Pizza("quatre fromages", 11));
            pizzas.Add(new Pizza("norvegienne", 16));
            pizzas.Add(new Pizza("normande", 12));
            pizzas.Add(new Pizza("montagnarde", 15));
            pizzas.Add(new Pizza("végétarienne", 9));

            foreach(Pizza p in pizzas)
            {
                p.Afficher();
            }
        }
    }
}