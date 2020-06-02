﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Contas
{
    
    public partial class cadastroUsuario : Form
    {
        private void Habilita()
        {
            cd_usuario.Enabled = false;
            nm_usuario.Enabled = true;
            nivel_usuario.Enabled = true;
            login_usuario.Enabled = true;
            senha_usuario.Enabled = true;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_anterior.Enabled = false;
            btn_proximo.Enabled = false;
            btn_novo.Enabled = false;
            btn_alterar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_pesquisar.Enabled = false;
            btn_imprimir.Enabled = false;
            btn_sair.Enabled = false;

        }

        private void Desabilita()
        {
            cd_usuario.Enabled = false;
            nm_usuario.Enabled = false;
            nivel_usuario.Enabled = false;
            login_usuario.Enabled = false;
            senha_usuario.Enabled = false;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_anterior.Enabled = true;
            btn_proximo.Enabled = true;
            btn_novo.Enabled = true;
            btn_alterar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_pesquisar.Enabled = true;
            btn_imprimir.Enabled = true;
            btn_sair.Enabled = true;
        }
       
        public cadastroUsuario()
        {
            InitializeComponent();
            
        }

        private void cadastroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.contasDataSet1.tb_usuario);
            Desabilita();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Habilita();
            bindingSource1.AddNew();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            bindingSource1.EndEdit();
            tb_usuarioTableAdapter.Update(this.contasDataSet1.tb_usuario);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            bindingSource1.CancelEdit();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dadosToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tb_usuarioTableAdapter.dados(this.contasDataSet1.tb_usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }
    }
}
