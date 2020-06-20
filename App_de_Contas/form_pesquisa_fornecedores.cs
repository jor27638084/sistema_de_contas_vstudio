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
    public partial class form_pesquisa_fornecedores : Form
    {
        public form_pesquisa_fornecedores()
        {
            InitializeComponent();
        }

        private void form_pesquisa_fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedoresTableAdapter.Fill(this.contasDataSet.tb_fornecedores);

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            if(textNome.Text == "")
            {
                this.tb_fornecedoresTableAdapter.Fill(this.contasDataSet.tb_fornecedores);
            }
            else
            {
                this.tb_fornecedoresTableAdapter.FillName(this.contasDataSet.tb_fornecedores, "%" + textNome.Text + "%");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            cadastroFornecedores.codigo_forn = int.Parse(tb_fornecedoresDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
