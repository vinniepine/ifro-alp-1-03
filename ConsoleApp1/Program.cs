/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica de Programação I
 * Professor Clayton Ferraz Andrade
 * 
 * Acadêmico Vinícius de Oliveira Pinheiro
 * Atividade para a aula do dia 28-03-2023
 */

// Atividade exercícios com algoritmos
namespace Atividade
{
    class Program01
    {
        static void Main(string[] args)
        {
            /* 1. Leia quatro (4) valores, calcule a soma entre eles e apresente o resultado. */

            // Variáveis
            double n1 = 0.00, n2 = 0.00, n3 = 0.00, n4 = 0.00, sum = 0.00;

            // Entrada
            Console.Write("Exercício 1" + "\nVamos fazer a soma de quatro valores. ");
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o quarto valor: ");
            n4 = double.Parse(Console.ReadLine());

            // Processamento
            sum = n1 + n2 + n3 + n4;

            // Saída
            Console.WriteLine("O resultado da soma dos quatro números é = " + sum);

            // Encerramento
            Console.ReadLine();

            /* 2. Leia três valores, calcule a média aritmética deles e apresente o resultado.*/

            // Variáveis
            double N1 = 0.00, N2 = 0.00, N3 = 0.00;
            double average = 0.00;

            // Entrada
            Console.WriteLine("\nExercício 2." +
            "\nVamos calcular a média aritmética de três valores.");
            Console.WriteLine("Digite o primeiro valor: ");
            N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            N2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor: ");
            N3 = double.Parse(Console.ReadLine());

            // Processamento
            average = (N1 + N2 + N3) / 3;

            // Saída
            Console.WriteLine("O resultado da média dos três números é = " + average);

            // Encerramento
            Console.ReadLine();

            /* 3. Elabore um algoritmo que, a partir de dados fornecidos pelo usuário, calcule o
            * valor da venda de um produto, exibindo uma saída em vídeo contendo o código do
            * produto, o nome, a quantidade comprada, o valor unitário e o valor total. */

            // Variáveis
            string codigo, nome;
            int quantidade = 0;
            double valorUnitario;

            // Entrada
            Console.Write("\nExercício 3. " + "\nVamos fazer um registro de um produto e calcular " +
                "valor total de sua venda. \nDigite o código do produto: ");
            codigo = (Console.ReadLine());
            Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine();
            Console.Write("Digite a quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário: ");
            valorUnitario = double.Parse(Console.ReadLine());

            // Processamento
            double valorTotal = quantidade * valorUnitario;

            // Saída
            Console.WriteLine("\nCódigo do produto: " + codigo);
            Console.WriteLine("Nome do produto: " + nome);
            Console.WriteLine("Quantidade comprada: " + quantidade);
            Console.WriteLine("Valor unitário: R$ " + valorUnitario.ToString("F2"));
            Console.WriteLine("Valor total: R$ " + valorTotal.ToString("F2"));

            // Encerramento
            Console.ReadLine();

            /* 4. Elabore um algoritmo que, a partir de dados inseridos pelo usuário, calcule o
            * salário reajustado de um funcionário, exibindo, como resultado, seu nome, o valor
            * de seu salário atual, e o valor do salário reajustado. */

            // Variável
            double reajuste = 8.75;
            string name;
            double salarioAtual;
            double salarioReajustado;

            // Entrada
            Console.WriteLine("\nExercício 4. " + "\nVamos valcular o salário de um funcionário " +
                "reajustado em +8,75%. \nDigite o nome do funcionário: ");
            name = Console.ReadLine();
            Console.WriteLine("Digite o salário atual do funcionário: ");
            salarioAtual = double.Parse(Console.ReadLine());
            salarioReajustado = salarioAtual * (1 + reajuste / 100);

            // Saída
            Console.WriteLine("O novo salário de " + name + " é de R$"
            + salarioReajustado.ToString("F2") + ".");

            // Encerramento
            Console.ReadLine();

            /* 5. Faça um algoritmo que, a partir do valor fornecido, calcule e exiba o
            * preço atualde um produto e o preço com desconto de 10%.*/

            // Variável
            double valorAtual = 0, valorDesconto = 0, precoComDesconto = 0;

            // Entrada
            Console.Write("\nExercício 5. " + "\nVamos calcular o preço de um produto com " +
                "um desconto de 10%. \nDigite o valor atual do produto, sem o desconto: ");
            valorAtual = double.Parse(Console.ReadLine());

            // Processamento
            valorDesconto = valorAtual * 0.1f;
            precoComDesconto = valorAtual - valorDesconto;

            // Saída
            Console.WriteLine("Preço atual do produto: R$ " + valorAtual.ToString("F2"));
            Console.WriteLine("Preço com desconto de 10%: R$ " + precoComDesconto.ToString("F2"));

            // Encerramento
            Console.ReadLine();

            /* 6. Verifique se um número fornecido pelo usuário é par ou ímpar. Para isto,
            * apresente uma mensagem mostrando o número digitado e o resultado do teste*/

            // Variável
            int numero;

            // Entrada
            Console.Write("\nExercício 6. " + "\nVamos verificar se um número é ímpar ou par." +
                " \nDigite um número: ");
            numero = int.Parse(Console.ReadLine());

            // Processamento e saída
            if (numero % 2 == 0)
            {
                Console.WriteLine("{0} é um número par", numero);
            }
            else
            {
                Console.WriteLine("{0} é um número ímpar", numero);
            }

            Console.ReadLine();

            /* 7. Melhore o algoritmo do exercício anterior verificando se o número inserido
            * pelousuário é zero, par ou ímpar.*/

            // Variável
            int number;

            // Entrada
            Console.Write("\nExercício 7. " + "\nVamos verificar se um número é ímpar, par ou neutro." +
                "\nDigite um número: ");
            number = int.Parse(Console.ReadLine());

            // Processamento e saída;
            if (number == 0)
            {
                Console.WriteLine("{0} é um número neutro, portanto não é par nem ímpar.", number);
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("{0} é par", number);
            }
            else
            {
                Console.WriteLine("{0} é ímpar", number);
            }

            // Encerramento
            Console.ReadLine();

            /* 8. Fazer um algoritmo que verifique se um número é múltiplo de 3 ou de 7.
            * Apresentaruma mensagem mostrando o número digitado e o resultado do teste. */

            // Variável
            int num = 0;

            // Entrada
            Console.WriteLine("\nExercício 8. " + "\nVamos verificar se um número é múltiplo " +
                "de 3 e/ou de 7. \nDigite um número:");
            num = int.Parse(Console.ReadLine());

            // Processamento e Saída
            if (num % 3 == 0 && num % 7 == 0)
            {
                Console.WriteLine($"{num} é múltiplo de 3 e de 7.");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"{num} é múltiplo de 3.");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine($"{num} é múltiplo de 7.");
            }
            else
            {
                Console.WriteLine($"{num} não é múltiplo de 3 nem de 7.");
            }

            // Encerramento
            Console.ReadLine();
        }
    }
}