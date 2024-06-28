using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RrsTaskManager.Entities
{
    public class Pessoa: Generic
    {
        public string Nome { get; set; }
        public string Sexo{ get; set; }
        public string RG { get; set; }
        public string CPF{ get; set; }
        public DateTime DataNascimento { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int NumeroEndereco { get; set; } = 0;
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; } 
        public List<Projeto> Projeto { get; set; }  
    }
}
