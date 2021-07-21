using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_em_duplaRodolfo.Models
{
    public delegate void Operations();
    public class Crud
    {
        protected List<Pessoas> lista = new List<Pessoas>();
        protected Operations createOperation;
        protected Operations readOperation;
        protected Operations updateOperation;
        protected Operations deleteOperation;

        public void Create()
        {
            createOperation();
        }
        public void Read()
        {
            readOperation();
        }
        public void Update()
        {
            updateOperation();
        }
        public void Delete()
        {
            deleteOperation();
        }
    }
}
