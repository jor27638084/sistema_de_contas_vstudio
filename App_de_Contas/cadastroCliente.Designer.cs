﻿namespace App_de_Contas
{
    partial class cadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroCliente));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tp_cliente = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet1 = new App_de_Contas.ContasDataSet();
            this.label15 = new System.Windows.Forms.Label();
            this.email_cliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rg_cliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cof_cliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ie_cliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cnpj_cliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ref_cliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tel_cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cep_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uf_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cidade_cliente = new System.Windows.Forms.TextBox();
            this.bairro_cliente = new System.Windows.Forms.TextBox();
            this.address_cliente = new System.Windows.Forms.TextBox();
            this.nm_cliente = new System.Windows.Forms.TextBox();
            this.cd_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_clientesTableAdapter = new App_de_Contas.ContasDataSetTableAdapters.tb_clientesTableAdapter();
            this.impressaoDados_cliente = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(783, 630);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(127, 28);
            this.btn_sair.TabIndex = 40;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(613, 630);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(127, 28);
            this.btn_imprimir.TabIndex = 39;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(451, 630);
            this.btn_pesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(127, 28);
            this.btn_pesquisar.TabIndex = 38;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(285, 630);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(127, 28);
            this.btn_cancelar.TabIndex = 37;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(115, 630);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(127, 28);
            this.btn_salvar.TabIndex = 36;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(783, 576);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(127, 28);
            this.btn_excluir.TabIndex = 35;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(613, 576);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(127, 28);
            this.btn_alterar.TabIndex = 34;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(451, 576);
            this.btn_novo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(127, 28);
            this.btn_novo.TabIndex = 33;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(285, 576);
            this.btn_proximo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(127, 28);
            this.btn_proximo.TabIndex = 32;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(115, 576);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(127, 28);
            this.btn_anterior.TabIndex = 31;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tp_cliente);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.email_cliente);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.rg_cliente);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cof_cliente);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ie_cliente);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cnpj_cliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ref_cliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tel_cliente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cep_cliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.uf_cliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cidade_cliente);
            this.groupBox1.Controls.Add(this.bairro_cliente);
            this.groupBox1.Controls.Add(this.address_cliente);
            this.groupBox1.Controls.Add(this.nm_cliente);
            this.groupBox1.Controls.Add(this.cd_cliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(953, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // tp_cliente
            // 
            this.tp_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tp_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "sg_tipocliente", true));
            this.tp_cliente.Location = new System.Drawing.Point(220, 505);
            this.tp_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.tp_cliente.Name = "tp_cliente";
            this.tp_cliente.Size = new System.Drawing.Size(331, 30);
            this.tp_cliente.TabIndex = 30;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tb_clientes";
            this.bindingSource1.DataSource = this.contasDataSet1;
            // 
            // contasDataSet1
            // 
            this.contasDataSet1.DataSetName = "ContasDataSet";
            this.contasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(49, 508);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 24);
            this.label15.TabIndex = 29;
            this.label15.Text = "Tipo de Cliente";
            // 
            // email_cliente
            // 
            this.email_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.email_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ds_email", true));
            this.email_cliente.Location = new System.Drawing.Point(180, 465);
            this.email_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.email_cliente.Name = "email_cliente";
            this.email_cliente.Size = new System.Drawing.Size(740, 30);
            this.email_cliente.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(49, 469);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "Email";
            // 
            // rg_cliente
            // 
            this.rg_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rg_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_rg", true));
            this.rg_cliente.Location = new System.Drawing.Point(597, 426);
            this.rg_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.rg_cliente.Name = "rg_cliente";
            this.rg_cliente.Size = new System.Drawing.Size(323, 30);
            this.rg_cliente.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(524, 430);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "RG";
            // 
            // cof_cliente
            // 
            this.cof_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cof_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_cof", true));
            this.cof_cliente.Location = new System.Drawing.Point(180, 422);
            this.cof_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.cof_cliente.Name = "cof_cliente";
            this.cof_cliente.Size = new System.Drawing.Size(331, 30);
            this.cof_cliente.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 426);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "COF";
            // 
            // ie_cliente
            // 
            this.ie_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ie_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_ie", true));
            this.ie_cliente.Location = new System.Drawing.Point(597, 383);
            this.ie_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.ie_cliente.Name = "ie_cliente";
            this.ie_cliente.Size = new System.Drawing.Size(323, 30);
            this.ie_cliente.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(533, 386);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "IE";
            // 
            // cnpj_cliente
            // 
            this.cnpj_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cnpj_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_cnpj", true));
            this.cnpj_cliente.Location = new System.Drawing.Point(180, 379);
            this.cnpj_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.cnpj_cliente.Name = "cnpj_cliente";
            this.cnpj_cliente.Size = new System.Drawing.Size(331, 30);
            this.cnpj_cliente.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 383);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "CNPJ";
            // 
            // ref_cliente
            // 
            this.ref_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ref_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_contato", true));
            this.ref_cliente.Location = new System.Drawing.Point(220, 340);
            this.ref_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.ref_cliente.Name = "ref_cliente";
            this.ref_cliente.Size = new System.Drawing.Size(700, 30);
            this.ref_cliente.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 343);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Contato Referencia";
            // 
            // tel_cliente
            // 
            this.tel_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tel_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ds_telefone", true));
            this.tel_cliente.Location = new System.Drawing.Point(180, 300);
            this.tel_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.tel_cliente.Name = "tel_cliente";
            this.tel_cliente.Size = new System.Drawing.Size(740, 30);
            this.tel_cliente.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefone";
            // 
            // cep_cliente
            // 
            this.cep_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cep_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_cep", true));
            this.cep_cliente.Location = new System.Drawing.Point(475, 261);
            this.cep_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.cep_cliente.Name = "cep_cliente";
            this.cep_cliente.Size = new System.Drawing.Size(445, 30);
            this.cep_cliente.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cep";
            // 
            // uf_cliente
            // 
            this.uf_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.uf_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "sg_estado", true));
            this.uf_cliente.Location = new System.Drawing.Point(180, 257);
            this.uf_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.uf_cliente.Name = "uf_cliente";
            this.uf_cliente.Size = new System.Drawing.Size(160, 30);
            this.uf_cliente.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "UF";
            // 
            // cidade_cliente
            // 
            this.cidade_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cidade_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_cidade", true));
            this.cidade_cliente.Location = new System.Drawing.Point(180, 218);
            this.cidade_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.cidade_cliente.Name = "cidade_cliente";
            this.cidade_cliente.Size = new System.Drawing.Size(740, 30);
            this.cidade_cliente.TabIndex = 10;
            // 
            // bairro_cliente
            // 
            this.bairro_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bairro_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_bairro", true));
            this.bairro_cliente.Location = new System.Drawing.Point(180, 174);
            this.bairro_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.bairro_cliente.Name = "bairro_cliente";
            this.bairro_cliente.Size = new System.Drawing.Size(740, 30);
            this.bairro_cliente.TabIndex = 8;
            // 
            // address_cliente
            // 
            this.address_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.address_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "ds_endereco", true));
            this.address_cliente.Location = new System.Drawing.Point(180, 129);
            this.address_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.address_cliente.Name = "address_cliente";
            this.address_cliente.Size = new System.Drawing.Size(740, 30);
            this.address_cliente.TabIndex = 6;
            // 
            // nm_cliente
            // 
            this.nm_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nm_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "nm_cliente", true));
            this.nm_cliente.Location = new System.Drawing.Point(180, 85);
            this.nm_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.nm_cliente.Name = "nm_cliente";
            this.nm_cliente.Size = new System.Drawing.Size(740, 30);
            this.nm_cliente.TabIndex = 4;
            // 
            // cd_cliente
            // 
            this.cd_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cd_cliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "cd_cliente", true));
            this.cd_cliente.Location = new System.Drawing.Point(180, 41);
            this.cd_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.cd_cliente.Name = "cd_cliente";
            this.cd_cliente.Size = new System.Drawing.Size(176, 30);
            this.cd_cliente.TabIndex = 2;
            this.cd_cliente.TextChanged += new System.EventHandler(this.cd_cliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cidade";
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
            this.label4.Location = new System.Drawing.Point(49, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // tb_clientesTableAdapter
            // 
            this.tb_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // impressaoDados_cliente
            // 
            this.impressaoDados_cliente.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.impressaoDados_cliente_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.impressaoDados_cliente;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 673);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.cadastroCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cidade_cliente;
        private System.Windows.Forms.TextBox bairro_cliente;
        private System.Windows.Forms.TextBox address_cliente;
        private System.Windows.Forms.TextBox nm_cliente;
        private System.Windows.Forms.TextBox cd_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_cliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox rg_cliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cof_cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ie_cliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cnpj_cliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ref_cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tel_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cep_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uf_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tp_cliente;
        private System.Windows.Forms.Label label15;
        private ContasDataSet contasDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ContasDataSetTableAdapters.tb_clientesTableAdapter tb_clientesTableAdapter;
        private System.Drawing.Printing.PrintDocument impressaoDados_cliente;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}