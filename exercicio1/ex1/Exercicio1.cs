using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TADLivro.ex1
{
    // Cria um classe estática
    public static class exercicio1
    {
        // a) Criar Livro que recebe por parâmetro o título, autor, gênero e ano de publicação e retorna um objeto do tipo Livro.
        public static Livro CriaLivro(Livro livro)
        {
            // Cria o objeto e pede os valores para suas propriedades.
            Console.WriteLine("Digite as informações do livro:");

            // Valores que serão alocados para casa propriedade da classe livros
            Console.Write("Nome do livro: ");
            livro.Titulo = Console.ReadLine();

            Console.Write("Nome do autor: ");
            livro.Autor = Console.ReadLine();

            Console.Write("Gênero: ");
            livro.Genero = Console.ReadLine();

            Console.Write("Ano de Lançamento: ");
            livro.Ano = int.Parse(Console.ReadLine());

            // Retorna livro preenchido
            return livro;
        }

        public static Livro InsereLivro(string titulo, string autor, string genero, int ano)
        {
            Livro livro = new Livro();

            livro.Titulo = titulo;
            livro.Autor = autor;
            livro.Genero = genero;
            livro.Ano = ano;

            return livro;
        }

        // b) Quatro funções de manutenção básicas de registros do TAD livros: Obter Autor, Título, Gênero e Ano.
        public static string RetornaTitulo(Livro livro)
        {       
            return livro.Titulo;       
        }
        public static string RetornaAutor(Livro livro)
        {
            return livro.Autor;
        }
        public static string RetornaGenero(Livro livro)
        {
            return livro.Genero;
        }
        public static int RetornaAno(Livro livro)
        {
            return livro.Ano;
        }

        // c) Duas funções para verificar a Estilo literário, sendo que estas deverão receber um Objeto do Tipo
        // Livro e retornar um Boleano com o resultado, sendo: Modernismo de 1930 a 1945 e Barroco de 1601 a 1768.
        public static Boolean VerificaModernismo(Livro livro)
        {
            if(livro.Genero.Equals("Modernismo") && (livro.Ano > 1930 && livro.Ano < 1945)) {
                return true;
            }
            return false;
        }

        public static Boolean VerificaBarroco(Livro livro)
        {
            if (livro.Genero.Equals("Barroco") && (livro.Ano > 1601 && livro.Ano < 1768))
            {
                return true;
            }
            return false;
        }
    }
}
