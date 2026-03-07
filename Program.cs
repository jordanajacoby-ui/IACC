decimal saldo = 1000.0m;

Console.WriteLine("Bem Vindo ao caixa eletrônico da ADS!!");
int opcao = 0;

do
{
    decimal valor = 0;
    Console.WriteLine("1 - Ver saldo:\n2 - Depositar:\n3 - Sacar:\n4 - Sair:");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Saldo disponível: R${saldo:F2}");
            break;
        case 2:
            Console.WriteLine("Informe o valor do depósito:");
            decimal resp = Convert.ToDecimal(Console.ReadLine());
            saldo += resp;
            Console.WriteLine($"Seu saldo agora é de R${saldo}");
            break;
        case 3:
            Console.WriteLine("Digite o valor que deseja sacar: ");
            valor = decimal.Parse(Console.ReadLine());
            while (saldo - valor < 0)
            {
                Console.WriteLine($"Saldo insuficiente! Você possui R${saldo}, tente novamente!");
                valor = decimal.Parse(Console.ReadLine());
            }
            saldo -= valor;
            Console.WriteLine($"Você sacou: R$ {valor} \n Seu saldo atual é: R$ {saldo}");
            break;
        case 4:
            Console.WriteLine("Muito obrigado por utilizar nossos serviços!");
            break;
        default:
            Console.WriteLine("Você escolheu uma opção inválida, tente novamente.");
            break;
    }
} while (opcao != 4);