using static System.Console;

class Demo2
{
    static void Demo2()
    {
        var nomes = new string[] { "José", "Maria", "Ricardo", "Alice", "Pedro" };

        WriteLine($@"A lista de nomes é: 
{string.Join(", \n", nomes)}"
);
        WriteLine();
        WriteLine("Digite o nome a ser substituido: ");

        var nome = ReadLine();

        WriteLine("Qual vai ser o nome novo? ");

        var nomeNovo = ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        WriteLine($@"A lista de nomes alterada é: 
{string.Join(", \n", nomes)}"
);
    }
    static void Demo1()
    {
        int a = 5;

        Adicionar20(ref a);

        WriteLine($"O valor de a é: {a}");
    }
    static void Adicionar20(ref int a)
    {
        a += 20;
    }

    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }
    static void Main()
    {
        var nomes = new string[] { "José", "Maria", "Ricardo", "Alice", "Pedro" };

        WriteLine($@"A lista de nomes é: 
{string.Join(", \n", nomes)}"
);
        WriteLine();
        WriteLine("Digite o nome a ser substituido: ");

        var nome = ReadLine();

        WriteLine("Qual vai ser o nome novo? ");

        var nomeNovo = ReadLine();

       
        AlterarNome(nomes, nome, nomeNovo);

        WriteLine($@"A lista de nomes alterada é: 
{string.Join(", \n", nomes)}"
);
    }
}