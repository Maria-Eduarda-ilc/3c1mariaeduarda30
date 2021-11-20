using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1mariaeduarda30.code.dto
{
    class telefoneDTO
    {
        private int _id;
        private string _nome;
        private string _telefone;

        //Métodos de encapsulamento (CTRL+R,E)
        public int id { get => _id; set => _id = value; }
        public object ID { get; internal set; }
        public string nome { get => _nome; set => _nome = value; }
        public string telefone { get => _telefone; set => _telefone = value; }
        public object Telefone { get; internal set; }

        internal void Inserir(telefoneDTO agrdto)
        {
            throw new NotImplementedException();
        }
    }
}
