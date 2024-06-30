using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.BLL
{
    class Autor
    {
        private int idautor;
        private string nomeautor;

        public int IdAutor { get => idautor; set => idautor = value; }
        public string NomeAutor { get => nomeautor; set => nomeautor = value; }
    }
}
