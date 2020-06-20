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
    public partial class cadastroFornecedores : Form
    {
        public static int codigo_forn;
        private void Habilita()
        {
            cd_fornecedor.Enabled = false;
            nm_fornecedor.Enabled = true;
            address_fornecedor.Enabled = true;
            bairro_fornecedor.Enabled = true;
            cidade_fornecedor.Enabled = true;
            uf_fornecedor.Enabled = true;
            cep_fornecedor.Enabled = true;
            tel_fornecedor.Enabled = true;
            ref_fornecedor.Enabled = true;
            cnpj_fornecedor.Enabled = true;
            ie_fornecedor.Enabled = true;
            cof_fornecedor.Enabled = true;
            rg_fornecedor.Enabled = true;
            email_fornecedor.Enabled = true;
            tp_fornecedor.Enabled = true;
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
            cd_fornecedor.Enabled = false;
            nm_fornecedor.Enabled = false;
            address_fornecedor.Enabled = false;
            bairro_fornecedor.Enabled = false;
            cidade_fornecedor.Enabled = false;
            uf_fornecedor.Enabled = false;
            cep_fornecedor.Enabled = false;
            tel_fornecedor.Enabled = false;
            ref_fornecedor.Enabled = false;
            cnpj_fornecedor.Enabled = false;
            ie_fornecedor.Enabled = false;
            cof_fornecedor.Enabled = false;
            rg_fornecedor.Enabled = false;
            email_fornecedor.Enabled = false;
            tp_fornecedor.Enabled = false;
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
        public cadastroFornecedores()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastroFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tb_fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedoresTableAdapter.Fill(this.contasDataSet1.tb_fornecedores);
            Desabilita();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            bindingSource1.EndEdit();
            tb_fornecedoresTableAdapter.Update(this.contasDataSet1.tb_fornecedores);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            bindingSource1.CancelEdit();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Habilita();
            bindingSource1.AddNew();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int ponteiro = 0;
            form_pesquisa_fornecedores fpf = new form_pesquisa_fornecedores();
            fpf.ShowDialog();
            if(codigo_forn != 0)
            {
                ponteiro = bindingSource1.Find("cd_fornecedor", codigo_forn);
                bindingSource1.Position = ponteiro;
            }
        }
    }
}
