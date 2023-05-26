    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace HeroisViloes.Model.Entities
    {
        class AmigoSuper : Pessoa
        {
            private string nomeParceiro;
            private string hobby;
            private string profissao;
            //Construtor

            public AmigoSuper() : base()
            {
            nomeParceiro = "";
            hobby = "";
            profissao = "";
            }
            //Propriedades

            public string Hobby
            {
                get { return hobby; }
                set { hobby = value; }
            }

            public string Profissao
            {
                get { return profissao; }
                set { profissao = value; }
            }
            
            public string NomeParceiro
        {
            get { return nomeParceiro; }
            set { nomeParceiro = value; }
        }
        public override void calcularIdade(int anoAtual)
        {
            base.Idade = (anoAtual - base.AnoNasc) / 5;
        }
    }//amigoSuper
    }//namespace
