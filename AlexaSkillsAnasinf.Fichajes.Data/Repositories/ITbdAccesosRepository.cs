using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlexaSkillsAnasinf.Fichajes.Model;

namespace AlexaSkillsAnasinf.Fichajes.Data.Repositories
{
    public interface ITbdAccesosRepository
    {
        Task<IEnumerable<TbdAccesos>> GetAllTbdAccesos();
        Task<TbdAccesos> GetTbdAccesos(string cba);
        Task<bool> InsertTbdAccesos(TbdAccesos entity);
        Task<bool> UpdateTbdAccesos(TbdAccesos entity);
        Task<bool> DeleteTbdAccesos(string cba);

    }
}
