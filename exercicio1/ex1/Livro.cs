using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADLivro.ex1
{
    public class Livro
    {
        // Cria construtor vazio. ELe serva para previnir os valores nulos que são passados.
        public Livro() { }

        // Cria contrutor com valores, caso esse seja passado com argumentos.
        public Livro(string titulo, string autor, string genero, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.ano = ano;
        }

        // Define o tipo do atributo
        private String titulo;
        private String autor;
        private String genero;
        private int ano;

        // Encapsulamento. Só acessa os atributos por meio desses método públicos
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Ano { get => ano; set => ano = value; }
    }


}
