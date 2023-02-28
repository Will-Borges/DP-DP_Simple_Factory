namespace DP_Sem_Factory
{
    public class PizzaMussarela
    {
        public string Nome { get; set; }


        public PizzaMussarela()
        {
            Nome = "Mussarela";
        }


        public void Preparar()
        {
            Console.WriteLine($"Preparando pizza de {Nome}");
        }

        public void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo}min");
        }

        public void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
        }
    }
}
