﻿using static System.Console;

WriteLine("Digite o nome do arquivo: ");
var nome = ReadLine();

nome = LimparNome(nome);


var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

Console.WriteLine("Digite enter para finalizar");
ReadLine();

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 2 do arquivo");
    }
    catch
    {
        WriteLine("O nome do arquivo está invalido!");
    }

}

