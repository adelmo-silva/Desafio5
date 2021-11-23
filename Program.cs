{
    Console.WriteLine("O objetivo do jogo é adivinhar o número informado pelo primeiro jogador!");
    Console.Write("Jogador (1), informe um valor de 0 a 9: ");
    double valor1 = double.Parse(Console.ReadLine());
    Console.Clear();

    while(valor1 < 0 || valor1 > 9)
    {
        Console.WriteLine("Error!");
        Console.Write("Informe um valor entre 0 e 9 por favor!:");
        valor1 = double.Parse(Console.ReadLine());
        Console.Clear();
    }
        
    Console.Clear();
    Console.Write("Jogador (2), informe um valor de 0 a 9: ");
    double valor2 = double.Parse(Console.ReadLine());
    Console.Clear();
    int quanttent = 1;

    while(valor2 < 0 || valor2 > 9)
    {
        Console.WriteLine("Error!");
        Console.Write("Informe um valor de 0 a 9 por favor!:");
        valor2 = double.Parse(Console.ReadLine());
        Console.Clear();
    }

    while(valor2 != valor1)
    {
        Console.WriteLine("Tentativas: " + quanttent);
        Console.WriteLine("O valor está incorreto!");
        Console.Write("Jogador (2), informe um valor novamente:");
        valor2 = double.Parse(Console.ReadLine());
        quanttent = quanttent + 1;
        Console.Clear();
    }
    
    Console.Clear();
    Console.WriteLine("Tentativas: " + quanttent);
    Console.Write("O valor informado está correto, Parabéns!");
}