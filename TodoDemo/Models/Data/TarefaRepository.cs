using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoDemo.Models.Data
{
    public class TarefaRepository : ITarefaRepository
    {
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        static TarefaRepository() 
        {
            _tarefas.Add(new Tarefa { IdTarefa = 1, Nome = "Comprar pão" });
            _tarefas.Add(new Tarefa { IdTarefa = 2, Nome = "Enviar documentos pelo correio" });
        }

        public List<Tarefa> Todas()
        {
            return _tarefas;
        }

        public Tarefa Salvar(Tarefa tarefa)
        {
            var idTarefa = 1;
            if (_tarefas.Any())
                idTarefa = _tarefas.Max(x => x.IdTarefa) + 1;
            tarefa.IdTarefa = idTarefa;
            _tarefas.Add(tarefa);
            return tarefa;
        }

        public void Delete(int idTarefa)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.IdTarefa == idTarefa);
            if (tarefa != null)
                _tarefas.Remove(tarefa);
        }

        public Tarefa GetById(int id)
        {
            return _tarefas.FirstOrDefault(t => t.IdTarefa == id);
        }
    }
}