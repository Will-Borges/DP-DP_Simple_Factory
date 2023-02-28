namespace DP_Simple_Factory
{
    public class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza()
        {
            Nome = "Calabreza";
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo}min");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando pizza de {Nome}");
        }
    }
}
