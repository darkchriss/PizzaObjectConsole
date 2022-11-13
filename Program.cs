namespace PizzaObjetConsole
{
    class MainClass
    {
        // Nom, prix, Afficher()

        class Pizza
        {

            private static Pizza dernierePizzaCree;
            private static Pizza pizzaLaMoinsChere;
            private static Pizza pizzaLaPlusChere;

            private string nom;
            private int prix;

            // Constructeur
            public Pizza(string nom, int prix)
            {
                this.nom = nom;
                this.prix = prix;

                dernierePizzaCree = this;

                if (pizzaLaMoinsChere == null)
                {
                    pizzaLaMoinsChere = this;
                }
                else
                {
                    if (prix < pizzaLaMoinsChere.Prix)
                    {
                        pizzaLaMoinsChere = this;
                    }
                }

                if (pizzaLaPlusChere == null)
                {
                    pizzaLaPlusChere = this;
                }
                else
                {
                    if (prix > pizzaLaPlusChere.Prix)
                    {
                        pizzaLaPlusChere = this;
                    }
                }
            }

            public void Afficher()
            {
                Console.WriteLine("Pizza: " + nom + " - " + prix + "€");
            }

            public int Prix
            {
                get { return prix; }
            }

            public static void AfficherDernierePizza()
            {
                if (dernierePizzaCree == null)
                {
                    Console.WriteLine("ERREUR: Vous n'avez pas crée de pizza");
                }
                else
                {
                    Console.WriteLine("** DERNIERE PIZZA CREE**");
                    dernierePizzaCree.Afficher();
                }
            }

            public static void AfficherPizzaMoisChereEtPlusChere()
            {
                if (pizzaLaMoinsChere != null)
                {
                    Console.WriteLine("** PIZZA LA MOINS CHERE **");
                    pizzaLaMoinsChere.Afficher();
                }
                if (pizzaLaPlusChere != null)
                {
                    Console.WriteLine("** PIZZA LA PLUS CHERE **");
                    pizzaLaPlusChere.Afficher();
                }
            }

        }


        public static void Main(string[] args)
        {


            List<Pizza> pizzas = new List<Pizza>();
            pizzas.Add(new Pizza("quatre fromages", 11));
            pizzas.Add(new Pizza("norvegienne", 16));
            pizzas.Add(new Pizza("normande", 12));
            pizzas.Add(new Pizza("montagnarde", 15));
            pizzas.Add(new Pizza("végétarienne", 9));

            pizzas.Sort((Pizza x, Pizza y) =>
            {
                return x.Prix.CompareTo(y.Prix);
            });

            foreach (Pizza p in pizzas)
            {
                p.Afficher();
            }

            Pizza.AfficherDernierePizza();

            Pizza.AfficherPizzaMoisChereEtPlusChere();
        }
    }
}
