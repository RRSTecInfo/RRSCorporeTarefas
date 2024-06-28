using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RrsTaskManager.Entities
{
    public class Generic
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao {  get; set; }
        public Usuario UsuarioCriacao { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
