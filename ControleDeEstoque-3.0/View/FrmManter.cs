using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmManter : Form
    {
        public FrmManter()
        {
            InitializeComponent();
        }

        private void FrmManter_Load(object sender, EventArgs e)
        {
            this.alteraBtns(1);
        }

        private void alteraBtns(int operacao)
        {
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            btnFechar.Enabled = false;

            if (operacao == 1)//salvar
            {
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
                btnFechar.Enabled = true;
            }
            if (operacao == 2)//alterar
            {
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
                btnFechar.Enabled = true;
            }
            if (operacao == 3)//consultar
            {
                btnFechar.Enabled = true;
            }

        }

        private void FrmManter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
