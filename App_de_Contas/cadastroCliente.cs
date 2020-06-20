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
    public partial class cadastroCliente : Form
    {
        public static int codigo_cliente;
        private void Habilita()
        {
            cep_cliente.Enabled = true;
            cd_cliente.Enabled = false;
            nm_cliente.Enabled = true;
            address_cliente.Enabled = true;
            bairro_cliente.Enabled = true;
            cidade_cliente.Enabled = true;
            uf_cliente.Enabled = true;
            tel_cliente.Enabled = true;
            ref_cliente.Enabled = true;
            cnpj_cliente.Enabled = true;
            ie_cliente.Enabled = true;
            cof_cliente.Enabled = true;
            rg_cliente.Enabled = true;
            email_cliente.Enabled = true;
            tp_cliente.Enabled=true;
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
            cep_cliente.Enabled = false;
            cd_cliente.Enabled = false;
            nm_cliente.Enabled = false;
            address_cliente.Enabled = false;
            bairro_cliente.Enabled = false;
            cidade_cliente.Enabled = false;
            uf_cliente.Enabled = false;
            tel_cliente.Enabled = false;
            ref_cliente.Enabled = false;
            cnpj_cliente.Enabled = false;
            ie_cliente.Enabled = false;
            cof_cliente.Enabled = false;
            rg_cliente.Enabled = false;
            email_cliente.Enabled = false;
            tp_cliente.Enabled = false;
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
        public cadastroCliente()
        {
            InitializeComponent();
        }

        private void cadastroCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tb_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clientesTableAdapter.Fill(this.contasDataSet1.tb_clientes);
            Desabilita();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_anterior_Click(object sender, EventArgs e)
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
            tb_clientesTableAdapter.Update(this.contasDataSet1.tb_clientes);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Desabilita();
            bindingSource1.CancelEdit();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            int ponteiro;
            codigo_cliente = 0;
            form_pesquisa_clientes fpc = new form_pesquisa_clientes();
            fpc.ShowDialog();
            if(codigo_cliente != 0)
            {
                ponteiro = bindingSource1.Find("cd_cliente", codigo_cliente);
                bindingSource1.Position = ponteiro;
            }
        }
    }
}
