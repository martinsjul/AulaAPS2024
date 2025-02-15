﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaExemplo
{
    public partial class FrmCadAPS : Form
    {
        public FrmCadAPS()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarTriangulo();
        }

        private void SelecionarTriangulo()
        {
            cmbTriangulo.Visible = cmbForma.Text.Equals("Triangulo");
            lblBase.Visible = cmbForma.Text.Equals("Triangulo");
            lblAltura.Visible = cmbForma.Text.Equals("Triangulo");
            txtBase.Visible = cmbForma.Text.Equals("Triangulo");
            txtAltura.Visible = cmbForma.Text.Equals("Triangulo");
        }
    }
}
