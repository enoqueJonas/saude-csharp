using System;
using System.Collections.Generic;
using pcsharp_saude.Helpers;
using pcsharp_saude.Models;
using pcsharp_saude.Repositories;

namespace pcsharp_saude.Services;

public class ConsultaService
{
    private static ConsultaService _instance;

    public static ConsultaService Instance
    {
        get
        {
            if (_instance == null)
            {
                return _instance = new ConsultaService();
            }
            else
            {
                return _instance;
            }
        }
    }
    
    private ConsultaRepository _consultaRepository = ConsultaRepository.Instance;
    private PacienteService _pacienteService = PacienteService.Instance;
    private FuncionarioService _funcionarioService = FuncionarioService.Instance;
    private UtilizadorService _utilizadorService = UtilizadorService.Instance;

    public List<Consulta> findAll()
    {
        List<Consulta> consultas = new List<Consulta>();
        List<Dictionary<string,object>> rows = _consultaRepository.findAll();
        rows.ForEach(row =>
        {
            Consulta consulta = new Consulta();

            consulta.Id = CollectionAndDictionaryHelper.getValue<Int32>(row, "id");
            
            Int32 pacienteId = CollectionAndDictionaryHelper.getValue<Int32>(row, "paciente_id");
            consulta.Paciente = _pacienteService.findById(pacienteId);
            
            Int32 medicofuncionarioId = CollectionAndDictionaryHelper.getValue<Int32>(row, "medico_funcionario_id");
            consulta.Funcionario = _funcionarioService.findById(medicofuncionarioId);
            
            consulta.Data = CollectionAndDictionaryHelper.getValue<DateTime>(row, "data");
            consulta.Sintomas = CollectionAndDictionaryHelper.getValue<String>(row, "sintomas");
            consulta.Diagnostico = CollectionAndDictionaryHelper.getValue<String>(row, "diagnostico");
            consulta.CreatedAt = CollectionAndDictionaryHelper.getValue<DateTime>(row, "created_at");
            consulta.UpdatedAt = CollectionAndDictionaryHelper.getValue<DateTime>(row, "updated_at");
            
            Int32 createdByUtilizadorId = CollectionAndDictionaryHelper.getValue<Int32>(row, "created_by_utilizador_id");
            consulta.CreatedBy = _utilizadorService.findById(createdByUtilizadorId);
            Int32 updatedByUtilizadorId  = CollectionAndDictionaryHelper.getValue<Int32>(row, "updated_by_utilizador_id");
            consulta.UpdatedBy = _utilizadorService.findById(updatedByUtilizadorId);
            
            consultas.Add(consulta);
        });

        return consultas;
    }
    public Consulta findById(Int32 id)
    {
        return null;
    }
}