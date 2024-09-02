namespace projeto_AS
{
    internal class Animal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int Nascimento { get; set; }

        public string Observacoes { get; set; }

        // Construtor padrão
        public Animal() { }

        // Construtor para inicialização rápida
        public Animal(int id, string nome, string apelido, int nascimento, string observacoes)
        {
            Id = id;
            Nome = nome;
            Apelido = apelido;
            Nascimento = nascimento;
            Observacoes = observacoes;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Apelido: {Apelido}, Nascimento: {Nascimento}, Observacoes {Observacoes}";
        }
    }
}

