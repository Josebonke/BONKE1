using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeFrotas
{
    public partial class Cad_Usu : Form
    {
        public Cad_Usu()
        {
            InitializeComponent();
        }
       
        //ainda n, olha no whats a foto q te mandei
            // eu vo abrir um forms
            /// <summary>
            ///  e ai vc viu algo
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
           


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
           
        }


        private void pic_Add_Click(object sender, EventArgs e)
        {


            try
            {

                string Conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Program Files (x86)\GeekDev\Gestao de Frotas";

                Bd command = new Bd();

                command.Cpf = Convert.ToString(txt_Cpf.Text);
                command.Nome = Convert.ToString(txt_Nome.Text);
                command.Tipo_Usu = Convert.ToString(txt_tpUsu.Text);
                command.telefone = Convert.ToString(txt_Tel.Text);
                command.Cargo = Convert.ToString(txt_Cargo.Text);
                command.Cnh = Convert.ToString(cb_cnh.Text);
                command.senha = Convert.ToString(txt_ConfirmSenha.Text);






                string sql = "Select count (*) From Cad_Usu Where Cpf = @Cpf";



                OleDbConnection conne = new OleDbConnection(Conexao);
                conne.Open();

                OleDbCommand cmd = new OleDbCommand(sql, conne);
                cmd.Parameters.AddWithValue("@Cpf", txt_Cpf.Text);
                cmd.CommandType = System.Data.CommandType.Text;

                int qtd = 0;

                qtd = (int)cmd.ExecuteScalar();







                conne.Close();










                if (qtd == 0)
                {


                    command.ins();

                    Form1 form = new Form1();
                    form.toolStripStatusLabel1.Text = "Cadastrado com sucesso";

                    if (txt_ConfirmSenha.Text != txt_Senha.Text || txt_ConfirmSenha.TextLength < 6 && txt_Senha.TextLength < 6)
                    {



                        MessageBox.Show("Senhas Não São  iguais/ Ou Estão com caracteres a menos ");


                    }

                }
                else
                {


                    MessageBox.Show("Usuário já registrado");

                }

            }
            
        
            catch(Exception erro)
            {


                MessageBox.Show(erro.Message);

            }
            
            
            }

        private void Cad_Usu_Load(object sender, EventArgs e)
        {
        }
    }
}
