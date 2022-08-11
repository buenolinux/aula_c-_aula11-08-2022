
namespace _01_AulaCSharp
{
    partial class frmAprendendo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.bntSair = new System.Windows.Forms.Button();
            this.btnCuidado = new System.Windows.Forms.Button();
            this.btnAtencao = new System.Windows.Forms.Button();
            this.btnOla = new System.Windows.Forms.Button();
            this.grpEscolha = new System.Windows.Forms.GroupBox();
            this.chkSQL = new System.Windows.Forms.CheckBox();
            this.chkCsharp = new System.Windows.Forms.CheckBox();
            this.chkMySql = new System.Windows.Forms.CheckBox();
            this.grpAprender = new System.Windows.Forms.GroupBox();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.grpCadastro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.grpEscolha.SuspendLayout();
            this.grpAprender.SuspendLayout();
            this.grpCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(216, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Aprendendo C#";
            // 
            // picFoto
            // 
            this.picFoto.Image = global::_01_AulaCSharp.Properties.Resources.csharp;
            this.picFoto.Location = new System.Drawing.Point(18, 322);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(121, 99);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 5;
            this.picFoto.TabStop = false;
            // 
            // bntSair
            // 
            this.bntSair.Image = global::_01_AulaCSharp.Properties.Resources.sair;
            this.bntSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSair.Location = new System.Drawing.Point(18, 259);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(121, 42);
            this.bntSair.TabIndex = 4;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // btnCuidado
            // 
            this.btnCuidado.Image = global::_01_AulaCSharp.Properties.Resources.cuidado;
            this.btnCuidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuidado.Location = new System.Drawing.Point(18, 202);
            this.btnCuidado.Name = "btnCuidado";
            this.btnCuidado.Size = new System.Drawing.Size(121, 42);
            this.btnCuidado.TabIndex = 3;
            this.btnCuidado.Text = "Cuidado";
            this.btnCuidado.UseVisualStyleBackColor = true;
            this.btnCuidado.Click += new System.EventHandler(this.btnCuidado_Click);
            // 
            // btnAtencao
            // 
            this.btnAtencao.Image = global::_01_AulaCSharp.Properties.Resources.atencao;
            this.btnAtencao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtencao.Location = new System.Drawing.Point(18, 145);
            this.btnAtencao.Name = "btnAtencao";
            this.btnAtencao.Size = new System.Drawing.Size(121, 42);
            this.btnAtencao.TabIndex = 2;
            this.btnAtencao.Text = "Atenção";
            this.btnAtencao.UseVisualStyleBackColor = true;
            this.btnAtencao.Click += new System.EventHandler(this.btnAtencao_Click);
            // 
            // btnOla
            // 
            this.btnOla.Image = global::_01_AulaCSharp.Properties.Resources.ola;
            this.btnOla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOla.Location = new System.Drawing.Point(18, 90);
            this.btnOla.Name = "btnOla";
            this.btnOla.Size = new System.Drawing.Size(121, 42);
            this.btnOla.TabIndex = 1;
            this.btnOla.Text = "Olá";
            this.btnOla.UseVisualStyleBackColor = true;
            this.btnOla.Click += new System.EventHandler(this.btnOla_Click);
            // 
            // grpEscolha
            // 
            this.grpEscolha.Controls.Add(this.chkMySql);
            this.grpEscolha.Controls.Add(this.chkCsharp);
            this.grpEscolha.Controls.Add(this.chkSQL);
            this.grpEscolha.Location = new System.Drawing.Point(145, 85);
            this.grpEscolha.Name = "grpEscolha";
            this.grpEscolha.Size = new System.Drawing.Size(83, 95);
            this.grpEscolha.TabIndex = 6;
            this.grpEscolha.TabStop = false;
            this.grpEscolha.Text = "Escolha";
            // 
            // chkSQL
            // 
            this.chkSQL.AutoSize = true;
            this.chkSQL.Location = new System.Drawing.Point(7, 20);
            this.chkSQL.Name = "chkSQL";
            this.chkSQL.Size = new System.Drawing.Size(47, 17);
            this.chkSQL.TabIndex = 0;
            this.chkSQL.Text = "SQL";
            this.chkSQL.UseVisualStyleBackColor = true;
            this.chkSQL.CheckedChanged += new System.EventHandler(this.chkSQL_CheckedChanged);
            // 
            // chkCsharp
            // 
            this.chkCsharp.AutoSize = true;
            this.chkCsharp.Location = new System.Drawing.Point(7, 44);
            this.chkCsharp.Name = "chkCsharp";
            this.chkCsharp.Size = new System.Drawing.Size(40, 17);
            this.chkCsharp.TabIndex = 1;
            this.chkCsharp.Text = "C#";
            this.chkCsharp.UseVisualStyleBackColor = true;
            this.chkCsharp.CheckedChanged += new System.EventHandler(this.chkCsharp_CheckedChanged);
            // 
            // chkMySql
            // 
            this.chkMySql.AutoSize = true;
            this.chkMySql.Location = new System.Drawing.Point(7, 68);
            this.chkMySql.Name = "chkMySql";
            this.chkMySql.Size = new System.Drawing.Size(61, 17);
            this.chkMySql.TabIndex = 2;
            this.chkMySql.Text = "MySQL";
            this.chkMySql.UseVisualStyleBackColor = true;
            this.chkMySql.CheckedChanged += new System.EventHandler(this.chkMySql_CheckedChanged);
            // 
            // grpAprender
            // 
            this.grpAprender.Controls.Add(this.rdbNao);
            this.grpAprender.Controls.Add(this.rdbSim);
            this.grpAprender.Location = new System.Drawing.Point(234, 90);
            this.grpAprender.Name = "grpAprender";
            this.grpAprender.Size = new System.Drawing.Size(115, 90);
            this.grpAprender.TabIndex = 7;
            this.grpAprender.TabStop = false;
            this.grpAprender.Text = "Quer aprender C#?";
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(6, 25);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 0;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rdbSim_CheckedChanged);
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(6, 53);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 1;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            this.rdbNao.CheckedChanged += new System.EventHandler(this.rdbNao_CheckedChanged);
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.txbSenha);
            this.grpCadastro.Controls.Add(this.label3);
            this.grpCadastro.Controls.Add(this.txbEmail);
            this.grpCadastro.Controls.Add(this.label2);
            this.grpCadastro.Controls.Add(this.txbNome);
            this.grpCadastro.Controls.Add(this.label1);
            this.grpCadastro.Location = new System.Drawing.Point(145, 186);
            this.grpCadastro.Name = "grpCadastro";
            this.grpCadastro.Size = new System.Drawing.Size(204, 235);
            this.grpCadastro.TabIndex = 8;
            this.grpCadastro.TabStop = false;
            this.grpCadastro.Text = "Cadasro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(10, 42);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(184, 20);
            this.txbNome.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(12, 81);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(184, 20);
            this.txbEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail:";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(12, 121);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(184, 20);
            this.txbSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // frmAprendendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.grpCadastro);
            this.Controls.Add(this.grpAprender);
            this.Controls.Add(this.grpEscolha);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.btnCuidado);
            this.Controls.Add(this.btnAtencao);
            this.Controls.Add(this.btnOla);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAprendendo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprendendo C#";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAprendendo_FormClosing);
            this.Load += new System.EventHandler(this.frmAprendendo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.grpEscolha.ResumeLayout(false);
            this.grpEscolha.PerformLayout();
            this.grpAprender.ResumeLayout(false);
            this.grpAprender.PerformLayout();
            this.grpCadastro.ResumeLayout(false);
            this.grpCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnOla;
        private System.Windows.Forms.Button btnAtencao;
        private System.Windows.Forms.Button btnCuidado;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.GroupBox grpEscolha;
        private System.Windows.Forms.CheckBox chkMySql;
        private System.Windows.Forms.CheckBox chkCsharp;
        private System.Windows.Forms.CheckBox chkSQL;
        private System.Windows.Forms.GroupBox grpAprender;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.GroupBox grpCadastro;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
    }
}

