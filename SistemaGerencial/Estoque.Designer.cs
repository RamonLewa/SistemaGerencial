namespace SistemaGerencial
{
    partial class Estoque
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
            this.dataGridEstoque = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODBARRAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECODECUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECODEVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEstoque
            // 
            this.dataGridEstoque.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PRODUTO,
            this.CODBARRAS,
            this.FORNECEDOR,
            this.QTDE,
            this.ATIVO,
            this.PRECODECUSTO,
            this.PRECODEVENDA});
            this.dataGridEstoque.GridColor = System.Drawing.Color.Silver;
            this.dataGridEstoque.Location = new System.Drawing.Point(12, 12);
            this.dataGridEstoque.Name = "dataGridEstoque";
            this.dataGridEstoque.Size = new System.Drawing.Size(1880, 787);
            this.dataGridEstoque.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "Cód";
            this.CODIGO.Name = "CODIGO";
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "PRODUTO";
            this.PRODUTO.HeaderText = "Produto";
            this.PRODUTO.Name = "PRODUTO";
            // 
            // CODBARRAS
            // 
            this.CODBARRAS.DataPropertyName = "CODIGOBARRA";
            this.CODBARRAS.HeaderText = "Cód. Barras";
            this.CODBARRAS.Name = "CODBARRAS";
            // 
            // FORNECEDOR
            // 
            this.FORNECEDOR.DataPropertyName = "FORNECEDOR";
            this.FORNECEDOR.HeaderText = "Fornecedor";
            this.FORNECEDOR.Name = "FORNECEDOR";
            // 
            // QTDE
            // 
            this.QTDE.DataPropertyName = "QTDE";
            this.QTDE.HeaderText = "Qtde";
            this.QTDE.Name = "QTDE";
            // 
            // ATIVO
            // 
            this.ATIVO.DataPropertyName = "ATIVO";
            this.ATIVO.HeaderText = "Ativo";
            this.ATIVO.Name = "ATIVO";
            // 
            // PRECODECUSTO
            // 
            this.PRECODECUSTO.DataPropertyName = "PRECODECUSTO";
            this.PRECODECUSTO.HeaderText = "Preço de custo";
            this.PRECODECUSTO.Name = "PRECODECUSTO";
            this.PRECODECUSTO.Width = 125;
            // 
            // PRECODEVENDA
            // 
            this.PRECODEVENDA.DataPropertyName = "PRECODEVENDA";
            this.PRECODEVENDA.HeaderText = "Preço de venda";
            this.PRECODEVENDA.Name = "PRECODEVENDA";
            this.PRECODEVENDA.Width = 125;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 811);
            this.Controls.Add(this.dataGridEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 190);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estoque";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODBARRAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECODECUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECODEVENDA;
    }
}