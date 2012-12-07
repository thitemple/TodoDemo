using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoDemo.Models.Data
{
    public interface ITarefaRepository
    {
        List<Tarefa> Todas();
        Tarefa Salvar(Tarefa tarefa);
        void Delete(int idTarefa);
        Tarefa GetById(int id);
    }
}
