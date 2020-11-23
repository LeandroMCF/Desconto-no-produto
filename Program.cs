using System;

namespace Desconto_no_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            string material, materialUp;

            int  quanticaneta, quantilapis, quantifolhas, rep;

            double caneta, precocaneta, nprecocaneta, precofinalC, lapis, precolapis, nprecolapis, precofinalL, folhas, precofolhas, nprecofolhas, precofinalF, valorgeral;

            valorgeral = 0;
            caneta = 1.50;
            lapis = 0.50;
            folhas = 0.50;
            rep = 1;
            Console.WriteLine("Compra de materiais\n----------------------");
            do
            {
                Console.WriteLine("[C] Canetas\n[L] Lapis\n[F] Folhas");
                material = Console.ReadLine();
                materialUp = material.ToUpper();
                Console.WriteLine(materialUp);
                while (materialUp != "C" && materialUp != "L" && materialUp != "F")
                {
                    Console.WriteLine("Opção invalida, digite a opção novamente.\n[C] Canetas\n[L] Lapis\n[F] Folhas");
                    material = Console.ReadLine();
                    materialUp = material.ToUpper();
                }
                //lapis
                if (materialUp == "L")
                {
                    Console.WriteLine("Quantos lapis você deseja compar?");
                    quantilapis = int.Parse(Console.ReadLine());
                    precolapis = quantilapis * lapis;
                    if (quantilapis <= 5)
                    {
                        Console.WriteLine("Você ganhou 2% de desconto!");
                        nprecolapis = (2 / 100) * precolapis;
                        precofinalL = precolapis - nprecolapis;
                    }
                    else if (quantilapis > 5 && quantilapis <+ 10)
                    {
                        Console.WriteLine("Você ganhou 3% de desconto!");
                        nprecolapis = (3 / 100) * precolapis;
                        precofinalL = precolapis - nprecolapis;
                    }
                    else
                    {
                        Console.WriteLine("Você ganhou 5% de desconto!");
                        nprecolapis = (5 / 100) * precolapis;
                        precofinalL = precolapis - nprecolapis;
                    }
                    valorgeral = valorgeral + precofinalL;
                    Console.WriteLine($"valor final R$ {precofinalL}");
                }

                //caneta
                if (materialUp == "C")
                {
                    Console.WriteLine("Quantas canetas você deseja compar?");
                    quanticaneta = int.Parse(Console.ReadLine());
                    precocaneta = quanticaneta * caneta;
                    if (quanticaneta <= 5)
                    {
                        Console.WriteLine("Você ganhou 2% de desconto!");
                        nprecocaneta = (2 / 100) * precocaneta;
                        precofinalC = precocaneta - nprecocaneta;
                    }
                    else if (quanticaneta > 5 && quanticaneta <+ 10)
                    {
                        Console.WriteLine("Você ganhou 3% de desconto!");
                        nprecocaneta = (3 / 100) * precocaneta;
                        precofinalC = precocaneta - nprecocaneta;
                    }
                    else
                    {
                        Console.WriteLine("Você ganhou 5% de desconto!");
                        nprecocaneta = (5 / 100) * precocaneta;
                        precofinalC = precocaneta - nprecocaneta;
                    }
                    valorgeral = valorgeral + precofinalC;
                    Console.WriteLine($"valor final R$ {precofinalC}");
                }

                //folhas
                if (materialUp == "F")
                {
                    Console.WriteLine("Quantas folhas você deseja compar?");
                    quantifolhas = int.Parse(Console.ReadLine());
                    precofolhas = quantifolhas * folhas;
                    if (quantifolhas <= 5)
                    {
                        Console.WriteLine("Você ganhou 2% de desconto!");
                        nprecofolhas = (2 / 100) * precofolhas;
                        precofinalF = precofolhas - nprecofolhas;
                    }
                    else if (quantifolhas > 5 && quantifolhas <+ 10)
                    {
                        Console.WriteLine("Você ganhou 3% de desconto!");
                        nprecofolhas = (3 / 100) * precofolhas;
                        precofinalF = precofolhas - nprecofolhas;
                    }
                    else
                    {
                        Console.WriteLine("Você ganhou 5% de desconto!");
                        nprecofolhas = (5 / 100) * precofolhas;
                        precofinalF = precofolhas - nprecofolhas;
                    }
                    valorgeral = valorgeral + precofinalF;
                    Console.WriteLine($"valor final R$ {precofinalF}");
                }
                Console.WriteLine($"Deseja compar mais alguma coisa?\n[1] Sim\n[2] Não");
                rep = int.Parse(Console.ReadLine());
            } while (rep == 1);
            Console.WriteLine($"O valor da sua compra é de: {valorgeral}");
        }
    }
}
