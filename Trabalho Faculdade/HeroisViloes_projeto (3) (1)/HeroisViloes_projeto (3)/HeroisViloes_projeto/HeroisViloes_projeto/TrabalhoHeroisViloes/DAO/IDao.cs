using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model.DAO
{
    interface IDao
    {
        public bool atualizar(object objeto);
        public bool excluir(object objeto);
        public bool inserir(object objeto);
        public Object consultar(object objeto);
        List<Object> consultar(string sql);
    }
}
