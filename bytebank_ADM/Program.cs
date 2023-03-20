using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "123.456.789-10";
pedro.Salario = 2000;

Console.WriteLine($"Nome: {pedro.Nome}");
Console.WriteLine($"Bonificação: R${pedro.GetBonificacao()}");

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "987.654.321.01";
roberta.Salario = 5000;

Console.WriteLine($"Nome: {roberta.Nome}");
Console.WriteLine($"Bonificação: R${roberta.GetBonificacao()}");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine($"Total de bonificações: R${gerenciador.TotalDeBonificacao}");