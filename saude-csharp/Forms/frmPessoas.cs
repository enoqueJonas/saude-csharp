using pcsharp_saude.controllers;
using saude_csharp.controllers;
using saude_csharp.Controllers;
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
    public partial class frmPessoas : Form
    {
        public frmPessoas()
        {
            InitializeComponent();
            LoadTheme();
            dataGridViewUsers.BackgroundColor = ThemeColor.PrimaryColor;
            btnAdicionar.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            dataGridViewUsers.ForeColor = Color.White;
            dataGridViewDoutores.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridViewDoutores.ForeColor = Color.White;
            dataGridViewPacientes.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridViewPacientes.ForeColor = Color.White;
            btnAdicionarDoutores.BackColor = ThemeColor.PrimaryColor;
            btnRemoverDoutores.BackColor = ThemeColor.PrimaryColor;
            btnRemoverPacientes.BackColor = ThemeColor.PrimaryColor;
            btnAdcionarPacientes.BackColor = ThemeColor.PrimaryColor;
        }

        private void LoadTheme() {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    Button btn = (Button)ctrl;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void Refrescar()
        {
            ArrayList list = PessoasController.Recuperar();
            MontarDataGridView(list);
        }

        public void MontarDataGridView(ArrayList list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Sexo");
            dt.Columns.Add("Telefone");
            dt.Columns.Add("Especialidade");
            ArrayList listaFunc = Controllers.FuncionariosController.Recuperar();
            ArrayList listEsp;
            foreach (Pessoa pes in list)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["ID"] = pes.Id;
                dtRow["Nome"] = pes.Name;
                dtRow["Sexo"] = pes.Sexo;
                dtRow["Telefone"] = pes.Telefone_1;
                int cod_esp = 0;
                foreach (Funcionario func in listaFunc)
                {
                    if (func.Pessoa_id == pes.Id)
                    {
                        cod_esp = func.Especialidade;
                    }
                }
                listEsp = EspecialidadeController.RecuperarComCod(cod_esp);
                foreach (Especialidade esp in listEsp)
                {
                    dtRow["Especialidade"] = esp.Designacao;
                }
                dt.Rows.Add(dtRow);
            }
            dataGridViewDoutores.DataSource = dt;
            dataGridViewDoutores.AllowUserToAddRows = false;
            dataGridViewDoutores.Refresh();
            lblEstado2.Visible = EstaVazio();
        }

        private Boolean EstaVazio()
        {
            return dataGridViewDoutores.RowCount == 0;
        }

        private void frmPessoas_Load(object sender, EventArgs e)
        {
            Refrescar();
            dataGridViewDoutores.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridViewDoutores.GridColor = ThemeColor.PrimaryColor;
            dataGridViewDoutores.ForeColor = Color.Black;
            dataGridViewPacientes.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridViewPacientes.GridColor = ThemeColor.PrimaryColor;
            dataGridViewPacientes.ForeColor = Color.Black;
            dataGridViewUsers.BackgroundColor = ThemeColor.PrimaryColor;
            dataGridViewUsers.GridColor = ThemeColor.PrimaryColor;
            dataGridViewUsers.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPageUsers_Click(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionarDoutores_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario frm = new frmCadastrarFuncionario();
            frm.Show();
        }

        int codigoCelSelecionada, rowSelected;
        private void dataGridViewDoutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewDoutores.Rows[rowIndex];
            codigoCelSelecionada = int.Parse(row.Cells[0].Value.ToString());
            ArrayList list = FuncionariosController.Recuperar(codigoCelSelecionada);
            ArrayList listaPessoa  = new ArrayList();
            frmCadastrarFuncionario frm = new frmCadastrarFuncionario();
            frm.Show();
            frm.MontarCaixasDeTexto(list, listaPessoa);
        }

        private void dataGridViewDoutores_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIndex = rowSelected;
            while (this.IsAccessible)
            {
                if (e.KeyCode == Keys.Up)
                {
                    dataGridViewDoutores.MultiSelect = false;
                    dataGridViewDoutores.Rows[rowIndex].Selected = true;
                    dataGridViewDoutores.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
                    dataGridViewDoutores.RowsDefaultCellStyle.SelectionForeColor = Color.White;
                    rowIndex--;
                }
                if (e.KeyCode == Keys.Down)
                {
                    dataGridViewDoutores.MultiSelect = false;
                    dataGridViewDoutores.Rows[rowIndex].Selected = true;
                    dataGridViewDoutores.RowsDefaultCellStyle.SelectionBackColor = Color.Blue;
                    dataGridViewDoutores.RowsDefaultCellStyle.SelectionForeColor = Color.White;
                    rowIndex++;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                rowIndex = rowSelected;
                rowSelected = rowIndex;
                DataGridViewRow row = dataGridViewDoutores.Rows[rowIndex];
                codigoCelSelecionada = int.Parse(row.Cells[0].Value.ToString());
                ArrayList list = FuncionariosController.Recuperar(codigoCelSelecionada);
                ArrayList listaPessoa = new ArrayList();
                frmCadastrarFuncionario frm = new frmCadastrarFuncionario();
                frm.Show();
                frm.MontarCaixasDeTexto(list, listaPessoa);
            }
        }

        private void dataGridViewDoutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewDoutores.Rows[rowIndex];
            codigoCelSelecionada = int.Parse(row.Cells[0].Value.ToString());
        }

        private void btnRemoverDoutores_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja eliminar o Funcionario com ID: "+codigoCelSelecionada+"?", "Atenção!",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FuncionariosController.Remover(codigoCelSelecionada);
            }
        }

        private void btnRemoverPacientes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDoutores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            rowSelected = rowIndex;
            DataGridViewRow row = dataGridViewDoutores.Rows[rowIndex];
            codigoCelSelecionada = int.Parse(row.Cells[0].Value.ToString());
        }
    }
}
