using exemploexplorando.Models;
using System.Globalization;
using System.Security.Cryptography;
























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
