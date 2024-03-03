namespace SistemaGerencial
{
    partial class Clientes
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
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATANASCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.CLIENTE,
            this.PAIS,
            this.UF,
            this.CIDADE,
            this.DATANASCIMENTO});
            this.dataGridClientes.GridColor = System.Drawing.Color.Silver;
            this.dataGridClientes.Location = new System.Drawing.Point(12, 12);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.Size = new System.Drawing.Size(1880, 787);
            this.dataGridClientes.TabIndex = 0;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "Cód";
            this.CODIGO.Name = "CODIGO";
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "CLIENTE";
            this.CLIENTE.HeaderText = "Cliente";
            this.CLIENTE.Name = "CLIENTE";
            // 
            // PAIS
            // 
            this.PAIS.DataPropertyName = "PAIS";
            this.PAIS.HeaderText = "País";
            this.PAIS.Name = "PAIS";
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "CIDADE";
            this.CIDADE.HeaderText = "Cidade";
            this.CIDADE.Name = "CIDADE";
            // 
            // DATANASCIMENTO
            // 
            this.DATANASCIMENTO.DataPropertyName = "DATANASCIMENTO";
            this.DATANASCIMENTO.HeaderText = "Data de nascimento";
            this.DATANASCIMENTO.Name = "DATANASCIMENTO";
            this.DATANASCIMENTO.Width = 125;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 811);
            this.Controls.Add(this.dataGridClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 190);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATANASCIMENTO;
    }
}