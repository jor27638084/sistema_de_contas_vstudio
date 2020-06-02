namespace App_de_Contas
{
    partial class cadastroUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.senha_usuario = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet1 = new App_de_Contas.ContasDataSet();
            this.login_usuario = new System.Windows.Forms.TextBox();
            this.nivel_usuario = new System.Windows.Forms.TextBox();
            this.nm_usuario = new System.Windows.Forms.TextBox();
            this.cd_usuario = new System.Windows.Forms.TextBox();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.tb_usuarioTableAdapter = new App_de_Contas.ContasDataSetTableAdapters.tb_usuarioTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.senha_usuario);
            this.groupBox1.Controls.Add(this.login_usuario);
            this.groupBox1.Controls.Add(this.nivel_usuario);
            this.groupBox1.Controls.Add(this.nm_usuario);
            this.groupBox1.Controls.Add(this.cd_usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 237);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // senha_usuario
            // 
            this.senha_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.senha_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CD_SENHA", true));
            this.senha_usuario.Location = new System.Drawing.Point(135, 177);
            this.senha_usuario.Name = "senha_usuario";
            this.senha_usuario.PasswordChar = '*';
            this.senha_usuario.Size = new System.Drawing.Size(556, 26);
            this.senha_usuario.TabIndex = 10;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tb_usuario";
            this.bindingSource1.DataSource = this.contasDataSet1;
            // 
            // contasDataSet1
            // 
            this.contasDataSet1.DataSetName = "ContasDataSet";
            this.contasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // login_usuario
            // 
            this.login_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.login_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "NM_LOGIN", true));
            this.login_usuario.Location = new System.Drawing.Point(135, 141);
            this.login_usuario.Name = "login_usuario";
            this.login_usuario.Size = new System.Drawing.Size(556, 26);
            this.login_usuario.TabIndex = 8;
            // 
            // nivel_usuario
            // 
            this.nivel_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nivel_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SG_NIVEL", true));
            this.nivel_usuario.Location = new System.Drawing.Point(135, 105);
            this.nivel_usuario.Name = "nivel_usuario";
            this.nivel_usuario.Size = new System.Drawing.Size(134, 26);
            this.nivel_usuario.TabIndex = 6;
            // 
            // nm_usuario
            // 
            this.nm_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nm_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "NM_USUARIO", true));
            this.nm_usuario.Location = new System.Drawing.Point(135, 69);
            this.nm_usuario.Name = "nm_usuario";
            this.nm_usuario.Size = new System.Drawing.Size(556, 26);
            this.nm_usuario.TabIndex = 4;
            // 
            // cd_usuario
            // 
            this.cd_usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cd_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CD_USUARIO", true));
            this.cd_usuario.Location = new System.Drawing.Point(135, 33);
            this.cd_usuario.Name = "cd_usuario";
            this.cd_usuario.Size = new System.Drawing.Size(134, 26);
            this.cd_usuario.TabIndex = 2;
            // 
            // btn_anterior
            // 
            this.btn_anterior.Location = new System.Drawing.Point(75, 276);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(95, 23);
            this.btn_anterior.TabIndex = 11;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.Location = new System.Drawing.Point(203, 276);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(95, 23);
            this.btn_proximo.TabIndex = 12;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(327, 276);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(95, 23);
            this.btn_novo.TabIndex = 13;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(449, 276);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(96, 23);
            this.btn_alterar.TabIndex = 14;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(576, 276);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(95, 23);
            this.btn_excluir.TabIndex = 15;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(75, 320);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_salvar.TabIndex = 16;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(203, 320);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(95, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(327, 320);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(95, 23);
            this.btn_pesquisar.TabIndex = 18;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(449, 320);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(95, 23);
            this.btn_imprimir.TabIndex = 19;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(576, 320);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(95, 23);
            this.btn_sair.TabIndex = 20;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 363);
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
            this.Name = "cadastroUsuario";
            this.Text = "Cadastro de Usuarios";
            this.Load += new System.EventHandler(this.cadastroUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox senha_usuario;
        private System.Windows.Forms.TextBox login_usuario;
        private System.Windows.Forms.TextBox nivel_usuario;
        private System.Windows.Forms.TextBox nm_usuario;
        private System.Windows.Forms.TextBox cd_usuario;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_sair;
        private ContasDataSet contasDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ContasDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
    }
}