using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrdenandoESomando
{
    public class Curso
    {
        private IList<Aula> aulas;
        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            aulas = new List<Aula>();
        }

        public void Adiciona(Aula aula)
        {
            aulas.Add(aula);
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
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

        public int TempoTotal
        {
            get
            {
                //int total = 0;

                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}

                //return total;

                // LINQ = Language Integrated Query
                // Consulta Integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

    }
}
