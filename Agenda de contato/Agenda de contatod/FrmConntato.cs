using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_de_contatod
{
    public partial class FrmContatos : Form
    {
        public FrmContatos()
        {
            InitializeComponent();
        }

        private void empresarialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresarial b = new FrmEmpresarial
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            panel1.Controls.Add(b);
            b.Show();
        }

        private void FrmContato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                Close();
            }
        }

        private void FrmContatos_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente fechar o formulário?", "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta b = new FrmConsulta
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            panel1.Controls.Add(b);
            b.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPessoal a = new FrmPessoal
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            panel1.Controls.Add(a);
            a.Show();
        }
    }
} 
