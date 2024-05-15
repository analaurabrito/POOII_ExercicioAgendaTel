using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20241505_AgendaTelefonica
{
    internal class Contato
    {
        public int ID;
        public string Nome;
        public string Sobrenome;
        public string Telefone;
        public TipoTelefone Tipo;

        public Contato(int id, string nome, string sobrenome, string telefone, TipoTelefone tipo)
        {
            ID = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Tipo = tipo;
        }
    }
}
