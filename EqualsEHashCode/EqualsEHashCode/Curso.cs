using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EqualsEHashCode
{
    public class Curso
    {
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private IList<Aula> aulas;
        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            aulas = new List<Aula>();
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        public IList<Aluno> Alunos
        {
            get { return new ReadOnlyCollection<Aluno>(alunos.ToList()); }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public void Adiciona(Aula aula)
        {
            aulas.Add(aula);
        }

        public void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

    }
}
