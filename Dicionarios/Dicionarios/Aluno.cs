namespace Dicionarios
{
    public class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
            {
                return false;
            }

            return nome.Equals(outro.Nome);
        }

        // Alunos são convertidos internamente no HashSet para códigos
        // Os códigos vão cair numa tabela de dispersão, também chamada de HashTable
        // A tabela de dispersão diz em que lugar o conjunto irá ficar
        // importante: rapidez da busca depende do CÓDIGO DE DISPERSÃO!
        // Dois objetos que são iguais possuem o mesmo hash code.
        // PORÉM, o contrário não é verdadeiro:
        // Dois objetos com mesmo hash codes não são necessariamente iguais!
        public override int GetHashCode()
        {
            return nome.GetHashCode();
        }

    }
}
