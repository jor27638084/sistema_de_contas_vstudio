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
    public partial class form_pesquisa_usuario : Form
    {
        public form_pesquisa_usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void form_pesquisa_usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tb_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_usuarioTableAdapter.Fill(this.contasDataSet.tb_usuario);

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                this.tb_usuarioTableAdapter.Fill(this.contasDataSet.tb_usuario);
            }
            else
            {
                this.tb_usuarioTableAdapter.FillName(this.contasDataSet.tb_usuario, "%" + textNome.Text + "%");
            }
        }

        private void tb_usuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            cadastroUsuario.codigo = int.Parse (tb_usuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void tb_usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
