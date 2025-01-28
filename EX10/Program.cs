/*10.Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia.
 * O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até que ele digite um valor negativo.
 * O total de passagens vendidas deve ser calculado e apresentado utilizando while, do while e for.*/

double valorPassagem;
double totalVendas = 0;

Console.WriteLine("Digite o valor de cada passagem vendida (digite um valor negativo para encerrar): ");
valorPassagem = Convert.ToDouble(Console.ReadLine());

while (valorPassagem >= 0)
{
    totalVendas += valorPassagem;
    Console.WriteLine("Digite o valor da próxima passagem (digite um valor negativo para encerrar): ");
    valorPassagem = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine($"Total arrecadado com passagens: R$ {totalVendas:F2}");

double valorPassagem;
double totalVendas = 0;

do
{
    Console.WriteLine("Digite o valor da passagem vendida (digite um valor negativo para encerrar): ");
    valorPassagem = Convert.ToDouble(Console.ReadLine());

    if (valorPassagem >= 0)
        totalVendas += valorPassagem;

} while (valorPassagem >= 0);

Console.WriteLine($"Total arrecadado com passagens: R$ {totalVendas:F2}");

double valorPassagem;
double totalVendas = 0;

for (; ; )
{
    Console.WriteLine("Digite o valor da passagem vendida (digite um valor negativo para encerrar): ");
    valorPassagem = Convert.ToDouble(Console.ReadLine());

    if (valorPassagem < 0)
        break;

    totalVendas += valorPassagem;
}

Console.WriteLine($"Total arrecadado com passagens: R$ {totalVendas:F2}");
