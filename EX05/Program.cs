/*5. Um gerente de loja quer saber quantos produtos estão em estoque. 
 * O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0.
 * Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando as três estruturas de repetição.*/

/*Resultado esperado. saber quantos produtos tem em estoque
 * açoes  a ser feita solicitar a quantidade de produtos recebidos e vendidos.
 * produtos recibitos -= produtos vendido == produtos em estoque.*/

using System.Numerics;

/*int PR, PV;
int PET = 0;

Console.WriteLine("Digite a quantidade de produtos recebidos vendidos (0 para sair)");
while (true)
{
    Console.Write("Recebidos: ");
 PR = Convert.ToInt32(Console.ReadLine());
 if (PR <= 0) break;
    Console.Write("Vendidos: ");
PV = Convert.ToInt32(Console.ReadLine());
PET += PR - PV;

}
Console.WriteLine($"Total de Produtos em estoque: {PET}");*/

/*int PR, PV;
int PET = 0;

do
{
    Console.WriteLine("Digite a quantidade de produtos recebidos vendidos (0 para sair)");
    Console.Write("Recebidos: ");
    PR = Convert.ToInt32(Console.ReadLine());
    if (PR <= 0) break;
    Console.Write("Vendidos: ");
    PV = Convert.ToInt32(Console.ReadLine());
    PET += PR - PV;
}
while (PR != 0);
Console.WriteLine($"Total de Produtos em estoque: {PET}");*/

int PR, PV;
int PET = 0;

for (; ; )
{
    Console.WriteLine("Digite a quantidade de produtos recebidos vendidos (0 para sair)");
   
    Console.Write("Recebidos: ");
    PR = Convert.ToInt32(Console.ReadLine());
    if (PR <= 0) break;
    Console.Write("Vendidos: ");
    PV = Convert.ToInt32(Console.ReadLine());
    PET += PR - PV;
}
Console.WriteLine($"Total de Produtos em estoque: {PET}");

