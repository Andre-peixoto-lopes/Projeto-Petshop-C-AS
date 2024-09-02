using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_AS
{
    internal class Especies
    {
        public int id { get; set; }
        public string nome { get; set; }

        // Construtor padrão
        public Especies() { }

        // Construtor para inicialização rápida
        public Especies(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        // Método para exibir informações da espécie
        public override string ToString()
        {
            return $"ID: {id}, Nome: {nome}";
        }
    }
}
