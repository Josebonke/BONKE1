using System;
using System.Windows.Forms;

namespace GestaoDeFrotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Mensagens env = new Mensagens();


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.F5:
                    toolStripStatusLabel1.Text = env.msgEvi();
                    break;


                case Keys.Escape:

                    DialogResult resultado;
                    resultado = MessageBox.Show("Não tem mais Solicitações a fazer?", "Atenção", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.No)
                    {

                        this.Close();
                    }
                    break;
                case Keys.Control | Keys.S:


                    Solicit.Show();

                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void Solicit_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)   
        {

            //olha whats

            /// você compilou o projeto abriu aqui em casa
            toolStripStatusLabel1.Text = env.msgEvi();

        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {





            switch (e.KeyCode)


            {

                case Keys.F5:
                    toolStripStatusLabel1.Text = env.msgEvi();
                    break;

            }

        }

        private void solicitacao_Click(object sender, EventArgs e)
        {


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void emitirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solicit.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void responderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Não tem mais Solicitações a fazer?", "Atenção", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.No)
            {

                Application.Exit();
            
            
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_Usu cad = new Cad_Usu();

            cad.Show();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        
        }
    }
}