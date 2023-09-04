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
    public partial class TelaCadastraAluno : Form
    {
        private List<Usuario> _usuarios;
        private List<Aluno> _alunos;
        private Professor _userLogado;
        private Aluno _alunoSelecionado;


        public TelaCadastraAluno(Usuario userLogado)  
        {
            InitializeComponent();
            
            _userLogado = (Professor)userLogado;

            try
            {
                _alunos = Usuario.BuscarUsuarios().ConvertAll(u => (Aluno)u);
            }
            catch (Exception)
            {

            }
        }

        //Método de formulario que irá configurar o dgvUsuarios

        private void ConfigurarDgvUsuarios()
        {
            dgvUsuarios.Columns.Add("Id", "Matrícula");
            dgvUsuarios.Columns.Add("Nome", "Nome");
            dgvUsuarios.Columns.Add("DtNascimento", "DataNascimento");
            dgvUsuarios.Columns.Add("DtMatricula", "Data Matrícula");
            dgvUsuarios.Columns.Add("Email", "E-Mail");
            dgvUsuarios.Columns.Add("Ativo", "Ativo");
            //-------------
            //Configuração dos alinhamentos de cada coluna do DgvUsuarios
            dgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleLeft;
            dgvUsuarios.Columns["DtNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["DtMatricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //------------
            //Configuração dos tamanhos de cada coluna do DgvUsuarios
            dgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvUsuarios.Columns["DtMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            //------------
            //Configurar tamanho em altura de colunas e linhas

            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.ColumnHeadersHeight = 35;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //Definindo uma cor para intercalar linhas
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;



        }

        //Método para carregar o DgvUsuarios com os dados da lista
        private void CarregaDgvUsuarios(List<Aluno> alunos = null)
       {
            dgvUsuarios.Rows.Clear();

            foreach (Aluno aluno in alunos == null ? _alunos : alunos)
            {
                dgvUsuarios.Rows.Add(aluno.Id, aluno.Nome,aluno.DtNascimento.ToString("dd/MM/yyyy"), aluno.DtMatricula, aluno.Email, aluno.Ativo);
                if (!aluno.Ativo)
                    dgvUsuarios.Rows[dgvUsuarios.Rows.Count-1].DefaultCellStyle.BackColor = Color.LightCoral;
                
                    
                
            }
              
       }
        //Método que limpa os cmapos da tela

        private void LimpaCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            txtEmailCadastro.Clear();
            dtpDataNascimento.Value = new DateTime(1990, 1 ,1);
            dtpDtMatricula.Value = DateTime.Now;
            ckbAtivo.Checked = true;
            dgvUsuarios.ClearSelection();
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(_userLogado.NivelAcesso != 1 )
            {
                MessageBox.Show("Você não possui permissão para cadastrar.", "Erro de permissão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           try
           {
                Aluno aluno = new Aluno(0, txtNome.Text, 
                                        dtpDataNascimento.Value, 
                                        dtpDtMatricula.Value, 
                                        txtEmailCadastro.Text, 
                                        "123", 
                                        true);
                
                aluno.Cadastrar(_alunos);
                CarregaDgvUsuarios();
           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
           }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaCadastraAluno_Load(object sender, EventArgs e)
        {
            try
            {
                ConfigurarDgvUsuarios();
                CarregaDgvUsuarios();
                LimpaCampos();
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, 
                                "Erro", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count < 1 || dgvUsuarios.SelectedRows.Count < 1)
                return;
            try
            {
                _alunoSelecionado = _alunos.Find(a => a.Id == (int)dgvUsuarios.SelectedRows[0].Cells[0].Value);
                lblId.Text = _alunoSelecionado.Id.ToString();
                txtNome.Text = _alunoSelecionado.Nome;
                txtEmailCadastro.Text = _alunoSelecionado.Email;
                dtpDataNascimento.Value = _alunoSelecionado.DtNascimento;
                dtpDtMatricula.Value = _alunoSelecionado.DtMatricula;
                ckbAtivo.Checked = _alunoSelecionado.Ativo;

                btnCadastrar.Enabled = false;
                btnAlterar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, 
                                "Erro", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                _alunoSelecionado.Nome = txtNome.Text;
                _alunoSelecionado.Email = txtEmailCadastro.Text;
                _alunoSelecionado.DtNascimento = dtpDataNascimento.Value;
                _alunoSelecionado.DtMatricula = dtpDtMatricula.Value;

                _alunoSelecionado.Alterar();
                CarregaDgvUsuarios();
                
                    
            }
            catch (Exception ex)
            {               
            
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja remover {_alunoSelecionado.Nome}?"
                                                 , "Remover Aluno"
                                                 , MessageBoxButtons.YesNo
                                                 , MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //TODO 2908 Realizar o update do ativo para 0 de quem está selecionado
                    _alunoSelecionado.Ativo = false;
                    _alunoSelecionado.Excluir();
                    CarregaDgvUsuarios();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Aluno> listaAlunosFiltrada = Aluno.Buscar(_alunos, cbbBuscar.SelectedIndex, txtBuscar.Text);
            CarregaDgvUsuarios(listaAlunosFiltrada);
            
        }
    }
}
