namespace _231465.Views
{
    partial class FrmProduto
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cbocate = new System.Windows.Forms.ComboBox();
            this.cbomar = new System.Windows.Forms.ComboBox();
            this.picPro = new System.Windows.Forms.PictureBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtCons = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(56, 36);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(157, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(56, 151);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(788, 22);
            this.txtDesc.TabIndex = 1;
            // 
            // cbocate
            // 
            this.cbocate.FormattingEnabled = true;
            this.cbocate.Location = new System.Drawing.Point(56, 236);
            this.cbocate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbocate.Name = "cbocate";
            this.cbocate.Size = new System.Drawing.Size(393, 24);
            this.cbocate.TabIndex = 2;
            this.cbocate.SelectedIndexChanged += new System.EventHandler(this.cbocate_SelectedIndexChanged);
            // 
            // cbomar
            // 
            this.cbomar.FormattingEnabled = true;
            this.cbomar.Location = new System.Drawing.Point(56, 327);
            this.cbomar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbomar.Name = "cbomar";
            this.cbomar.Size = new System.Drawing.Size(393, 24);
            this.cbomar.TabIndex = 3;
            this.cbomar.SelectedIndexChanged += new System.EventHandler(this.cbomar_SelectedIndexChanged);
            // 
            // picPro
            // 
            this.picPro.Location = new System.Drawing.Point(1212, 15);
            this.picPro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPro.Name = "picPro";
            this.picPro.Size = new System.Drawing.Size(337, 272);
            this.picPro.TabIndex = 4;
            this.picPro.TabStop = false;
            this.picPro.Click += new System.EventHandler(this.picPro_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(772, 327);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(245, 22);
            this.txtEstoque.TabIndex = 5;
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(1212, 329);
            this.txtVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(356, 22);
            this.txtVenda.TabIndex = 6;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(40, 639);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.Size = new System.Drawing.Size(963, 274);
            this.dgvProdutos.TabIndex = 7;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // txtCons
            // 
            this.txtCons.Location = new System.Drawing.Point(40, 574);
            this.txtCons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCons.Name = "txtCons";
            this.txtCons.Size = new System.Drawing.Size(605, 22);
            this.txtCons.TabIndex = 8;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(40, 446);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(116, 50);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(252, 446);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 50);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(491, 446);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 50);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(724, 446);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 50);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(959, 446);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 50);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(708, 553);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 65);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Categorias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Marcas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estoque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1208, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Valor de venda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 553);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Digite o produto para pesquisar";
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "ofdArquivo";
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 944);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtCons);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.picPro);
            this.Controls.Add(this.cbomar);
            this.Controls.Add(this.cbocate);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cbocate;
        private System.Windows.Forms.ComboBox cbomar;
        private System.Windows.Forms.PictureBox picPro;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtCons;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}