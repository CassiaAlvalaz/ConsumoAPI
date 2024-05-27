﻿
using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        Console.WriteLine("Lista de Gêneros:");
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGenerosMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artista por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
