
// Escreva um programa que verifique, em uma string, a existência da letra ‘a’,
// seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.

Console.WriteLine("Type something below: ");
string input = Console.ReadLine()!;

int count = 0;
foreach (char c in input)
{
    if (c == 'a' || c == 'A')
    {
        count++;
    }
}

Console.WriteLine($"Input string contains {count} A's");