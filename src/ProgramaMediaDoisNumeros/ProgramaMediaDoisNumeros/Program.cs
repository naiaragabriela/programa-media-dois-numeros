float n1, n2;

float PrimeiroNumero()
{
    Console.Write("Digite o primeiro número da média: ");
    return float.Parse(Console.ReadLine());
}
float SegundoNumero()
{
    Console.Write("Digite o segundo número da média: ");
    return float.Parse(Console.ReadLine());
}



void MediaNumeros()
{
    Console.WriteLine("A média dos números digitados é: " + ((PrimeiroNumero() + SegundoNumero())/2).ToString("F2"));
    Console.ReadKey();
}

MediaNumeros();
