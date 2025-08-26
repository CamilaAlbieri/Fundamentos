using Fundamentos.Models;


//Menu Interativo

string opcao;
 bool exibirMenu = true;
 
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();



    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.WriteLine("Busca de Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrando o sistema");
            //Environment.Exit(0); //Encerra totalmente a aplicação
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida, digite novamente.");
            break;
    }
}

Console.WriteLine("O programa se encerrou.");


//Estruturas de repetição

// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine($"Digite um número (0 para sair): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;



// } while (numero != 0);

// Console.WriteLine($"Soma dos números digitados é: {soma}");


// int numero = 5;
// int contador = 0;
// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}º Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break; //interrompe o loop
//     }

// }

// for (int i=0; i<=10; i++) //(inicialização; condição; incremento)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }







//------------------------------------------------
//Operadores Aritméticos

//Calculadora calc = new Calculadora();

// calc.Somar(10,20);
// calc.Subtrair(13, 20);
// calc.Multiplicar(4, 15);
// calc.Dividir(100, 20);
// calc.Potencia(3, 4);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(9);

// int numeroIncremento = 10;

// Console.WriteLine($"Incrementando o valor de {numeroIncremento} em 1: {++numeroIncremento}");


// int numeroDecremento = 10;
// Console.WriteLine($"Decrementando o valor de {numeroDecremento} em 1: {--numeroDecremento}");


//------------------------------------------------
//Switch Case

// Console.WriteLine("Digite uma letra: ");

// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("A letra digitada é uma vogal.");
//         break;
    
//     default:
//         Console.WriteLine("A letra digitada é uma consoante.");
//         break;

// }


//------------------------------------------------
//Operadores Condicionais

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// Console.WriteLine($"Quantidade em estoque:  {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade da compra:  {quantidadeCompra} ");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda Inválida, quantidade de compra é zero.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Compra realizada com sucesso!");
// }
// else
// {
//     Console.WriteLine("Desculpe, não temos estoque suficiente.");
// }

//------------------------------------------------

//Cast implícito

//não precisa de conversão explícita, pois ele faz automaticamente
// int a = 5;
// double b = a; // int para double

// Console.WriteLine(b); 
//------------------------------------------------

//Conversão para string

// int inteiro = 10;
// string a = inteiro.ToString(); // Converte o inteiro para string
// Console.WriteLine(a);

//------------------------------------------------

//Convertendo tipos
//int a = Convert.ToInt32("10"); //Preferivel usar a classe Convert pois aceita vários tipos de dados inclusive null
// int a = int.Parse("10c");

// Console.WriteLine(a);

//------------------------------------------------

//Operadores de Atribuição;

// int a = 10;
// int b = 20;

// int c = a + b; // Soma

//------------------------------------------------
//c = c + 5;
//c += 5; // c = c + 5

//c -= 5; // c = c - 5
//c *= 5; // c = c * 5
//c /= 5; // c = c / 5

//Console.WriteLine(c);

//------------------------------------------------

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm")); //ToString coloca o formato da data 

//-----------------------------------------------
// Pessoa p = new Pessoa();

// p.Nome = "Camila";
// p.Idade = 24;
// p.Apresentar();
