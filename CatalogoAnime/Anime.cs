namespace CatalogoAnime
{
    public class Anime
    {
        public int Id { get; set; }
        public string Titolo { get; set; } = string.Empty;
        public virtual string Genere { get; set; } = string.Empty;
        public int NumeroEpisodi { get; set; }

        public virtual void DettagliAnime()
        {
            Console.WriteLine();
            Console.WriteLine(Titolo);
            Console.WriteLine("Genere: " + Genere);
            Console.WriteLine("Composto da " + NumeroEpisodi + " episodi");
        }
    }
}
