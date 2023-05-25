using System;
using System.Collections.Generic;
using System.Windows.Forms;
using pcsharp_saude.Models;
using pcsharp_saude.Services;

namespace pcsharp_saude.Controllers
{
    public class ReceitaController
    {
        private ReceitaService _receitaService = ReceitaService.Instance;

        public List<Dictionary<string, object>> GetAllReceitas()
        {
            try
            {
                return _receitaService.GetAllReceitas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving receitas: {ex.Message}");
                return new List<Dictionary<string, object>>();
            }
        }
        

        public Dictionary<string, object> GetReceitaById(int id)
        {
            try
            {
                return _receitaService.GetReceitaById(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the receita: {ex.Message}");
                return null;
            }
        }

        public int CreateReceita(int? consultaId, int? createdByUtilizadorId, List<int> medicamentoIds)
        {
            try
            {
                return _receitaService.CreateReceita(consultaId, createdByUtilizadorId, medicamentoIds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the receita: {ex.Message}");
                return -1;
            }
        }

        public void UpdateReceita(int id, int consultaId, DateTime data, int updatedByUtilizadorId)
        {
            try
            {
                _receitaService.UpdateReceita(id, consultaId, data, updatedByUtilizadorId);
                MessageBox.Show("Receita updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the receita: {ex.Message}");
            }
        }

        public void DeleteReceita(int id)
        {
            try
            {
                _receitaService.DeleteReceita(id);
                MessageBox.Show("Receita deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the receita: {ex.Message}");
            }
        }
    }
}
