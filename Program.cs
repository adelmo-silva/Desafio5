{
    Console.Write("Jogador (1), informe um valor: ");
    double valor1 = double.Parse(Console.ReadLine());
    Console.Write("Jogador (2), informe um valor: ");
    double valor2 = double.Parse(Console.ReadLine());
    int quanttent = 1;

    if(valor1 != valor2)
    {
        while(valor1 != valor2)
        {
            Console.WriteLine("Tentativas: " + quanttent);
            Console.WriteLine("O valor está incorreto!");
            Console.Write("Jogador (2), informe um valor novamente:");
            valor2 = double.Parse(Console.ReadLine());
            quanttent = quanttent + 1;
        }
    }
    
    Console.WriteLine("Tentativas: " + quanttent);
    Console.Write("O valor informado está correto, Parabéns!");
}