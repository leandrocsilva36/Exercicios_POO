namespace Exercicios_POO
{
    public class Usuario : IAutenticavel
    {
        public string usuario;
        //leandro
        private string senha;

        public Usuario(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha.ToLower();
        }

        public bool Autenticar(string senha)
        {
            //leandro
            //leandro = ToLower()
            //leandro = ToUpper()
            // leandro == leandro
            return this.senha == senha.ToLower();
        }
    }

    public class Admin : IAutenticavel
    {
        public string admin;
        private string senha;

        public Admin(string usuario, string senha)
        {
            this.admin = usuario;
            this.senha = senha;
        }

        public bool Autenticar(string senha)
        {
            //leandro
            //leandro = ToLower()
            //leandro = ToUpper()
            return this.senha == senha;
        }
    }
}
