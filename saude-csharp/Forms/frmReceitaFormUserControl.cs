using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pcsharp_saude.Controllers;

namespace pcsharp_saude.Views
{
    public partial class ReceitasForm : Form
    {
        private readonly ReceitaController _receitaController;
        private readonly MedicamentoController _medicamentoController;

        public ReceitasForm()
        {
            InitializeComponent();
            _receitaController = new ReceitaController();
            _medicamentoController = new MedicamentoController();
        }

        private void ReceitasForm_Load(object sender, EventArgs e)
        {
            LoadReceitas();
            LoadMedicamentos();
        }

        private void LoadReceitas()
        {
            List<Dictionary<string, object>> receitas = _receitaController.GetAllReceitas();

            dgvReceitas.Rows.Clear();
            foreach (Dictionary<string, object> receita in receitas)
            {
                dgvReceitas.Rows.Add(
                    receita["id"],
                    receita["consulta_id"],
                    receita["created_at"],
                    receita["created_by_utilizador_id"]
                );
            }
        }

        private void LoadMedicamentos()
        {
            List<Dictionary<string, object>> medicamentos = _medicamentoController.GetAllMedicamentos();

            cmbMedicamento.DisplayMember = "nome";
            cmbMedicamento.ValueMember = "id";
            cmbMedicamento.DataSource = medicamentos;
        }

        private void dgvReceitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReceitas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvReceitas.SelectedRows[0];

                txtReceitaId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtConsultaId.Text = selectedRow.Cells["ConsultaId"].Value.ToString();
                txtCreatedByUtilizadorId.Text = selectedRow.Cells["CreatedByUtilizadorId"].Value.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int consultaId = Convert.ToInt32(txtConsultaId.Text);
            int createdByUtilizadorId = Convert.ToInt32(txtCreatedByUtilizadorId.Text);

            List<int> medicamentoIds = GetSelectedMedicamentoIds();

            _receitaController.CreateReceita(consultaId, createdByUtilizadorId, medicamentoIds);
            LoadReceitas();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int receitaId = Convert.ToInt32(txtReceitaId.Text);
            int consultaId = Convert.ToInt32(txtConsultaId.Text);
            int createdByUtilizadorId = Convert.ToInt32(txtCreatedByUtilizadorId.Text);

            List<int> medicamentoIds = GetSelectedMedicamentoIds();
            DateTime createdAt = DateTime.Now; // Get the current timestamp

            _receitaController.UpdateReceita(receitaId, consultaId, createdAt, createdByUtilizadorId);
            LoadReceitas();
            ClearForm();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int receitaId = Convert.ToInt32(txtReceitaId.Text);

            _receitaController.DeleteReceita(receitaId);
            LoadReceitas();
            ClearForm();
        }

        private List<int> GetSelectedMedicamentoIds()
        {
            List<int> selectedIds = new List<int>();
            if (cmbMedicamento.SelectedItem is Dictionary<string, object> medicamento)
            {
                selectedIds.Add(Convert.ToInt32(medicamento["id"]));
            }

            return selectedIds;
        }


        private void ClearForm()
        {
            txtReceitaId.Clear();
            txtConsultaId.Clear();
            txtCreatedByUtilizadorId.Clear();
        }
    }
}
