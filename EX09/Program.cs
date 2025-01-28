/*9. Um cliente deseja saber o total de suas compras em um supermercado.
 * O aluno deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. 
 * A soma dos valores das compras deve ser implementada usando as três estruturas de repetição.
 
 */
double valorCompra;
double totalCompras = 0;

Console.WriteLine("Digite o valor de cada compra (digite 0 para encerrar): ");
valorCompra = Convert.ToDouble(Console.ReadLine());

while (valorCompra != 0)
{
    totalCompras += valorCompra;
    Console.WriteLine("Digite o valor da próxima compra (0 para encerrar): ");
    valorCompra = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine($"Total gasto: R$ {totalCompras:F2}");

double valorCompra;
double totalCompras = 0;

do
{
    Console.WriteLine("Digite o valor da compra (digite 0 para encerrar): ");
    valorCompra = Convert.ToDouble(Console.ReadLine());

    if (valorCompra != 0)
        totalCompras += valorCompra;

} while (valorCompra != 0);

Console.WriteLine($"Total gasto: R$ {totalCompras:F2}");

double valorCompra;
double totalCompras = 0;

for (; ; )
{
    Console.WriteLine("Digite o valor da compra (digite 0 para encerrar): ");
    valorCompra = Convert.ToDouble(Console.ReadLine());

    if (valorCompra == 0)
        break;

    totalCompras += valorCompra;
}

Console.WriteLine($"Total gasto: R$ {totalCompras:F2}");

