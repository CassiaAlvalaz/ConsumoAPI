using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //musicas[1189].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGenerosMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Bon Jovi");

        //LinqFilter.FiltrarMusicasEmCSharp(musicas);

        var musicasPreferidasDaCassia = new MusicasPreferidas("Cassia");
        musicasPreferidasDaCassia.AdicionarMusicasFavoritas(musicas[905]);
        musicasPreferidasDaCassia.AdicionarMusicasFavoritas(musicas[241]);
        musicasPreferidasDaCassia.AdicionarMusicasFavoritas(musicas[963]);
        musicasPreferidasDaCassia.AdicionarMusicasFavoritas(musicas[1189]);
        musicasPreferidasDaCassia.AdicionarMusicasFavoritas(musicas[858]);

        musicasPreferidasDaCassia.ExibirMusicasFavoritas();

        musicasPreferidasDaCassia.GerarArquivoJson();
        //musicasPreferidasDaCassia.GerarDocumentoTXTComAsMusicasFavoritas();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

