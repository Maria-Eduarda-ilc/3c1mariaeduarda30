using _3c1mariaeduarda30.code.dal;
using _3c1mariaeduarda30.code.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1mariaeduarda30.code.bll
{
    class nomebll
    {
        acesso_banco_de_dados conexao = new acesso_banco_de_dados();
        string tabela = "tbl_nome";
        private object tellDto;

        public void Inserir(telefoneDTO telDto)
        {
            string inserir = $"insert into {tabela} values(null,'{tellDto.nome}','{tellDto.nome}";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(nomeDTO nmeDto)
        {
            string alterar = $"update {tabela} set nome = 'tellDto.nome', telefone = '{tellDto.telefone}' where id = '{tellDto.id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(tellDTO agrDto)
        {
            string excluir = $"delete from {tabela} where id = '{tellDto.ID}';";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarGerenciamento(sql);
        }

        internal static void Excluir(telefoneDTO telldto)
        {
            throw new NotImplementedException();
        }

        internal static DataTable listar()
        {
            throw new NotImplementedException();
        }
    }
}
