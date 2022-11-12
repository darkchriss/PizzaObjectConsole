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
            Pizza maPizza = new Pizza("quatre fromages", 11);
            maPizza.Afficher();
        }
    }
}