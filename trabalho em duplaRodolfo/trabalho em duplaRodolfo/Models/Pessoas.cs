using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo.Models
{
    public class Pessoas : Crud
    {
        
        public Endereco Endereco { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento{ get; set; }
        public int ID { get; set; }

    }
}
