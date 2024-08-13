namespace CatalogoAnime
{
    public class Catalogo<T> where T : Anime
    {
        public List<T> Anime { get; set; } = new List<T>();

        public void AggiungiAnime(T anime)
        {
            Anime.Add(anime);
        }

        public void MostraAnime()
        {
            foreach (T anime in Anime)
            {
                anime.DettagliAnime();
            }
        }
    }
}
