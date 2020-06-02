﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_Contas
{
    public partial class contasReceber : Form
    {
        private void Habilita()
        {
            cd_notaCliente.Enabled = false;
            nm_notaCliente.Enabled = true;
            id_notaCliente.Enabled = true;
            dt_emissao.Enabled = true;
            dt_vencimento.Enabled = true;
            vl_notaCliente.Enabled = true;
            dt_pagamento.Enabled = true;
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
            cd_notaCliente.Enabled = false;
            nm_notaCliente.Enabled = false;
            id_notaCliente.Enabled = false;
            dt_emissao.Enabled = false;
            dt_vencimento.Enabled = false;
            vl_notaCliente.Enabled = false;
            dt_pagamento.Enabled = false;
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
        public contasReceber()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_contas_receber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contas_receberTableAdapter.Fill(this.contasDataSet.tb_contas_receber);
            Desabilita();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_contas_receberBindingSource.EndEdit();
            tb_contas_receberTableAdapter.Update(this.contasDataSet.tb_contas_receber);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_contas_receberBindingSource.CancelEdit();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_contas_receberBindingSource.AddNew();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            tb_contas_receberBindingSource.MovePrevious();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            tb_contas_receberBindingSource.MoveNext();
        }
    }
}
