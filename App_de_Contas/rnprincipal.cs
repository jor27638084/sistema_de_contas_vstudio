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
    
    public partial class rnprincipal : Form
    {
        
        public rnprincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroUsuario cdu = new cadastroUsuario();
            cdu.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroCliente cdc = new cadastroCliente();
            cdc.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroFornecedores cdf = new cadastroFornecedores();
            cdf.ShowDialog();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contasReceber cr = new contasReceber();
            cr.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contasPagar cp = new contasPagar();
            cp.ShowDialog();
        }
    }
}
