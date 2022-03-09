CriarDiretorioGlobo();
CriarArquivo();
var origem = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "America do Sul", "Argentina","Brasil.txt");

//MoverAqruivo(origem, destino);
CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }

    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo ja existe na pasta de destino");
        return;
    }
    File.Copy(pathOrigem, pathDestino);
}

static void MoverAqruivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }

    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo ja existe na pasta de destino");
        return;
    }
    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213M de habitantes");
        sw.WriteLine("IDH: 0,99");
        sw.WriteLine("Dados atualizados");
    }

}

static void CriarDiretorioGlobo()
{

    var path = Path.Combine(Environment.CurrentDirectory, "globo");
   if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);

        var dirAmNorte = dirGlobo.CreateSubdirectory("America do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("America Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("America do Sul");

        dirAmNorte.CreateSubdirectory("Usa");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }

}



