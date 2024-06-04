using exemploexplorando.Models;
using System.Globalization;
using System.Security.Cryptography;
using CSharpStudies.Models;
using Newtonsoft.Json;
using csharpstudies;
using csharpstudies.Models;
using cSharpstudies.Models;
using cSharpstudies.Interfaces;

ICalculadora calc = new Calculadora();

Console.WriteLine(calc.Multiplicar(3,9));






// Computador c = new();

// Console.WriteLine(c.ToString());

// Corrent c = new();
// c.Creditar(500);

// c.ExibirSaldo();

// int a = 10;

// int b = a;

// b = 60;

// Console.WriteLine($"Valor de A : {a}");
// Console.WriteLine($"Valor de A : {b}");

// int numero = 15;

// bool par = false;

// par = numero.EhPar();

// string mensagem = " O numero " + numero +  " " + " é " + (par ? "par": "impar");


// Console.WriteLine(numero);

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("teste");

// Console.WriteLine(arrayString[0]);

// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("email");
// }
// else
// {
//     Console.WriteLine("sem email");
// };

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new{x.Produto, x.Preco});

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preco: {venda.Preco}");
// }


// var tipoAnonimo = new {Nome = "Leonardo", Sobrenome = "Buta", Altura = 1.80};

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);

// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);

// Console.WriteLine("Altura: " + tipoAnonimo.Altura);



// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, " +
//     $"{(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}" : "")}");
// }



// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}");
//     Console.WriteLine($"Id: {venda.DataVenda}");
//     Console.WriteLine($"Id: {venda.Produto}");
// }

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = [];

// Venda v1 = new(1, "Material de escritorio", 25.00M, dataAtual);
// Venda v2 = new(2, "Licença de software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);

// try
// {
//     string [] linhas = File.ReadAllLines("Arquivos/d/arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretorio não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }

// finally
// {
//     Console.WriteLine("cHEGOU ATÉ AQUI");
// }


// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                        "yyy-MM-dd HH:mm",
//                        CultureInfo.InvariantCulture,
//                        DateTimeStyles.None,
//                        out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! data : {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal ValorMonetario = 1582.40M;

// Console.WriteLine(ValorMonetario.ToString("C8"));

// double porcentagem = .4321;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));



// int numero1 = 10;
// int numero2 = 20;

// int Resultado = numero1 + numero2;

// Console.WriteLine(Resultado);


// Pessoa p1 = new(nome: "Leonardo", sobrenome: "Buta");

// Pessoa p2 = new(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new()
// {
//     Nome = "Ingles",
//     Alunos = []
// };

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAlunos();
