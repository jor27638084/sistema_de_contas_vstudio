using System;
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
    public partial class contasPagar : Form
    {
        private void Habilita()
        {
            cd_nota.Enabled = false;
            nm_nota.Enabled = true;
            nm_fornecedor.Enabled = true;
            dt_emissao.Enabled = true;
            dt_vencimento.Enabled = true;
            vl_nota.Enabled = true;
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
            cd_nota.Enabled = false;
            nm_nota.Enabled = false;
            nm_fornecedor.Enabled = false;
            dt_emissao.Enabled = false;
            dt_vencimento.Enabled = false;
            vl_nota.Enabled = false;
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
        public contasPagar()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedoresTableAdapter.Fill(this.contasDataSet.tb_fornecedores);
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_contas_pagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contas_pagarTableAdapter.Fill(this.contasDataSet.tb_contas_pagar);
            Desabilita();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tb_contas_pagarBindingSource.EndEdit();
            tb_contas_pagarTableAdapter.Update(this.contasDataSet.tb_contas_pagar);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            tb_contas_pagarBindingSource.CancelEdit();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Habilita();
            tb_contas_pagarBindingSource.AddNew();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            tb_contas_pagarBindingSource.MovePrevious();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            tb_contas_pagarBindingSource.MoveNext();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void tb_fornecedoresBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dt_pagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void imprassao_contaspagar_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics objtImpressao = e.Graphics;
            string strDados;

            strDados = "Conta Pendente" + (char)10 + (char)10;
            objtImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Red, 50, 50);
            objtImpressao.DrawLine(new System.Drawing.Pen(Brushes.Black), 50, 100, 780, 100);

            strDados = "Código: " + cd_nota.Text + (char)10 + (char)10;
            strDados = strDados + "Nº da Conta: " + nm_nota.Text + (char)10 + (char)10;
            strDados = strDados + "Nome do Fornecedor: " + nm_fornecedor.Text + (char)10 + (char)10;
            strDados = strDados + "Data de Emissão: " + dt_emissao.Text + (char)10 + (char)10;
            strDados = strDados + "Data de Vencimento: " + dt_vencimento + (char)10 + (char)10;
            strDados = strDados + "Valor da Nota: " + vl_nota.Text + (char)10 + (char)10;
            strDados = strDados + "Data do Pagamento: " + dt_pagamento.Text + (char)10 + (char)10;

            objtImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 150);
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
