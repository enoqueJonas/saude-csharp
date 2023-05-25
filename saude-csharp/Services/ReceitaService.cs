using System;
using System.Collections.Generic;
using pcsharp_saude.Models;
using pcsharp_saude.Repositories;

namespace pcsharp_saude.Services
{
    public class ReceitaService
    {
        private static ReceitaService _instance;
        private ReceitaRepository _receitaRepository = ReceitaRepository.Instance;

        public static ReceitaService Instance
        {
            get
            {
                if (_instance == null)
                {
                    return _instance = new ReceitaService();
                }
                else
                {
                    return _instance;
                }
            }
        }
        private ConsultaService _consultaService = ConsultaService.Instance;
        private UtilizadorService _utilizadorService = UtilizadorService.Instance;


        public  List<Dictionary<string, object>> GetAllReceitas()
        {
           return  _receitaRepository.FindAll();
        }

        public Dictionary<string, object> GetReceitaById(int id)
        {
           return _receitaRepository.FindById(id);
        }

        public int CreateReceita(int? consultaId, int? createdByUtilizadorId, List<int> medicamentoIds)
        {
            return (int)_receitaRepository.Save(consultaId, createdByUtilizadorId, medicamentoIds);
        }

        public void UpdateReceita(int id, int consultaId, DateTime data, int updatedByUtilizadorId)
        {
            _receitaRepository.Update(id, consultaId, data, updatedByUtilizadorId);
        }
        public void DeleteReceita(int id)
        {
            try
            {
                _receitaRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the receita.", ex);
            }
        }
    }
}
