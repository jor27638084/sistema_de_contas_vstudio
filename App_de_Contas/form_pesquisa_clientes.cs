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
    public partial class form_pesquisa_clientes : Form
    {
        public form_pesquisa_clientes()
        {
            InitializeComponent();
        }

        private void form_pesquisa_clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clientesTableAdapter.Fill(this.contasDataSet.tb_clientes);

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            if(textNome.Text == "")
            {
                this.tb_clientesTableAdapter.Fill(this.contasDataSet.tb_clientes);
            }
            else
            {
                this.tb_clientesTableAdapter.FillName(this.contasDataSet.tb_clientes, "%" + textNome.Text + "%");
            }
        }

        private void tb_clienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            cadastroCliente.codigo_cliente = int.Parse(tb_clienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}
