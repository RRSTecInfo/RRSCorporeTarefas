using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RrsTaskManager.Entities
{
    public class Projeto: Generic
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public Pessoa? PessoaResponsavel { get; set; }
        public List<Pessoa> Pessoas { get; set; }
    }
}
