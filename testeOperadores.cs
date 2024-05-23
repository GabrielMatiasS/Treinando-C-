











//Operador Logico NOT
// bool choveu = true;
// bool estaTarde =  true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }else{
//     Console.WriteLine("Vou pedalar outro dia");
// }










//Operador Logico AND 
// bool possuiPresencaMinima = true;
// double media = 8;

// if (possuiPresencaMinima && media >= 7){
//     Console.WriteLine("Aprovado");
// }else{
//     Console.WriteLine("Reprovado");
// }











//Operador logico OR
// bool ehMaiorDeIdade = true;
// bool possuiAutorizacao = false;


// if (ehMaiorDeIdade || possuiAutorizacao){
//     Console.WriteLine("Entrada autorizada!");
// }else{
//     Console.WriteLine("Entrada Proibida.");
// }


















//Operadores condicionais
// Console.WriteLine("digite uma letra:");
// string letra = Console.ReadLine();



// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Vogal");
//     break;
//     default:
//     Console.WriteLine("Não é uma vogal");
//     break ;
// }










// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e"){
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i"){
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o"){
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u"){
//     Console.WriteLine("Vogal")
// }







// int quanidadeEmEstoque = 3;
// int quantidadeDeCompra = 0;
// bool possivelvenda = quantidadeDeCompra > 0 && quanidadeEmEstoque >= quantidadeDeCompra;

// Console.WriteLine($"Quantidade em estoque {quanidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeDeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelvenda}");

// if(quantidadeDeCompra == 0 ){
//     Console.WriteLine("Venda invalida.");
// }

// else if(possivelvenda)
// {
// Console.WriteLine("Venda realizada");
// }
// else
// {
//     Console.WriteLine("Desculpe , não temos essa quantidade em estoque.");
// }






// string a = "15-";
// int b = 0;


// int.TryParse(a, out b);


// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso.");






// C# segue os mesmos padrões matematicos ex: multiplicação ou divisão , soma ou subtração.
// double a = 4 / 2 + 2;

// Console.WriteLine(a);


//Cast implicito - Faz conversão de tipo de variavéis automaticamente.
//OBS: conversões não podem ser inversas por long estrapola o valor do int.
// int a = int.MaxValue;
// long b = a; 

// Console.WriteLine(b);





// int inteiro = 5;
// string a = inteiro.ToString();


// Console.WriteLine(a);





// // Cast - Casting (conversão de int para string pode ser necessario para uso de API por exemplo.)
// int a = Convert.ToInt32(null);
// Console.WriteLine(a);
// // int a = int.Parse("5c");



// int a = 23;
// int b = 14;


// int c = a + b;


// c -= 5;

// // c = 5 + c;

// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now;

// Console.WriteLine(dataAtual);





// string apresentação = "Olá , seja bem vindo!";

// int quantidade = 1;

// double altura = 1.80;

// decimal preço= 1.80M;

// bool condicao = false;


// Console.WriteLine(apresentação);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável preço: " + preço);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável condição: " + condicao);








//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Matias";
//pessoa1.Idade = 22;
//pessoa1.Apresentar();