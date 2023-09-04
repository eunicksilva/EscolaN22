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
    public partial class AlterarSenha : Form
    {
        private Usuario _userLogado;

        //Exigir que a tela teha o usuário logado
        public AlterarSenha(Usuario userLogado)
          
        {
            InitializeComponent();
            _userLogado = userLogado;
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                _userLogado.AlterarSenha(txtSenhaAtual.Text, 
                                         txtNovaSenha.Text, 
                                         txtConfSenha.Text
                                         );
            } 
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,
                                 "erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                Close();
            }  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
