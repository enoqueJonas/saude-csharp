using pcsharp_saude.controllers;
using saude_csharp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saude_csharp.Forms
{
    public partial class frmCadastrarEspecialidade : Form
    {
        public frmCadastrarEspecialidade()
        {
            InitializeComponent();
            dataGridViewEspecialidades.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridViewEspecialidades.GridColor = ThemeColor.PrimaryColor;
            dataGridViewEspecialidades.ForeColor = Color.Black;
        }

        private static int GetCod()
        {
            ArrayList list = EspecialidadeController.Recuperar();
            int cod = 0;
            foreach (Especialidade esp in list)
            {
                if (esp.Id != 0)
                {
                    cod = esp.Id;
                }
                else
                {
                    cod = 0;
                }
            }
            return cod;
        }

        private void LimparCaixas()
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
        }

        private void SetCod()
        {
            txtId.Text = GetCod() + 1 + "";
        }

        private void Adicionar()
        {
            LimparCaixas();
            SetCod();
        }

        private void Gravar()
        {
            int id = int.Parse(txtId.Text);
            string designacao = txtNome.Text;
            int cod = 0;
            ArrayList list = EspecialidadeController.Recuperar();
            foreach (Especialidade esp in list)
            {
                if (id == esp.Id)
                {
                    cod = esp.Id;
                }
            }
            if (cod == 0)
            {
                EspecialidadeController.Gravar(id, designacao);
            }
            else
            {
                EspecialidadeController.Atualizar(id, designacao);
            }
        }

        private void Refrescar()
        {
            ArrayList list = EspecialidadeController.Recuperar();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Designação");
            foreach (Especialidade esp in list)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["ID"] = esp.Id;
                dtRow["Designação"] = esp.Designacao;
                dt.Rows.Add(dtRow);
            }
            dataGridViewEspecialidades.DataSource = dt;
            dataGridViewEspecialidades.AllowUserToAddRows = false;
            dataGridViewEspecialidades.Refresh();
            lblEstado.Visible = EstaVazio();
        }

        private Boolean EstaVazio()
        {
            return dataGridViewEspecialidades.RowCount == 0;
        }
        private void ucEspecialidade_Load(object sender, EventArgs e)
        {
            Adicionar();
            Refrescar();
            this.ActiveControl = txtNome;
        }

        private void frmCadastrarEspecialidade_Load(object sender, EventArgs e)
        {
            Refrescar();
            this.ActiveControl = txtNome;
            Adicionar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar();
            txtNome.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
            LimparCaixas();
            Refrescar();
            Adicionar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja eliminar a especialidade?", "Atenção!",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                EspecialidadeController.Remover(id);
                LimparCaixas();
                Refrescar();
                Adicionar();
            }
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        int codigoCelSelecionada;
        private void dataGridViewEspecialidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewEspecialidades.Rows[rowIndex];
            codigoCelSelecionada = int.Parse(row.Cells[0].Value.ToString());
            ArrayList list = EspecialidadeController.RecuperarComCod(codigoCelSelecionada);
            foreach (Especialidade esp in list)
            {
                txtId.Text = esp.Id + "";
                txtNome.Text = esp.Designacao;
            }
        }
    }
}
