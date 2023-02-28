namespace DP_Sem_Factory
{
    public class PizzaCalabreza
    {
        public string Nome { get; set; }


        public PizzaCalabreza()
        {
            Nome = "Calabreza";
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
