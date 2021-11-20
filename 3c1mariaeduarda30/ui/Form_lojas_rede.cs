using _3c1mariaeduarda30.code.bll;
using _3c1mariaeduarda30.code.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3c1mariaeduarda30
{
    public partial class Form1 : Form
    {
        nomeBLL nmebll = new nomeBLL();
        telefoneDTO telldto = new telefoneDTO();
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable DataTable { get; private set; }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            telldto.nome = txtnome.Text;
            telldto.telefone = txttelefone.Text;

            telldto.Inserir(telldto);

            MessageBox.Show("Cadastrado com sucesso!", "nome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtid.Clear();
            txtnome.Clear();
            txttelefone.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            telldto.id = int.Parse(txtid.Text);
            telldto.nome = txtnome.Text;
            telldto.telefone = txttelefone.Text;

            nmebll.editar(telldto);

            MessageBox.Show("Editado com sucesso!", "nome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtid.Clear();
            txtnome.Clear();
            txttelefone.Clear();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            telldto.ID = int.Parse(txtid.Text);

            nmebll.Excluir(telldto: telldto);

            MessageBox.Show("Editado com sucesso!", "nome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataTable = nomebll.listar();

            txtid.Clear();
            txtnome.Clear();
            txttelefone.Clear();
        }
    }
}
