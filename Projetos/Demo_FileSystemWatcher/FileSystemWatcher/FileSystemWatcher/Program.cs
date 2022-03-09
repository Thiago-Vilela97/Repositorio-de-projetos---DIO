var path = @"c:\temp\globo";

using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando eventos na pasta {path}");
Console.WriteLine( "Aperte Enter para finalizar...");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo: {e.Name}");
}



void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluido o arquivo: {e.Name}");
}



void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"o arquivo {e.OldName} foi renomeado para {e.Name}");
}