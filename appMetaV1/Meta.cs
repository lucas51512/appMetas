using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appMetaV1
{
    internal class Meta
    {
        private string nome;
        private string descricao;
        private bool atingido;
        private int tempo;
        private string tarefa;

        Meta() 
        {
            nome = "Exemplo de Meta";
            descricao = "Exemplo de Descrição";
            atingido = false;
            tempo = 0;
            tarefa = "Exemplo de Tarefa";
            
        }

        Meta(string Nome, string Descricao, int Tempo, string Tarefa) 
        {
            this.nome = Nome;
            this.descricao = Descricao;
            atingido = false;
            this.tempo = Tempo;
            this.tarefa = Tarefa;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public bool Atingido
        {
            get { return atingido; }
            set { atingido = value; }
        }

        public int Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }

        public string Tarefa
        {
            get { return tarefa; }
            set { tarefa = value; }
        }

        void Imprimir() 
        {
            Console.WriteLine("Meta: " + this.nome);
        }
    }
}
