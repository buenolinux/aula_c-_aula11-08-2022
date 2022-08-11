using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_AulaCSharp
{
    public partial class frmAprendendo : Form
    {
        public frmAprendendo()
        {
            InitializeComponent();
        }

        private void btnOla_Click(object sender, EventArgs e)
        {
            //Caixa de mensagem : mensagem , título, botão e ícone
            //MessageBox.Show("Mensagem para o usuário", "Título da janela '", tipo de botão -> MessageBoxButtons.OK, Tipo de ícone -> MessageBoxIcon.Information);
            MessageBox.Show("Olá usuário, seja bem-vindo(a)!", " 'Aviso'", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmAprendendo_Load(object sender, EventArgs e)
        {

        }

        private void btnAtencao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atenção!!!\nNão falte nas aulas de C#","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void btnCuidado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuidado!!!\nNão faça cocozinho no código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
            
        }

        private void frmAprendendo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Deseja sair do program?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void chkMySql_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMySql.Checked == true)
            {
                MessageBox.Show("Você marcou o MySQL","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você desmarcou o MySQL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void chkSQL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSQL.Checked == true)
            {
                MessageBox.Show("Você marcou o SQL Server", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você desmarcou o SQL Server", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void chkCsharp_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCsharp.Checked == true)
            {
                MessageBox.Show("Você marcou o C#  ","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você desmarcou o C#  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSim.Checked == true)
            {
                MessageBox.Show("Boa escolha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNao.Checked == true)
            {
                MessageBox.Show("Puttz", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
