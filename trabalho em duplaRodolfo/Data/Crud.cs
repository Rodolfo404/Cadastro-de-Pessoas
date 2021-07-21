using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public delegate void Operations();
    class Crud
    {
        protected List<Pessoas> lista = new List<BaseModel>();
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
