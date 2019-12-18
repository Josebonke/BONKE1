namespace GestaoDeFrotas
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
private void InitializeComponent()
        {
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Senha_Incorrect = new System.Windows.Forms.Label();
            this.pic_Logar = new System.Windows.Forms.PictureBox();
            this.pic_Erro = new System.Windows.Forms.PictureBox();
            this.pic_Senha = new System.Windows.Forms.PictureBox();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Erro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.AccessibleDescription = "Cpf";
            this.txt_Cpf.AccessibleName = "Digite seu Cpf";
            this.txt_Cpf.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.txt_Cpf.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.txt_Cpf.Location = new System.Drawing.Point(204, 105);
            this.txt_Cpf.MaxLength = 11;
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(189, 20);
            this.txt_Cpf.TabIndex = 3;
            this.txt_Cpf.Tag = "";
            this.txt_Cpf.Text = "Digite Seu CPF ";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.ForeColor = System.Drawing.Color.Black;
            this.txt_Senha.Location = new System.Drawing.Point(204, 177);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '.';
            this.txt_Senha.Size = new System.Drawing.Size(189, 26);
            this.txt_Senha.TabIndex = 4;
            this.txt_Senha.Text = "Senha";
            // 
            // lbl_Senha_Incorrect
            // 
            this.lbl_Senha_Incorrect.AutoSize = true;
            this.lbl_Senha_Incorrect.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha_Incorrect.ForeColor = System.Drawing.Color.Red;
            this.lbl_Senha_Incorrect.Location = new System.Drawing.Point(342, 9);
            this.lbl_Senha_Incorrect.Name = "lbl_Senha_Incorrect";
            this.lbl_Senha_Incorrect.Size = new System.Drawing.Size(206, 18);
            this.lbl_Senha_Incorrect.TabIndex = 6;
            this.lbl_Senha_Incorrect.Text = "**Usuário ou Senha Inválido";
            this.lbl_Senha_Incorrect.Visible = false;
            // 
            // pic_Logar
            // 
            this.pic_Logar.Image = global::GestaoDeFrotas.Properties.Resources.enter_icon_icons_com_71207;
            this.pic_Logar.Location = new System.Drawing.Point(482, 275);
            this.pic_Logar.Name = "pic_Logar";
            this.pic_Logar.Size = new System.Drawing.Size(54, 44);
            this.pic_Logar.TabIndex = 7;
            this.pic_Logar.TabStop = false;
            this.pic_Logar.Click += new System.EventHandler(this.pic_Logar_Click);
            // 
            // pic_Erro
            // 
            this.pic_Erro.Image = global::GestaoDeFrotas.Properties.Resources.iconfinder_no_9424__2_;
            this.pic_Erro.Location = new System.Drawing.Point(377, 171);
            this.pic_Erro.Name = "pic_Erro";
            this.pic_Erro.Size = new System.Drawing.Size(32, 32);
            this.pic_Erro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Erro.TabIndex = 5;
            this.pic_Erro.TabStop = false;
            this.pic_Erro.Visible = false;
            // 
            // pic_Senha
            // 
            this.pic_Senha.Image = global::GestaoDeFrotas.Properties.Resources.iconfinder_lock_115716;
            this.pic_Senha.Location = new System.Drawing.Point(121, 152);
            this.pic_Senha.Name = "pic_Senha";
            this.pic_Senha.Size = new System.Drawing.Size(64, 64);
            this.pic_Senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_Senha.TabIndex = 2;
            this.pic_Senha.TabStop = false;
            // 
            // pic_user
            // 
            this.pic_user.Image = global::GestaoDeFrotas.Properties.Resources.iconfinder_164_Add_Contact_User_Twitter_5148767__1_;
            this.pic_user.Location = new System.Drawing.Point(121, 82);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(64, 64);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_user.TabIndex = 1;
            this.pic_user.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(548, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_Logar);
            this.Controls.Add(this.lbl_Senha_Incorrect);
            this.Controls.Add(this.pic_Erro);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Cpf);
            this.Controls.Add(this.pic_Senha);
            this.Controls.Add(this.pic_user);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Erro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_user;
        private System.Windows.Forms.PictureBox pic_Senha;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.PictureBox pic_Erro;
        private System.Windows.Forms.Label lbl_Senha_Incorrect;
        private System.Windows.Forms.PictureBox pic_Logar;
        private System.Windows.Forms.Label label1;
    }
}