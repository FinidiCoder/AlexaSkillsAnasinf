using AlexaSkillsAnasinf.Fichajes.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AlexaSkillsAnasinf.Fichajes.Data.Repositories
{
    public class TbdAccesosRepository : ITbdAccesosRepository
    {
        private SqlConfiguration _sqlConfiguration;

        public TbdAccesosRepository(SqlConfiguration configuration) => _sqlConfiguration=configuration;

        protected SqlConnection dbConnection() => new SqlConnection(_sqlConfiguration.ConnectionString);

        public Task<bool> DeleteTbdAccesos(string cba)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TbdAccesos>> GetAllTbdAccesos()
        {
            throw new NotImplementedException();
        }

        public Task<TbdAccesos> GetTbdAccesos(string cba)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertTbdAccesos(TbdAccesos entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTbdAccesos(TbdAccesos entity)
        {
            throw new NotImplementedException();
        }
    }
}
