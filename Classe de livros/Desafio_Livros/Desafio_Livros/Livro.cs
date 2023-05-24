using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_Livros;

namespace Desafio_Livros
{
    public class Livro
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public string ISBN { get; set; }
        public string AnoPublicacao { get; set; }

        public string Estilo { get; set; }

        public int NumeroPag { get; set; }

        public string Pais { get; set; }


        public Livro(string titulo, string isbn) 
        { 
            Titulo = titulo;
            ISBN = isbn;
        }
    }
}
