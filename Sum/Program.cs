
// Observe o trecho de código abaixo:

// int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);

// Ao final do processamento, qual será o valor da variável SOMA?

int i = 12;
int sum = 0;
int k = 1;

while (k < i)
{
    k += 1;
    sum += k;
}

Console.WriteLine(sum);

// RESULTADO: 77