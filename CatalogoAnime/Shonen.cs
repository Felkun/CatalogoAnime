namespace CatalogoAnime
{
    public class Shonen : Anime
    {
        public override string Genere { get => "Shonen"; }
        public string Protagonista { get; set; } = string.Empty;

        public override void DettagliAnime()
        {
            base.DettagliAnime();
            Console.WriteLine("Protagonista: " + Protagonista);
        }
    }
}
