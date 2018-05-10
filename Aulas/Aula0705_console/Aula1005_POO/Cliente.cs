namespace Aula1005_POO
{
    class Cliente
    {
        private string nome;
        private string cpf;
        
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente() { }
        public Cliente (string Nome)
        {
            Nome = nome;
        }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
