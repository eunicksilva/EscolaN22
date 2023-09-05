using Escola_POO_Base.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_Base.Telas
{
    /*TODO 3- Desenhar uma tela para alterar a senha.
     * Esta tela deverá contar com um campo para colocar a senha atual
     * a nova senha e confirmar a nova senha.
     * Também deverá contar com um botão para confirmar e outro para fechar.
     */
    public partial class TelaPrincipal : Form
    {
        private Usuario _userLogado;
        


        public TelaPrincipal(Usuario userLogado)
        {
            InitializeComponent();
            _userLogado = userLogado;
      
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            if (_userLogado is Professor)
            {
                Professor prof = (Professor)_userLogado;
                if (!(prof.NivelAcesso == 1))
                    tsiCadastrarAluno.Visible = false;
            }
            else
            {
                tsiCadastro.Visible = false;
            }

            /*TODO 1- Indentificar quem está logado, se é o aluno ou professor
             * Se for aluno, mostrar o perfil do "aluno"
             * no ToolStrip, assim como
             * o seu email. O mesmo deve acontecer caso seja o professor.
             */
            if (_userLogado is Aluno)
            {
                tsiCadastro.Visible = false;
                tslPerfilUserLogado.Text = "Aluno";
            }
            else
            {
                tsiCadastro.Visible = true;
                tslPerfilUserLogado.Text = "Professor";
            }


            lblTelaPrincipal.Text = $"Bem vindo(a), {_userLogado.Nome}!";
            tslNomeUserLogado.Text = _userLogado.Nome;
            tslEmailUserLogado.Text = _userLogado.Email;

            //if (_userLogado is Aluno)

            //tslPerfilUserLogado.Text = "Aluno";

            //else

            //tslPerfilUserLogado.Text = "Professor";

            tslPerfilUserLogado.Text = _userLogado is Aluno ? "Aluno" : "Professor";


            //TODO 2- Descobrir como mostrar a data e hora completa no ToolStrip.

            tslDataHora.Text = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
            tmrRelogio.Interval = 1000;
            tmrRelogio.Enabled = true;

        }

        private void tsiAlterarSenha_Click(object sender, EventArgs e)
        {
            AlterarSenha tlAlterarSenha = new AlterarSenha(_userLogado);
            tlAlterarSenha.ShowDialog();

        }


        private void tsiCadastrarAluno_Click(object sender, EventArgs e)
        {
            TelaCadastraAluno tlCadastraAluno = new TelaCadastraAluno(_userLogado);
            tlCadastraAluno.ShowDialog();

        }

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            tslDataHora.Text = DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString();
        }
    }
}
