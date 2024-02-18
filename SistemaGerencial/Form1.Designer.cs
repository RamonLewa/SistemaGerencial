namespace SistemaGerencial
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripArquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.stripArquivosClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.stripArquivosEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stripArquivosSair = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.stripArquivosFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripArquivos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripArquivos
            // 
            this.stripArquivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripArquivosClientes,
            this.stripArquivosEstoque,
            this.stripArquivosFornecedores,
            this.toolStripSeparator1,
            this.stripArquivosSair});
            this.stripArquivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.stripArquivos.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stripArquivos.Name = "stripArquivos";
            this.stripArquivos.Size = new System.Drawing.Size(66, 20);
            this.stripArquivos.Text = "Arquivos";
            // 
            // stripArquivosClientes
            // 
            this.stripArquivosClientes.Name = "stripArquivosClientes";
            this.stripArquivosClientes.Size = new System.Drawing.Size(180, 22);
            this.stripArquivosClientes.Text = "Clientes";
            this.stripArquivosClientes.Click += new System.EventHandler(this.stripArquivosClientes_Click);
            // 
            // stripArquivosEstoque
            // 
            this.stripArquivosEstoque.Name = "stripArquivosEstoque";
            this.stripArquivosEstoque.Size = new System.Drawing.Size(180, 22);
            this.stripArquivosEstoque.Text = "Estoque";
            this.stripArquivosEstoque.Click += new System.EventHandler(this.stripArquivosEstoque_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // stripArquivosSair
            // 
            this.stripArquivosSair.Name = "stripArquivosSair";
            this.stripArquivosSair.Size = new System.Drawing.Size(180, 22);
            this.stripArquivosSair.Text = "Sair";
            this.stripArquivosSair.Click += new System.EventHandler(this.stripArquivosSair_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(21, 114);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(55, 16);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "Clientes";
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(130, 114);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(57, 16);
            this.lblEstoque.TabIndex = 4;
            this.lblEstoque.Text = "Estoque";
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Image = global::SistemaGerencial.Properties.Resources.pessoa_caixa;
            this.btnFornecedores.Location = new System.Drawing.Point(231, 36);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(75, 75);
            this.btnFornecedores.TabIndex = 5;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Image = global::SistemaGerencial.Properties.Resources.caixa_de_entrega;
            this.btnEstoque.Location = new System.Drawing.Point(121, 36);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(75, 75);
            this.btnEstoque.TabIndex = 3;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SistemaGerencial.Properties.Resources.cliente;
            this.button1.Location = new System.Drawing.Point(11, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedores.Location = new System.Drawing.Point(222, 114);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(92, 16);
            this.lblFornecedores.TabIndex = 6;
            this.lblFornecedores.Text = "Fornecedores";
            // 
            // stripArquivosFornecedores
            // 
            this.stripArquivosFornecedores.Name = "stripArquivosFornecedores";
            this.stripArquivosFornecedores.Size = new System.Drawing.Size(180, 22);
            this.stripArquivosFornecedores.Text = "Fornecedores";
            this.stripArquivosFornecedores.Click += new System.EventHandler(this.stripArquivosFornecedores_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1904, 151);
            this.Controls.Add(this.lblFornecedores);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sistema gerencial || Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripArquivos;
        private System.Windows.Forms.ToolStripMenuItem stripArquivosClientes;
        private System.Windows.Forms.ToolStripMenuItem stripArquivosSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.ToolStripMenuItem stripArquivosEstoque;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.ToolStripMenuItem stripArquivosFornecedores;
    }
}

