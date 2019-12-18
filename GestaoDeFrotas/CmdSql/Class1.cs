using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CmdSql
{
    public class Command
    {

        public string Connection = @"Data Source=DESKTOP-8VI6180\\SQLEXPRESS;Initial Catalog=GestaoDeFrotas;Integrated Security=True";


        public string cpf;
        public string nome;
        public string cargo;
        public string tipoUsu;
        public string telefone;
        public string cnh;
        public string aviso;
        public string teste;

        public void CmdInsert()
        {


            SqlConnection conn = new SqlConnection(Connection);
            string sql = "Insert Into Cad_Usua(CPF,Nome,Cargo,Tipo_Usuario,Telefone,Cnh) " +
                "Values(@CPF,@Nome,@Cargo,@Tipo_Usuario,@Telefone,@Cnh)";

            SqlCommand comando = new SqlCommand(sql, conn);
            try
            {
                teste = "ok";


             comando.Parameters.AddWithValue("@CPF", cpf);
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.Parameters.AddWithValue("@Cargo", cargo);
            comando.Parameters.AddWithValue("@Tipo_Usuario", tipoUsu);
          
                comando.Parameters.AddWithValue("@Telefone", telefone);
             comando.Parameters.AddWithValue("@Cnh", cnh);
             comando.CommandType = System.Data.CommandType.Text;
             comando.ExecuteNonQuery();
                conn.Open();

                


                
            }

            catch(Exception erro)
            {
                aviso = "Erro :" + erro.Message;
            }

            finally
            {

                conn.Close();
            }
        }
    }
}
