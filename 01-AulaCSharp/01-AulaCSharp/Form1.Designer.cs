
namespace _01_AulaCSharp
{
    partial class Form1
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
            this.bntSair = new System.Windows.Forms.Button();
            this.btnCuidado = new System.Windows.Forms.Button();
            this.btnAtencao = new System.Windows.Forms.Button();
            this.btnOla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 82);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(216, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Aprendendo C#";
            // 
            // bntSair
            // 
            this.bntSair.Image = global::_01_AulaCSharp.Properties.Resources.sair;
            this.bntSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSair.Location = new System.Drawing.Point(18, 291);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(121, 42);
            this.bntSair.TabIndex = 4;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            // 
            // btnCuidado
            // 
            this.btnCuidado.Image = global::_01_AulaCSharp.Properties.Resources.cuidado;
            this.btnCuidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCuidado.Location = new System.Drawing.Point(18, 243);
            this.btnCuidado.Name = "btnCuidado";
            this.btnCuidado.Size = new System.Drawing.Size(121, 42);
            this.btnCuidado.TabIndex = 3;
            this.btnCuidado.Text = "Cuidado";
            this.btnCuidado.UseVisualStyleBackColor = true;
            // 
            // btnAtencao
            // 
            this.btnAtencao.Image = global::_01_AulaCSharp.Properties.Resources.atencao;
            this.btnAtencao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtencao.Location = new System.Drawing.Point(18, 195);
            this.btnAtencao.Name = "btnAtencao";
            this.btnAtencao.Size = new System.Drawing.Size(121, 42);
            this.btnAtencao.TabIndex = 2;
            this.btnAtencao.Text = "Atenção";
            this.btnAtencao.UseVisualStyleBackColor = true;
            // 
            // btnOla
            // 
            this.btnOla.Image = global::_01_AulaCSharp.Properties.Resources.ola;
            this.btnOla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOla.Location = new System.Drawing.Point(18, 147);
            this.btnOla.Name = "btnOla";
            this.btnOla.Size = new System.Drawing.Size(121, 42);
            this.btnOla.TabIndex = 1;
            this.btnOla.Text = "Olá";
            this.btnOla.UseVisualStyleBackColor = true;
            this.btnOla.Click += new System.EventHandler(this.btnOla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.btnCuidado);
            this.Controls.Add(this.btnAtencao);
            this.Controls.Add(this.btnOla);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnOla;
        private System.Windows.Forms.Button btnAtencao;
        private System.Windows.Forms.Button btnCuidado;
        private System.Windows.Forms.Button bntSair;
    }
}

