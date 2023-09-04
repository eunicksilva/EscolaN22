﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola_POO_Base.Classes
{
    public class Aluno : Usuario
    {
        #region Propriedades 
        public DateTime DtMatricula { get; set; }
        #endregion

        #region Construtores
        public Aluno()
        {

        }
        public Aluno(int id, string nome, DateTime dtNascimento, DateTime dtMatricula, string email, string senha, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {
            DtMatricula = dtMatricula;
        }
        #endregion

        #region Métodos

        public void Cadastrar(List<Aluno> alunos)
        {
            string query = string.Format($"INSERT INTO Aluno Values ('{Nome}', '{DtNascimento}', '{DtMatricula}', '{Email}', '{Crypto.Sha256("123")}', '1')");
            query += ";SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                alunos.Add(this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }

        public void Alterar()
        {
            string query = string.Format($"UPDATE Aluno SET Nome = '{Nome}', dtNascimento = '{DtNascimento}', dtMatricula = '{DtMatricula}', Email = '{Email}' WHERE Id = {Id}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void Excluir()
        {
            string query = string.Format($"UPDATE Aluno SET Ativo = 0 WHERE Id = {Id}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();



            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }

        public static List<Aluno> Buscar(List <Aluno> alunos, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:
                    //Busca por nome

                    return alunos.Where(a => a.Nome.ToUpper().Contains(texto.ToUpper())).ToList();

                    //break; quando não for return, é obrigatório o uso do break.
                case 1:
                    //Busca por Email

                    return alunos.Where(a => a.Nome.Contains(texto)).ToList();

                    //break; quando não for return, é obrigatório o uso do break.
                case 2:
                    //Busca por matrícula (Id)

                    return alunos.Where(a => a.Id==Convert.ToInt32(texto)).ToList();

                   //break; quando não for return, é obrigatório o uso do break.
                default:
                    //Retorar a lista sem filtro

                    return alunos;
                    //break; quando não for return, é obrigatório o uso do break.
            }
        }



       
         #endregion

    }  
}

