namespace DP_Sem_Factory
{
    public class Pizzaria
    {
        public static void SolicitarPizza()
        {
            PizzaCalabreza pizza1;
            PizzaMussarela pizza2;

            Console.WriteLine("======= Pizzaria =======");
            Console.WriteLine("Informe a pizza (C)alabreza ou (M)ussarela \n");
            var pizzaEscolhida = Console.ReadLine().ToUpper();


            if (pizzaEscolhida.Equals("C"))
            {
                pizza1 = new PizzaCalabreza();
                pizza1.Preparar();
                pizza1.Assar(10);
                pizza1.Embalar();
                Console.WriteLine("pizza concluida");
            }
            else if (pizzaEscolhida.Equals("M"))
            {
                pizza2 = new PizzaMussarela();
                pizza2.Preparar();
                pizza2.Assar(10);
                pizza2.Embalar();
                Console.WriteLine("pizza concluida");
            }
            else
            {
                Console.WriteLine("Caractere para selecionar a pizza incorreto");
            }
        }
    }
}
