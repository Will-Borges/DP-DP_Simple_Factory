namespace DP_Simple_Factory
{
    public sealed class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(string tipo)
        {
            Pizza pizza;

            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabreza();
                    break;

                case "M":
                    pizza = new PizzaMussarela();
                    break;

                default:
                    throw new ApplicationException($"A pizza de '{tipo}' não existe");
            }

            return pizza;
        }
    }
}
