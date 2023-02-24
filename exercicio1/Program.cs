using TADLivro.ex1;

//Exercício de Modelagem - Parte 1

// Letra A)
Livro livro = new Livro();
exercicio1.CriaLivro(livro);

// Letra B)
Console.WriteLine($"\nTítulo: {exercicio1.RetornaTitulo(livro)}");
Console.WriteLine($"Autor: {exercicio1.RetornaAutor(livro)}");
Console.WriteLine($"Gênero: {exercicio1.RetornaGenero(livro)}");
Console.WriteLine($"Ano de Lançamento: {exercicio1.RetornaAno(livro)}");


// Letra C) 
if (exercicio1.VerificaModernismo(livro))
{
    Console.WriteLine($"\nO livro {livro.Titulo} possui estilo literário de {livro.Genero} do ano de {livro.Ano}");
}

if (exercicio1.VerificaBarroco(livro))
{
    Console.WriteLine($"\nO livro {livro.Titulo} possui estilo literário de {livro.Genero} do ano de {livro.Ano}");
}

//Exercício de Modelagem - Parte 2

// Letra A) & Letra B)
Livro[] vetorLivros = new Livro[5];
vetorLivros[0] = exercicio1.InsereLivro("O Universo numa casca de Noz", "Stephen Hawking", "Física", 2001);
vetorLivros[1] = exercicio1.InsereLivro("Cem Anos de Solidão", "Gabriel Garcia Matos", "Romance", 1967);
vetorLivros[2] = exercicio1.InsereLivro("Ariana, a Mulher", "Vinicius de Morais", "Poesia", 1936);
vetorLivros[3] = exercicio1.InsereLivro("Prosopopeia", "Bento Teixeira", "Poema", 1601);
vetorLivros[4] = exercicio1.InsereLivro("O guia do mochileiro das galáxias", "Douglas Adams", "Ficção", 1981);

Console.Write("\n");
for (int i = 0; i < vetorLivros.Length; i++)
{
    Console.WriteLine($"Livro {i} ->");
    Console.WriteLine($"Título: {vetorLivros[i].Titulo}");
    Console.WriteLine($"Autor: {vetorLivros[i].Autor}");
    Console.WriteLine($"Gênero: {vetorLivros[i].Genero}");
    Console.WriteLine($"Ano de Lançamento: {vetorLivros[i].Ano}");
    Console.Write("\n");
}

// Letra C
exercicio1.OrdenaLivro(vetorLivros);

for (int i = 0; i < vetorLivros.Length; i++)
{
    Console.WriteLine($"{i} - {vetorLivros[i].Ano} - {vetorLivros[i].Titulo} ");
}

// Letra D
Console.WriteLine("\nBusca Livro: ");
string nome = Console.ReadLine().ToLower();
if(exercicio1.BuscaLivro(vetorLivros, nome))
{
    Console.WriteLine($"{nome} existe na nossa biblioteca");
}

Console.WriteLine("\nVerifica gênero: ");
string genero = Console.ReadLine().ToLower();
Console.WriteLine($"{exercicio1.BuscaGenero(vetorLivros, genero)} é número que o genero aparece na nossa biblioteca");
