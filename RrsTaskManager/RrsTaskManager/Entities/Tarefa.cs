using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RrsTaskManager.Entities
{
    public class Tarefa: Generic
    {
        public string TituloTarefa { get; set; }
        public string DescricaoTarefa { get; set; }
        public Projeto Projeto { get; set; }
        public Pessoa? PessoaResponsavel { get; set; }
        public DateTime? DataInicioTarefa { get; set; }
        public DateTime? DataConclusao { get; set; }
        public StatusTarefa StatusTarefa { get; set; }
    }
}
