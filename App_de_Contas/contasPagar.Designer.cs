namespace App_de_Contas
{
    partial class contasPagar
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
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.tb_contas_pagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet = new App_de_Contas.ContasDataSet();
            this.tb_contas_pagarTableAdapter = new App_de_Contas.ContasDataSetTableAdapters.tb_contas_pagarTableAdapter();
            this.tableAdapterManager = new App_de_Contas.ContasDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vl_nota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nm_nota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_pagamento = new System.Windows.Forms.TextBox();
            this.dt_vencimento = new System.Windows.Forms.TextBox();
            this.dt_emissao = new System.Windows.Forms.TextBox();
            this.nm_fornecedor = new System.Windows.Forms.TextBox();
            this.cd_nota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_fornecedoresTableAdapter = new App_de_Contas.ContasDataSetTableAdapters.tb_fornecedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contas_pagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(783, 412);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(127, 28);
            this.btn_sair.TabIndex = 22;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(613, 412);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(127, 28);
            this.btn_imprimir.TabIndex = 21;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(451, 412);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(127, 28);
            this.btn_pesquisar.TabIndex = 20;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(285, 412);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(127, 28);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(115, 412);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(127, 28);
            this.btn_salvar.TabIndex = 18;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(783, 358);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(127, 28);
            this.btn_excluir.TabIndex = 17;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(613, 358);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(127, 28);
            this.btn_alterar.TabIndex = 16;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(451, 358);
            this.btn_novo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(127, 28);
            this.btn_novo.TabIndex = 15;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(285, 358);
            this.btn_proximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(127, 28);
            this.btn_proximo.TabIndex = 14;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(115, 358);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(127, 28);
            this.btn_anterior.TabIndex = 13;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // tb_contas_pagarBindingSource
            // 
            this.tb_contas_pagarBindingSource.DataMember = "tb_contas_pagar";
            this.tb_contas_pagarBindingSource.DataSource = this.contasDataSet;
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "ContasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contas_pagarTableAdapter
            // 
            this.tb_contas_pagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clientesTableAdapter = null;
            this.tableAdapterManager.tb_contas_pagarTableAdapter = this.tb_contas_pagarTableAdapter;
            this.tableAdapterManager.tb_contas_receberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedoresTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = App_de_Contas.ContasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vl_nota);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nm_nota);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dt_pagamento);
            this.groupBox1.Controls.Add(this.dt_vencimento);
            this.groupBox1.Controls.Add(this.dt_emissao);
            this.groupBox1.Controls.Add(this.nm_fornecedor);
            this.groupBox1.Controls.Add(this.cd_nota);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(953, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas Fiscais Fornecedores";
            // 
            // vl_nota
            // 
            this.vl_nota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vl_nota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "vl_documento", true));
            this.vl_nota.Location = new System.Drawing.Point(180, 208);
            this.vl_nota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vl_nota.Name = "vl_nota";
            this.vl_nota.Size = new System.Drawing.Size(291, 30);
            this.vl_nota.TabIndex = 14;
            this.vl_nota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor da Nota";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // nm_nota
            // 
            this.nm_nota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nm_nota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "nm_documento", true));
            this.nm_nota.Location = new System.Drawing.Point(180, 82);
            this.nm_nota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nm_nota.Name = "nm_nota";
            this.nm_nota.Size = new System.Drawing.Size(177, 30);
            this.nm_nota.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "N° da Nota";
            // 
            // dt_pagamento
            // 
            this.dt_pagamento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dt_pagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "dt_pagamento", true));
            this.dt_pagamento.Location = new System.Drawing.Point(180, 250);
            this.dt_pagamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_pagamento.Name = "dt_pagamento";
            this.dt_pagamento.Size = new System.Drawing.Size(291, 30);
            this.dt_pagamento.TabIndex = 12;
            // 
            // dt_vencimento
            // 
            this.dt_vencimento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dt_vencimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "dt_vencimento", true));
            this.dt_vencimento.Location = new System.Drawing.Point(608, 162);
            this.dt_vencimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_vencimento.Name = "dt_vencimento";
            this.dt_vencimento.Size = new System.Drawing.Size(253, 30);
            this.dt_vencimento.TabIndex = 10;
            // 
            // dt_emissao
            // 
            this.dt_emissao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dt_emissao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "dt_emissao", true));
            this.dt_emissao.Location = new System.Drawing.Point(180, 166);
            this.dt_emissao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dt_emissao.Name = "dt_emissao";
            this.dt_emissao.Size = new System.Drawing.Size(253, 30);
            this.dt_emissao.TabIndex = 8;
            // 
            // nm_fornecedor
            // 
            this.nm_fornecedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nm_fornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedoresBindingSource, "nm_fornecedor", true));
            this.nm_fornecedor.Location = new System.Drawing.Point(180, 124);
            this.nm_fornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nm_fornecedor.Name = "nm_fornecedor";
            this.nm_fornecedor.Size = new System.Drawing.Size(740, 30);
            this.nm_fornecedor.TabIndex = 6;
            // 
            // cd_nota
            // 
            this.cd_nota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cd_nota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contas_pagarBindingSource, "cd_contas_pagar", true));
            this.cd_nota.Location = new System.Drawing.Point(180, 41);
            this.cd_nota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cd_nota.Name = "cd_nota";
            this.cd_nota.Size = new System.Drawing.Size(177, 30);
            this.cd_nota.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Emissão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data do Pagamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Vencimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Fornecedor";
            // 
            // tb_fornecedoresBindingSource
            // 
            this.tb_fornecedoresBindingSource.DataMember = "tb_fornecedores";
            this.tb_fornecedoresBindingSource.DataSource = this.contasDataSet;
            // 
            // tb_fornecedoresTableAdapter
            // 
            this.tb_fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // contasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 455);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "contasPagar";
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.contasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_contas_pagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_anterior;
        private ContasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tb_contas_pagarBindingSource;
        private ContasDataSetTableAdapters.tb_contas_pagarTableAdapter tb_contas_pagarTableAdapter;
        private ContasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox vl_nota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nm_nota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dt_pagamento;
        private System.Windows.Forms.TextBox dt_vencimento;
        private System.Windows.Forms.TextBox dt_emissao;
        private System.Windows.Forms.TextBox nm_fornecedor;
        private System.Windows.Forms.TextBox cd_nota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tb_fornecedoresBindingSource;
        private ContasDataSetTableAdapters.tb_fornecedoresTableAdapter tb_fornecedoresTableAdapter;
    }
}