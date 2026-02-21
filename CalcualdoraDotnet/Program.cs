// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using CalcualdoraDotnet.Models;

//Calculadora calc = new Calculadora();
//calc.Somar(10, 5);
//calc.Subitrair(10, 5);
//calc.Multiplicar(10, 5);
//calc.Dividir(10, 5);
//calc.Potencia(10, 5);
//calc.RaizQuadrada(25);
//calc.RaizCubica(27);
//calc.Seno(30);
//calc.Coseno(60);
//calc.Tangente(45);

using CalcualdoraDotnet.Models;

Calculadora calc = new Calculadora();
bool continuar = true;

while (continuar) // cria um loop que continua até o usuário decidir sair,
{
    Console.Clear();
    Console.WriteLine("=== Calculadora ==="); // exibe o menu de opções para o usuário
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Potência");
    Console.WriteLine("6 - Raiz Quadrada");
    Console.WriteLine("7 - Raiz Cúbica");
    Console.WriteLine("8 - Seno");
    Console.WriteLine("9 - Cosseno");
    Console.WriteLine("10 - Tangente");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("----------------");

    Console.Write("Digite a opção desejada: ");
    int opcao = Convert.ToInt32(Console.ReadLine()); // lê a opção escolhida pelo usuário

    if (opcao == 0)// se a opção for 0, encerra o programa
    {
        Console.WriteLine("\nObrigado por usar a calculadora!");
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
        continuar = false;
        continue;
    }

    if (opcao == 6)  // se a opção for 6, solicita um número e calcula a raiz quadrada
    {
        Console.Write("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());
        calc.RaizQuadrada(num);
    }
    else if (opcao == 7) // se a opção for 7, solicita um número e calcula a raiz cúbica
    {
        Console.Write("Digite um número: ");
        double num = Convert.ToDouble(Console.ReadLine());// lê o  número e converte para double
        calc.RaizCubica(num);
    }
    else if (opcao >= 8 && opcao <= 10) // se a opção for 8, 9 ou 10, solicita um ângulo e calcula a função trigonométrica correspondente
    {
        Console.Write("Digite o ângulo em graus: ");
        double angulo = Convert.ToDouble(Console.ReadLine());

        switch (opcao) // usa um switch para chamar o método correto com base na opção escolhida
        {
            case 8: calc.Seno(angulo); break;
            case 9: calc.Coseno(angulo); break;
            case 10: calc.Tangente(angulo); break;
        }
    }
    else if (opcao >= 1 && opcao <= 5) // se a opção for entre 1 e 5, solicita dois números e realiza a operação correspondente
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine()); // lê o primeiro número e converte para double

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine()); // lê o segundo número e converte para double

        switch (opcao)// usa um switch para chamar o método correto com base na opção escolhida
        {
            case 1: calc.Somar(num1, num2); break;
            case 2: calc.Subitrair(num1, num2); break;
            case 3: calc.Multiplicar(num1, num2); break;
            case 4: calc.Dividir(num1, num2); break;
            case 5: calc.Potencia(num1, num2); break;
        }
    }
    else
    {
        Console.WriteLine("Opção inválida!"); // se a opção não for válida, exibe uma mensagem de erro
    }
    Console.Write("\nDeseja realizar outra operação? (S/N): "); // pergunta ao usuário se deseja continuar
    string? resposta = Console.ReadLine(); 
    if (string.IsNullOrEmpty(resposta) || resposta.ToUpper() != "S") // se a resposta  for diferente de "S", ou seja se for "N" encerra o programa
    {
        Console.WriteLine("\nObrigado por usar a calculadora!");
        Console.WriteLine("Pressione qualquer tecla para encerrar..."); // aguarda o usuário pressionar uma tecla antes de encerrar
        Console.ReadKey();
        continuar = false;
    }
}