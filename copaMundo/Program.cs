using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace copaMundo;

class Program
{
    static void Main(string[] args)
    {
        string sexo;
        int assisteJogos;
        int idade = 0;

        int quantHomem20 = 0;
        int quantMulherLoveCopa = 0;
        int quantMulher = 0;
        double percentMulherSim = 0;
        int entrevistadoAsvezes35 = 0;
        double mediaIdade = 0;
        int somaMediaIdade35 = 0;

        do
        {
            Console.WriteLine("Qual a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade == 0)
            {
                break;
            }
            Console.WriteLine("Qual o seu sexo? (M ou F)");
            sexo = Console.ReadLine();
            Console.WriteLine("Você gosta de assistir os jogos da copa do mundo? (1 - Sim, 2 - Não ou 3 - Às vezes");
            assisteJogos = Convert.ToInt32(Console.ReadLine());


            // Letra A
            if (assisteJogos == 1 && idade < 20 && sexo == "M")
            {
                quantHomem20 += 1;
            }

            // Letra B
            if (sexo == "F")
            {
                quantMulher += 1;
            }

            if (sexo == "F" && assisteJogos == 1)
            {
                quantMulherLoveCopa += 1;
            }

            //Letra C
            if (assisteJogos == 3 && idade > 35)
            {
                entrevistadoAsvezes35 += 1;
                somaMediaIdade35 += idade;
            }

        } while (idade != 0);

        //Letra B
        if (quantMulher == 0 && quantMulherLoveCopa == 0)
        {
            Console.WriteLine("Nenhuma entrevistado é do sexo feminino :/");

        } else if (quantMulherLoveCopa == 0)
        {
            Console.WriteLine("Nenhuma entrevistada do sexo feminino assiste os jogos da copa :/");

        }
        if (quantMulher != 0 && quantMulherLoveCopa != 0)
        {
            percentMulherSim = quantMulherLoveCopa * 100 / quantMulher;

        }

        //Letra C
        if (entrevistadoAsvezes35 == 0)
        {
            Console.WriteLine("Nenhum entrevistado possui mais de 35 anos :/");
        } else {
            mediaIdade = somaMediaIdade35 / entrevistadoAsvezes35;

        }

        //Exibição
        Console.WriteLine("Quantidade de homens que não gosta de assistir jogos da copa e que tem menos de 20 anos: " + quantHomem20);
        Console.WriteLine("Percentual de mulheres que gostam de assistir os jogos da copa e que responderam sim: " + percentMulherSim);
        Console.WriteLine("Média de idade dos entrevistados que responderam que ás vezes assistem os jogos da copa e possuem mais de 35 anos: " + mediaIdade);
        Console.ReadKey();





    }
}