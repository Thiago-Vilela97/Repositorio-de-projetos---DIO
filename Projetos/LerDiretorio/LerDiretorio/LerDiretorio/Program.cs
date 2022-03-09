var path = @"C:\Users\thiadolfov\Desktop\DIO\Repositorio - de - projetos-- - DIO\Projetos\Directory_And_DirectoryInfo\Directory_And_DirectoryInfo\Directory_And_DirectoryInfo\bin\Debug\net6 .0\globo";

LerDiretorio(path);
Console.WriteLine("Digite Enter para finalizar...");
Console.ReadLine();

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[NOME]: {fileInfo.Name}");
        Console.WriteLine($"[TAMANHO]: {fileInfo.Length}");
        Console.WriteLine($"[ULTIMO ACESSO]: {fileInfo.LastAccessTime}");
        Console.WriteLine($"[PASTA]: {fileInfo.DirectoryName}");
        Console.WriteLine($"-------------------");
    }
}

static void LerDiretorio(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[nome]: {dirInfo.Name}");
            Console.WriteLine($"[Raiz]: {dirInfo.Root}");
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

            Console.WriteLine("------------------------------");
        }
    }
    else
    {
        Console.WriteLine($"Diretorio não existe{path}");
    }
}

