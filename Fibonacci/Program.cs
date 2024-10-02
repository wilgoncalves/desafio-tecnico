
// Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
// (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa em que, informado um número, ele calcule a sequência
// de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);

int previousNum = 0;
int currentNum = 1;


for (int i = 0; i < number; i++)
{
    int fibonacci = previousNum + currentNum;
    previousNum = currentNum;
    currentNum = fibonacci;

    if (fibonacci == number)
    {
        Console.WriteLine($"{number} belongs to Fibonacci");
        break;
    }
    else if (fibonacci > number)
    {
        Console.WriteLine($"{number} does not belong to Fibonacci");
        break;
    }
}

