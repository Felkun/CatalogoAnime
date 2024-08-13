namespace CatalogoAnime
{
    public class Seinen : Anime
    {
        public override string Genere { get => "Seinen"; }
        public int TargetDiEta { get; set; }

        public override void DettagliAnime()
        {
            base.DettagliAnime();
            Console.WriteLine("Consigliato ad una età minima di " + TargetDiEta + " anni");
        }
    }
}
