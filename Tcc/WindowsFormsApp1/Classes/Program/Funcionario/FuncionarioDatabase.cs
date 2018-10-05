using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Classes.Base;

namespace WindowsFormsApp1.Classes.Funcionario
{
    class FuncionarioDatabase
    {
        public int Salvar(FuncionarioDTO dto)
        {
            string script = @"INSERT INTO tb_Funcionario (nm_NomeFuncionario, nm_LoginFuncionario, nm_Senha) 
                                     VALUES (@nm_NomeFuncionario, @nm_LoginFuncionario, @nm_Senha)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_NomeFuncionario", dto.Nome));
            parms.Add(new MySqlParameter("nm_LoginFuncionario", dto.Login));
            parms.Add(new MySqlParameter("nm_Senha", dto.Senha));

            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }

        public List<FuncionarioDTO> Listar()
        {
            string script = @"SELECT * FROM tb_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.id = reader.GetInt32("id_Funcionario");
                dto.Nome = reader.GetString("nm_NomeFuncionario");
                dto.Login = reader.GetString("nm_LoginFuncionario");
                dto.Senha = reader.GetString("nm_Senha");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }

        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_Funcionario WHERE id_Funcionario = @id_Funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_Funcionario", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }

        public FuncionarioDTO Logar(string login, string senha)
        {
            string script = @"SELECT * FROM tb_Funcionario WHERE ds_login = @nm_LoginFuncionario AND nm_senha = @nm_senha";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_LoginFuncionario", login));
            parms.Add(new MySqlParameter("nm_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            FuncionarioDTO funcionario = null;

            if (reader.Read())
            {
                funcionario = new FuncionarioDTO();
                funcionario.id = reader.GetInt32("id_Funcionario");
                funcionario.Nome = reader.GetString("nm_NomeFuncionario");
                funcionario.Login = reader.GetString("nm_LoginFuncionario");
                funcionario.Senha = reader.GetString("nm_Senha");
                funcionario.PermissaoADM = reader.GetBoolean("bt_Permissao_ADM");
            }
            reader.Close();

            return funcionario;
        }
    }
}
