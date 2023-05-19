using NewCIPlatform.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCIPlatform.Repository.Interface
{
    public interface ISkillRepository : IGenericRepository<TblSkill> 
    {
        void Save();
    }
}
