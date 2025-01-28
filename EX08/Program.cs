/*8. Um atendente de suporte técnico deseja contar quantas chamadas atendeu em um dia. 
 * O aluno deverá pedir ao usuário que insira o tempo de duração de cada chamada em minutos até que ele digite 0.
 * O programa deve calcular o total de minutos atendidos, utilizando while, do while e for.
 
 */

int duracaoChamada;
int totalMinutos = 0;

Console.WriteLine("Digite a duração das chamadas em minutos (digite 0 para encerrar): ");
duracaoChamada = Convert.ToInt32(Console.ReadLine());

while (duracaoChamada != 0)
{
    totalMinutos += duracaoChamada;
    Console.WriteLine("Digite a duração da próxima chamada (0 para encerrar): ");
    duracaoChamada = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Total de minutos atendidos: {totalMinutos}");


int duracaoChamada;
int totalMinutos = 0;

do
{
    Console.WriteLine("Digite a duração da chamada em minutos (digite 0 para encerrar): ");
    duracaoChamada = Convert.ToInt32(Console.ReadLine());

    if (duracaoChamada != 0)
        totalMinutos += duracaoChamada;

} while (duracaoChamada != 0);

Console.WriteLine($"Total de minutos atendidos: {totalMinutos}");


int duracaoChamada;
int totalMinutos = 0;

for (; ; )
{
    Console.WriteLine("Digite a duração da chamada em minutos (digite 0 para encerrar): ");
    duracaoChamada = Convert.ToInt32(Console.ReadLine());

    if (duracaoChamada == 0)
        break;

    totalMinutos += duracaoChamada;
}

Console.WriteLine($"Total de minutos atendidos: {totalMinutos}");
