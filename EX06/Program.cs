/*6. Durante uma eleição, um mesário deve contar os votos. 
 * O aluno deverá pedir ao usuário para inserir os votos (1 para candidato A, 2 para candidato B) até que ele digite 0.
 * O programa deve contar quantos votos cada candidato recebeu, implementando a solução com while, do while e for.
 
Resultado: contar quantos votos cada candidato recebeu
*/

/*int candidatoA = 0, candidatoB = 0;
int votos;

Console.WriteLine("Digite 1 Para votar no candidato A e 2 para votar no candidato B (0 para sair): ");
while (true)
{
    votos = Convert.ToInt32(Console.ReadLine());
    if (votos == 0) break;
   if (votos == 1)candidatoA++;
    else if (votos == 2) candidatoB++;
}
Console.WriteLine($"Toltal de Votos {candidatoA + candidatoB}");
Console.WriteLine($"Toltal de Votos candidato A {candidatoA}");
Console.WriteLine($"Toltal de Votos candidato B {candidatoB}");
*/
/*int candidatoA = 0, candidatoB = 0;
int votos;
do
{
    Console.WriteLine("Digite 1 Para votar no candidato A e 2 para votar no candidato B (0 para sair): ");
    votos = Convert.ToInt32(Console.ReadLine());
    if (votos == 0) break;
    if (votos == 1) candidatoA++; 
    else if (votos == 2) candidatoB++;



} while (votos != 0);
Console.WriteLine($"Toltal de Votos {candidatoA + candidatoB}");
Console.WriteLine($"Toltal de Votos candidato A {candidatoA}");
Console.WriteLine($"Toltal de Votos candidato B {candidatoB}");*/


int candidatoA = 0, candidatoB = 0;
int votos;

for(;;)
{ Console.WriteLine("Digite 1 Para votar no candidato A e 2 para votar no candidato B (0 para sair): ");
    votos = Convert.ToInt32(Console.ReadLine());
    if (votos == 0) break;
    if (votos == 1) candidatoA++;
    else if (votos == 2) candidatoB++;
}
Console.WriteLine($"Toltal de Votos {candidatoA + candidatoB}");
Console.WriteLine($"Toltal de Votos candidato A {candidatoA}");
Console.WriteLine($"Toltal de Votos candidato B {candidatoB}");