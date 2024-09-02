namespace projeto_AS
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataRegistro { get; set; }

        // Construtor padrão
        public Cliente() { }

        // Construtor para inicialização rápida
        public Cliente(int id, string nome, string cpf, string email, DateTime dataRegistro)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataRegistro = dataRegistro;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, CPF: {Cpf}, Email: {Email}, Data de Registro: {DataRegistro.ToShortDateString()}";
        }
    }
}
