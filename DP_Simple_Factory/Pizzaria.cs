namespace DP_Simple_Factory
{
    public class Pizzaria
    {
        public static void SolicitarPizza()
        {
            Console.WriteLine("======= Pizzaria =======");
            Console.WriteLine("Informe a pizza (C)alabreza ou (M)ussarela \n");
            string tipo = Console.ReadLine().ToUpper();

            try
            {
                Pizza pizza = PizzaSimpleFactory.CriarPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
                Console.WriteLine("Pizza concluida");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
