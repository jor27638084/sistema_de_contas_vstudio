namespace App_de_Contas
{
    partial class form_pesquisa_fornecedores
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
            this.components = new System.ComponentModel.Container();
            this.tb_fornecedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.cdfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmfornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbfornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet = new App_de_Contas.ContasDataSet();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.tb_fornecedoresTableAdapter = new App_de_Contas.ContasDataSetTableAdapters.tb_fornecedoresTableAdapter();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_fornecedoresDataGridView
            // 
            this.tb_fornecedoresDataGridView.AllowUserToAddRows = false;
            this.tb_fornecedoresDataGridView.AllowUserToDeleteRows = false;
            this.tb_fornecedoresDataGridView.AutoGenerateColumns = false;
            this.tb_fornecedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_fornecedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdfornecedorDataGridViewTextBoxColumn,
            this.nmfornecedorDataGridViewTextBoxColumn});
            this.tb_fornecedoresDataGridView.DataSource = this.tbfornecedoresBindingSource;
            this.tb_fornecedoresDataGridView.Location = new System.Drawing.Point(18, 79);
            this.tb_fornecedoresDataGridView.Name = "tb_fornecedoresDataGridView";
            this.tb_fornecedoresDataGridView.ReadOnly = true;
            this.tb_fornecedoresDataGridView.RowHeadersWidth = 51;
            this.tb_fornecedoresDataGridView.RowTemplate.Height = 24;
            this.tb_fornecedoresDataGridView.Size = new System.Drawing.Size(675, 220);
            this.tb_fornecedoresDataGridView.TabIndex = 8;
            this.tb_fornecedoresDataGridView.DoubleClick += new System.EventHandler(this.tb_usuarioDataGridView_DoubleClick);
            // 
            // cdfornecedorDataGridViewTextBoxColumn
            // 
            this.cdfornecedorDataGridViewTextBoxColumn.DataPropertyName = "cd_fornecedor";
            this.cdfornecedorDataGridViewTextBoxColumn.HeaderText = "Código Fornecedor";
            this.cdfornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cdfornecedorDataGridViewTextBoxColumn.Name = "cdfornecedorDataGridViewTextBoxColumn";
            this.cdfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.cdfornecedorDataGridViewTextBoxColumn.Width = 160;
            // 
            // nmfornecedorDataGridViewTextBoxColumn
            // 
            this.nmfornecedorDataGridViewTextBoxColumn.DataPropertyName = "nm_fornecedor";
            this.nmfornecedorDataGridViewTextBoxColumn.HeaderText = "Nome Fornecedor";
            this.nmfornecedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nmfornecedorDataGridViewTextBoxColumn.Name = "nmfornecedorDataGridViewTextBoxColumn";
            this.nmfornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nmfornecedorDataGridViewTextBoxColumn.Width = 445;
            // 
            // tbfornecedoresBindingSource
            // 
            this.tbfornecedoresBindingSource.DataMember = "tb_fornecedores";
            this.tbfornecedoresBindingSource.DataSource = this.contasDataSet;
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "ContasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.AutoSize = true;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(603, 35);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(94, 32);
            this.btn_pesquisar.TabIndex = 7;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(127, 42);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(457, 22);
            this.textNome.TabIndex = 6;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(48, 42);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(64, 25);
            this.label_nome.TabIndex = 5;
            this.label_nome.Text = "Nome";
            // 
            // tb_fornecedoresTableAdapter
            // 
            this.tb_fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // btn_sair
            // 
            this.btn_sair.AutoSize = true;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(301, 408);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(109, 30);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // form_pesquisa_fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.tb_fornecedoresDataGridView);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label_nome);
            this.Name = "form_pesquisa_fornecedores";
            this.Load += new System.EventHandler(this.form_pesquisa_fornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbfornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tb_fornecedoresDataGridView;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label_nome;
        private ContasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbfornecedoresBindingSource;
        private ContasDataSetTableAdapters.tb_fornecedoresTableAdapter tb_fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmfornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_sair;
    }
}