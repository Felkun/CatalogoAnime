using CatalogoAnime;

Console.WriteLine("Test Catalogo Anime");
Catalogo<Anime> catalogo = new Catalogo<Anime>();

Anime anime = new()
{
    Id = 0,
    Titolo = "Kaichou wa Maid-sama!",
    Genere = "Shoujo",
    NumeroEpisodi = 26
};
catalogo.AggiungiAnime(anime);

Shonen shonen = new()
{
    Id = 1,
    Titolo = "Bleach",
    NumeroEpisodi = 392,
    Protagonista = "Ichigo Kurosaki"
};
catalogo.AggiungiAnime(shonen);


Seinen seinen = new()
{
    Id = 2,
    Titolo = "Berserk",
    NumeroEpisodi = 25,
    TargetDiEta = 18
};
catalogo.AggiungiAnime(seinen);

catalogo.MostraAnime();