namespace WFWebCrawlerDemo
{
    partial class frmWebCrawler
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
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exibicoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resposta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.Location = new System.Drawing.Point(28, 12);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(165, 31);
            this.btnAtualizarLista.TabIndex = 0;
            this.btnAtualizarLista.Text = "Atualizar Lista";
            this.btnAtualizarLista.UseMnemonic = false;
            this.btnAtualizarLista.UseVisualStyleBackColor = true;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnAtualizarLista_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Postagem,
            this.Exibicoes,
            this.Resposta,
            this.Link});
            this.dataGridView1.Location = new System.Drawing.Point(28, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 428);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 300;
            // 
            // Postagem
            // 
            this.Postagem.HeaderText = "Postagem";
            this.Postagem.Name = "Postagem";
            this.Postagem.Width = 150;
            // 
            // Exibicoes
            // 
            this.Exibicoes.HeaderText = "Exibições";
            this.Exibicoes.Name = "Exibicoes";
            // 
            // Resposta
            // 
            this.Resposta.HeaderText = "Resposta";
            this.Resposta.Name = "Resposta";
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Executando um Scrapping do Google MSDN - Perguntas e Respostas.";
            // 
            // frmWebCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAtualizarLista);
            this.Name = "frmWebCrawler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCrawlerDemo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exibicoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resposta;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.Label label1;
    }
}

