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
    public partial class TelaLogin : Form
    {
        //Declarar objetos na classe o torna acessível.
        //Por todos os metodos da classe.

        public TelaLogin() //Assinatura do construtor TelaLogin
        {
           InitializeComponent();

        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario userLogado = Usuario.RealizarLogin(txtUsuario.Text, txtSenha.Text, rbAluno.Checked);
              
                if (userLogado.Senha == Crypto.Sha256("123"))
                {                  
                    AlterarSenha altSenha = new AlterarSenha(userLogado);          
                    altSenha.ShowDialog();
                    txtSenha.Clear();
                    txtSenha.Focus();
                }
                else
                {  
                    TelaPrincipal tlPrincipal = new TelaPrincipal(userLogado);
                    this.Hide();
                    tlPrincipal.ShowDialog();
                    this.Show();
                    txtSenha.Clear();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                        , "Escola X"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
            }
        }


    }
}
