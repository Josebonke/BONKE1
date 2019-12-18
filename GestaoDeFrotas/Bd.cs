using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace GestaoDeFrotas
{
    public class Bd
    {

        public string Conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Program Files (x86)\\GeekDev\\Gestao de Frotas";
        public string Sql;
        public string Cpf;
        public string Nome;
        public string Cargo;
        public string telefone;
        public string Tipo_Usu;
        public string Cnh;
        public string senha;
        public string res;
        public string res2;


        public string ins(string insert = "Insert into  Cad_Usu (CPF,Nome,Cargo,Tipo_Usuario,Telefone,Cnh,Senha)" +
                 " Values(@Cpf,@Nome,@Cargo,@Tipo_usua,@Telefone,@Cnh,@Senha)")
        {

            try
            {




                OleDbConnection conn = new OleDbConnection(Conexao);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(insert, conn);

                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);
                cmd.Parameters.AddWithValue("@Tipo_usua", Tipo_Usu);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Cnh", Cnh);
                cmd.Parameters.AddWithValue("@Senha", senha);

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.ExecuteNonQuery();

                conn.Close();

            }

            catch (Exception ERRO)
            {

                Cad_Usu cad = new Cad_Usu();

                System.Windows.Forms.MessageBox.Show(ERRO.Message);
            }

            
              

            
                return insert;
        }


       



    }

   

        

}

