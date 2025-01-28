/*7. Um ciclista deseja saber a distância total que percorreu.
 * Para isso, o aluno deve solicitar que o usuário insira as distâncias percorridas em cada dia até que um valor negativo seja digitado. 
 * A soma das distâncias deve ser calculada e exibida utilizando as três estruturas de repetição.
 
 */

/*double distanciaDiaria;
double distanciaTotal = 0;

Console.WriteLine("Digite a distancia percorrida: ");

while (true)
{ 
distanciaDiaria = Convert.ToDouble(Console.ReadLine());
 if (distanciaDiaria < 0) break;
    distanciaTotal += distanciaDiaria;
}
Console.WriteLine($"Distancia total percorrida: {distanciaTotal}Km");*/

/*double distanciaDiaria;
double distanciaTotal = 0;

do
{
    Console.WriteLine("Digite a distância percorrida (digite um número negativo para sair): ");
    distanciaDiaria = Convert.ToDouble(Console.ReadLine());
    if (distanciaDiaria >= 0)
        distanciaTotal += distanciaDiaria;
} while (distanciaDiaria >= 0);

Console.WriteLine($"Distância total percorrida: {distanciaTotal} Km");*/

double distanciaDiaria;
double distanciaTotal = 0;

for(;;)
{ Console.WriteLine("Digite a distancia percorrida: ");
    distanciaDiaria = Convert.ToDouble(Console.ReadLine());
    if (distanciaDiaria < 0) break;
    distanciaTotal += distanciaDiaria;
}
Console.WriteLine($"Distancia total percorrida: {distanciaTotal} Km");