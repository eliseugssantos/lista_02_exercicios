/*3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. 
 * O aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao digitar -1, encerrará a entrada.
 * Em seguida, deve contar quantos alunos tiveram nota maior ou igual a 6, utilizando as três estruturas de repetição.*/


/int alunosAprovados = 0;
double notas;

Console.WriteLine("Digite as notas dos alunos (digite -1 para sair): ");
while (true)
{
   notas = Convert.ToDouble(Console.ReadLine());
   if (notas == -1) break;
   if (notas >= 6) alunosAprovados++;
}
Console.WriteLine($"Total de alunos aprovados {alunosAprovados}");

/int alunosAprovados = 0;
double nota;

for (;;)
{
    Console.WriteLine("Digite as notas dos alunos (digite -1 para sair): ");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota == -1) break;
    if (nota >= 6) alunosAprovados++;
}
Console.WriteLine($"Total de alunos aprovados {alunosAprovados}");

int alunosAprovados = 0;
double nota;

do
{
    Console.WriteLine("Digite as notas dos alunos (digite -1 para sair):");
    nota = Convert.ToDouble(Console.ReadLine());
    if (nota >= 6 && nota != -1) alunosAprovados++;
} while (nota != -1);
Console.WriteLine($"Total de alunos aprovados: {alunosAprovados}");