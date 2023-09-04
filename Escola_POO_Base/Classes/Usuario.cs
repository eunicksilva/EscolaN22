using System;
using System.Collections.Generic;

namespace Escola_POO_Base.Classes
{

    public class Usuario
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        #endregion

        #region Construtores
        public Usuario()
        {

        }
        public Usuario(int id, string nome, DateTime dtNascimento, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            DtNascimento = dtNascimento;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }
        #endregion

        #region Metodos

        #region Antigo RealizarLogin SEM BANCO
        //public static Usuario RealizarLogin(string email, string senha, List<Usuario> usuarios)
        //{
        //    Usuario usuario = usuarios.Find(a => a.Email == email);
        //    try
        //    {
        //        if (usuario == null)
        //        {
        //            //Email é inxistente
        //            throw new Exception("Email inexistente");
        //        }
        //        else
        //        {
        //            if (usuario.Senha == senha)
        //            {
        //                if (usuario.Ativo)
        //                {
        //                    //Deu tudo certo
        //                    return usuario;
        //                }
        //                else
        //                {
        //                    //Usuário bloqueado
        //                    throw new Exception("Usuário Bloqueado");
        //                }



        //            }
        //            else
        //            {
        //                //Senha incorreta
        //                throw new Exception("Senha incorreta");
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion

        public static Usuario RealizarLogin(string email, string senha, bool tipoAcesso)
        {
            if (tipoAcesso == true)
            {

                string query = string.Format($"SELECT * FROM Aluno WHERE  Email = '{email}'");
                Conexao cn = new Conexao(query);

                Aluno usuario = new Aluno();


                //Bloco try..Catch
                try
                {
                    cn.AbrirConexao();
                    cn.dr = cn.comando.ExecuteReader(); //p/ Select! ExecuteReader()!!!

                    if (cn.dr.HasRows)
                    {
                        //Achou os dados do usuário de acordo com o E-mail pesquisado
                        while (cn.dr.Read())
                        {
                            usuario.Id = Convert.ToInt32(cn.dr[0]);
                            usuario.Nome = cn.dr[1].ToString();
                            usuario.DtNascimento = Convert.ToDateTime(cn.dr[2]);
                            usuario.DtMatricula = Convert.ToDateTime(cn.dr[3]);
                            usuario.Email = cn.dr[4].ToString();
                            usuario.Senha = cn.dr[5].ToString();
                            usuario.Ativo = Convert.ToBoolean(cn.dr[6]);
                        }

                        if (usuario.Senha == Crypto.Sha256(senha))
                        {
                            if (usuario.Ativo)
                            {
                                //Deu tudo certo
                                return usuario;
                            }
                            else
                            {
                                //Usuário bloqueado
                                throw new Exception("Usuário Bloqueado");
                            }



                        }
                        else
                        {
                            //Senha incorreta
                            throw new Exception("Senha incorreta");
                        }
                    }
                    else
                    {
                        //Não Teve retorno de linhas
                        throw new Exception("Email inexistente");
                    }



                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                string query = string.Format($"SELECT * FROM Professor WHERE  Email = '{email}'");
                Conexao cn = new Conexao(query);

                Professor usuario = new Professor();
                //Bloco try..Catch
                try
                {
                    cn.AbrirConexao();
                    cn.dr = cn.comando.ExecuteReader(); //p/ Select! ExecuteReader()!!!

                    if (cn.dr.HasRows)
                    {
                        //Achou os dados do usuário de acordo com o E-mail pesquisado
                        while (cn.dr.Read())
                        {
                            usuario.Id = Convert.ToInt32(cn.dr[0]);
                            usuario.Nome = cn.dr[1].ToString();
                            usuario.DtNascimento = Convert.ToDateTime(cn.dr[2]);
                            usuario.CPF= cn.dr[3].ToString();
                            usuario.Email = cn.dr[4].ToString();
                            usuario.Senha = cn.dr[5].ToString();
                            usuario.NivelAcesso = Convert.ToInt32(cn.dr[6]);
                            usuario.Ativo = Convert.ToBoolean(cn.dr[7]);
                        }

                        if (usuario.Senha == Crypto.Sha256(senha))
                        {
                            if (usuario.Ativo)
                            {
                                //Deu tudo certo
                                return usuario;
                            }
                            else
                            {
                                //Usuário bloqueado
                                throw new Exception("Usuário Bloqueado");
                            }



                        }
                        else
                        {
                            //Senha incorreta
                            throw new Exception("Senha incorreta");
                        }
                    }
                    else
                    {
                        //Não Teve retorno de linhas
                        throw new Exception("Email inexistente");
                    }



                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //public static List<Usuario> GerarUsuarios()
        //{
        //    List<Usuario> usuarios = new List<Usuario>();

        //    Usuario aluno1 = new Aluno(1, "Nicholas", Convert.ToDateTime("31/07/1998"), Convert.ToDateTime("20/05/2020"), "nick@gmail", "123", true);
        //    Usuario aluno2 = new Aluno(2, "Ana Clara", Convert.ToDateTime("20/04/1999"), Convert.ToDateTime("01/02/2020"), "ana@gmail", "123", true);
        //    Usuario aluno3 = new Aluno(3, "Sérgio", Convert.ToDateTime("04/07/2001"), Convert.ToDateTime("04/07/2020"), "blcksergio@gmail", "123", true);

        //    usuarios.Add(aluno1);
        //    usuarios.Add(aluno2);
        //    usuarios.Add(aluno3);


        //    Usuario professor1 = new Professor(1, "Amaro", Convert.ToDateTime("03/06/1982"), "472.364.046-12", "amaro@gmail", "123", 1, true);
        //    Usuario professor2 = new Professor(2, "Maria", Convert.ToDateTime("12/04/1978"), "374.699.214-66", "maria@gmail", "123", 1, true);
        //    Usuario professor3 = new Professor(3, "Murilo Teles", Convert.ToDateTime("21/12/1990"), "047.999.666-21", "muteles@gmail", "123", 2, true);

        //    usuarios.Add(professor1);
        //    usuarios.Add(professor2);
        //    usuarios.Add(professor3);

        //    return usuarios;
        //}

        //Este Método irá alterar a senha de um usuário que está logado
        public void AlterarSenha(string senhaAtual, string novaSenha, string confNovaSenha)
        {
            
            {
                string query = string.Format("UPDATE {0} SET Senha = '{1}' WHERE Id = {2}", this is Aluno ? "Aluno" : "Professor", Crypto.Sha256(novaSenha), Id);
                Conexao cn = new Conexao(query);

                try
                {
                    if (Senha == Crypto.Sha256(senhaAtual))
                    {
                        if (novaSenha == confNovaSenha)
                        {
                            cn.AbrirConexao();
                            cn.comando.ExecuteNonQuery();
                            Senha = novaSenha;
                        }
                        else
                        {
                            throw new Exception("Nova Senha não confere!");
                        }


                    }
                    else
                    {
                        throw new Exception("Senha atual não confere!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            

              
            }

        }

        public static List<Usuario> BuscarUsuarios()
        {
            string query = string.Format("SELECT * FROM Aluno");
            Conexao cn = new Conexao(query);

            List<Usuario> usuarios =  new List<Usuario>();

            try
            {
               cn.AbrirConexao();
               cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read()) 
                {
                    usuarios.Add(new Aluno()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),
                        DtNascimento = Convert.ToDateTime(cn.dr[2]),
                        DtMatricula = Convert.ToDateTime(cn.dr[3]),
                        Email = cn.dr[4].ToString(),
                        Senha = cn.dr[5].ToString(),
                        Ativo = Convert.ToBoolean(cn.dr[6]),
                    });
                }
                return usuarios;
            } 
            catch (Exception) 
            {
                throw;
            }
        }

        #endregion
    }

}