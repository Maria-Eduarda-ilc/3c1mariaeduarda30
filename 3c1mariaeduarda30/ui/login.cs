using _3c1mariaeduarda30.code.bll.loginbll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3c1mariaeduarda30.ui
{
    public partial class login : Form
    {
        private object loginBLL;

        public login()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            loginDTO.email = txtemail.Text;
            loginDTO.senha = txtsenha.Text;

            switch (loginBLL.RealizarLogin(loginDTO))
            {
                case true:
                    {

                        Forms_lojas_rede forms_lojas_rede = new Forms_lojas_rede();
                        forms_lojas_rede.ShowDialog();
                        break;
                    }

                default:
                    MessageBox.Show("Verifique o seu e-mail ou a sua senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
