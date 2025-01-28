/*
 2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar ao usuário 
que insira suas despesas até que ele digite um valor negativo, sinalizando o fim da entrada.
O aluno deve somar as despesas e apresentar o total, utilizando while, do while e for.
 
 */

/double dispesasmensais = 0;
double dispesas;

Console.WriteLine("Digite sua dispesas mensais");
while (true)
{
    dispesas = Convert.ToDouble(Console.ReadLine());
    if (dispesas <= 0) break;
    dispesasmensais += dispesas;
}
Console.WriteLine($"Total dispesasmensais{dispesasmensais}");*/


double despesas = 0;
double despesa;
do
{
    Console.WriteLine("Digite suas despesas (valor negativo para sair):");
    despesa = Convert.ToDouble(Console.ReadLine());
    if (despesa >= 0) despesas += despesa;
    if (despesa <= 0) break;
} while (despesa >= 0);
Console.WriteLine($"Total de despesas: {despesas}");*/


double despesas = 0;
double despesa;

for (; ; )
{ 
    Console.WriteLine("Digite suas despesas (valor negativo para sair):");
    despesa = Convert.ToDouble(Console.ReadLine());
    if (despesa <= 0) break;
    despesas += despesa;

}
Console.WriteLine($"Total de despesas: {despesas}");
