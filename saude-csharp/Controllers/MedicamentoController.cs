using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pcsharp_saude.Services;

namespace pcsharp_saude.Controllers
{
    public class MedicamentoController
    {
        private readonly MedicamentoService _medicamentoService;

        public MedicamentoController()
        {
            _medicamentoService = new MedicamentoService();
        }

        public void CreateMedicamento(string nome, DateTime dataValidade, string descricao, int quantidade, int createdByUtilizadorId, int unidadeDeMedidaId)
        {
            try
            {
                int newId = _medicamentoService.CreateMedicamento(nome, dataValidade, descricao, quantidade, createdByUtilizadorId, unidadeDeMedidaId);
                MessageBox.Show("Medicamento created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the medicamento: {ex.Message}");
            }
        }

        public void UpdateMedicamento(int id, string nome, DateTime dataValidade, string descricao, int quantidade, int updatedByUtilizadorId, int unidadeDeMedidaId)
        {
            try
            {
                _medicamentoService.UpdateMedicamento(id, nome, dataValidade, descricao, quantidade, updatedByUtilizadorId, unidadeDeMedidaId);
                MessageBox.Show("Medicamento updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the medicamento: {ex.Message}");
            }
        }

        public void DeleteMedicamento(int id)
        {
            try
            {
                _medicamentoService.DeleteMedicamento(id);
                MessageBox.Show("Medicamento deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the medicamento: {ex.Message}");
            }
        }

        public List<Dictionary<string, object>> GetAllMedicamentos()
        {
            try
            {
                return _medicamentoService.GetAllMedicamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the medicamentos: {ex.Message}");
                return new List<Dictionary<string, object>>();
            }
        }

        public Dictionary<string, object> GetMedicamentoById(int id)
        {
            try
            {
                return _medicamentoService.GetMedicamentoById(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the medicamento: {ex.Message}");
                return null;
            }
        }
    }
}
