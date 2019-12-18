using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeFrotas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
           
        
            switch (keyData)
            {

                case Keys.Enter:
                   


                

                   

                    if (txt_Cpf.Text == "40895708833"&&(txt_Senha.Text=="15032016"))
                    {

                        Form1 frm1 = new Form1();

                        frm1.label4.Text = "José";

                        frm1.Show();

                        this.Hide();
                    
                    }


                    else
                    {


                        lbl_Senha_Incorrect.Visible = true;
                        pic_Erro.Visible = true;
                    }
                    
                    
                    
                    
                    break;
                
            }
            return base.ProcessCmdKey(ref msg, keyData);


        }
            
            
            private void pic_Logar_Click(object sender, EventArgs e)
        {
           

               string Conexao = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\Users\DELL\Documents\GestaoFrotas.mdb";

            OleDbConnection con = new OleDbConnection(Conexao);

                    con.Open();


                    OleDbCommand dbCommand = new OleDbCommand("Select * from Cad_Usu where Cpf = @Cpf",con);

                    dbCommand.Parameters.AddWithValue("@Cpf", txt_Cpf.Text);
                    dbCommand.CommandType = System.Data.CommandType.Text;


            OleDbDataReader reader = dbCommand.ExecuteReader();

            reader.Read();






            MessageBox.Show("Ola mundo");















            if (txt_Cpf.Text == reader.GetString(0) && (txt_Senha.Text == reader.GetString(6)))
            {
               

                Form1 form1 = new Form1();


              


                form1.label4.Text = reader.GetString(1);
                form1.textBox1.Visible = true;
                form1.menuStrip1.Visible = true;
                form1.pictureBox1.Visible = true;
                form1.pictureBox2.Visible = true;
                form1.menuStrip1.Visible = true;
                form1.txt_Assunto.Visible = true;
                form1.txt_Dest.Visible = true;
                form1.txt_Nome.Visible = true;
                form1.txt_Setor.Visible = true;
                form1.textBox1.Visible = true;
                form1.lbl_Assunto.Visible = true;
                form1.lbl_Destino.Visible = true;
                form1.lbl_Setor.Visible = true;
                form1.Show();
                this.Close();
                // cria um msgbox

                // nesse bloco

                //pronto, compilo?
                
                //sim
            }


            else
            {


                lbl_Senha_Incorrect.Visible = true;
            
                
                
                pic_Erro.Visible = true;
            }



            con.Close();





        }
    private void pictureBox4_Click(object sender, EventArgs e)
        {

            /// colo na pic_logar
          
                //zé? ta aki?

                

            
            
        }
    }
}