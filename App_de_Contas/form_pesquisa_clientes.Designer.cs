namespace App_de_Contas
{
    partial class form_pesquisa_clientes
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.tb_clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.contasDataSet = new App_de_Contas.ContasDataSet();
            this.tbclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clientesTableAdapter = new App_de_Contas.ContasDataSetTableAdapters.tb_clientesTableAdapter();
            this.cdclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.AutoSize = true;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(315, 395);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(109, 30);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // tb_clienteDataGridView
            // 
            this.tb_clienteDataGridView.AllowUserToAddRows = false;
            this.tb_clienteDataGridView.AllowUserToDeleteRows = false;
            this.tb_clienteDataGridView.AutoGenerateColumns = false;
            this.tb_clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdclienteDataGridViewTextBoxColumn,
            this.nmclienteDataGridViewTextBoxColumn});
            this.tb_clienteDataGridView.DataSource = this.tbclientesBindingSource;
            this.tb_clienteDataGridView.Location = new System.Drawing.Point(32, 69);
            this.tb_clienteDataGridView.Name = "tb_clienteDataGridView";
            this.tb_clienteDataGridView.ReadOnly = true;
            this.tb_clienteDataGridView.RowHeadersWidth = 51;
            this.tb_clienteDataGridView.RowTemplate.Height = 24;
            this.tb_clienteDataGridView.Size = new System.Drawing.Size(675, 220);
            this.tb_clienteDataGridView.TabIndex = 9;
            this.tb_clienteDataGridView.DoubleClick += new System.EventHandler(this.tb_clienteDataGridView_DoubleClick);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.AutoSize = true;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.Location = new System.Drawing.Point(595, 25);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(94, 32);
            this.btn_pesquisar.TabIndex = 8;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(110, 32);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(457, 22);
            this.textNome.TabIndex = 7;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(40, 32);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(64, 25);
            this.label_nome.TabIndex = 6;
            this.label_nome.Text = "Nome";
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "ContasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbclientesBindingSource
            // 
            this.tbclientesBindingSource.DataMember = "tb_clientes";
            this.tbclientesBindingSource.DataSource = this.contasDataSet;
            // 
            // tb_clientesTableAdapter
            // 
            this.tb_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // cdclienteDataGridViewTextBoxColumn
            // 
            this.cdclienteDataGridViewTextBoxColumn.DataPropertyName = "cd_cliente";
            this.cdclienteDataGridViewTextBoxColumn.HeaderText = "Código Cliente";
            this.cdclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cdclienteDataGridViewTextBoxColumn.Name = "cdclienteDataGridViewTextBoxColumn";
            this.cdclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.cdclienteDataGridViewTextBoxColumn.Width = 140;
            // 
            // nmclienteDataGridViewTextBoxColumn
            // 
            this.nmclienteDataGridViewTextBoxColumn.DataPropertyName = "nm_cliente";
            this.nmclienteDataGridViewTextBoxColumn.HeaderText = "Nome Cliente";
            this.nmclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nmclienteDataGridViewTextBoxColumn.Name = "nmclienteDataGridViewTextBoxColumn";
            this.nmclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nmclienteDataGridViewTextBoxColumn.Width = 465;
            // 
            // form_pesquisa_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.tb_clienteDataGridView);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label_nome);
            this.Name = "form_pesquisa_clientes";
            this.Load += new System.EventHandler(this.form_pesquisa_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.DataGridView tb_clienteDataGridView;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label_nome;
        private ContasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbclientesBindingSource;
        private ContasDataSetTableAdapters.tb_clientesTableAdapter tb_clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmclienteDataGridViewTextBoxColumn;
    }
}