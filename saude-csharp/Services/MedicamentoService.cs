using System;
using System.Collections.Generic;
using pcsharp_saude.Repositories;

namespace pcsharp_saude.Services
{
    public class MedicamentoService
    {
        private readonly MedicamentoRepository _medicamentoRepository;

        public MedicamentoService()
        {
            _medicamentoRepository = MedicamentoRepository.Instance;
        }

        public int CreateMedicamento(string nome, DateTime dataValidade, string descricao, int quantidade, int createdByUtilizadorId, int unidadeDeMedidaId)
        {
            return (int)_medicamentoRepository.Save(nome, dataValidade, descricao, quantidade, createdByUtilizadorId, unidadeDeMedidaId);
        }

        public void UpdateMedicamento(int id, string nome, DateTime dataValidade, string descricao, int quantidade, int updatedByUtilizadorId, int unidadeDeMedidaId)
        {
            _medicamentoRepository.Update(id, nome, dataValidade, descricao, quantidade, updatedByUtilizadorId, unidadeDeMedidaId);
        }

        public List<Dictionary<string, object>> GetAllMedicamentos()
        {
            return _medicamentoRepository.FindAll();
        }

        public Dictionary<string, object> GetMedicamentoById(int id)
        {
            return _medicamentoRepository.FindById(id);
        }

        public void DeleteMedicamento(int id)
        {
            _medicamentoRepository.Delete(id);
        }
    }
}
