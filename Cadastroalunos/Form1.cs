﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastroalunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);

            txtNome.Clear();
            txtCurso.Clear();

            MessageBox.Show("Aluno incluído com sucesso", "Inclusão",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            lblTotal.Text = dgvAlunos.RowCount.ToString();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.Rows.Count > 0)
            {
                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);

                MessageBox.Show("Aluno excluído com sucesso!", "Exclusão",
                                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lblTotal.Text = dgvAlunos.RowCount.ToString();
            }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlunos.RowCount > 0)
            {
                txtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnAlteracao_Click(object sender, EventArgs e)
        {
            if (txtAlteracao.Text != "")
            {
                dgvAlunos.CurrentRow.Cells[0].Value = txtAlteracao.Text;

                MessageBox.Show("Aluno Alterado com sucesso!", "Alteração",
                                           MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvAlunos.RowCount = 0;

            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
