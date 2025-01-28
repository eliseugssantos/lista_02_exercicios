/*4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir
 * que o usuário insira as idades e calcule a média até que o usuário digite 0. 
 * A solução deve ser implementada usando while, do while e for.*/


/*int idade;
double somaIdades = 0;
int amigos = 0;
Console.WriteLine("Digite as idadesa (0 para sair): ");

while (true)
{ 
idade = Convert.ToInt32(Console.ReadLine());
    if (idade <= 0) break;
    somaIdades += idade;
    amigos++;
}
double media = amigos > 0 ? somaIdades / amigos : 0;
Console.WriteLine($"A Media de idade é {media}");*/

/*int idade;
double somaIdades = 0;
int amigos  = 0;

do
{
    Console.WriteLine("Digite as idades (0 para sair): ");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade != 0)
    {
        somaIdades += idade;
        amigos++;

    }


} while (idade != 0);
double mediaIdade = (amigos > 0) ? (somaIdades / amigos) : 0;
Console.WriteLine($"A Madia de idade é {mediaIdade}");*/

int idade;
double somaIdades = 0;
int amigos = 0;

for (;;)
{
    Console.WriteLine("Didite as idades (0 para sair): ");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade <= 0) break;
    somaIdades += idade;
    amigos++;

}
double media = amigos > 0 ? somaIdades / amigos : 0;
Console.WriteLine($"A Media de idade é {media}");

