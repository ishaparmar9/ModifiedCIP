using NewCIPlatform.Entities.Data;
using NewCIPlatform.Entities.Models;
using NewCIPlatform.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCIPlatform.Repository.Repository
{
    public class SkillRepository : GenericRepository<TblSkill>, ISkillRepository
    {
        private readonly DbCipContext _db;
        public SkillRepository(DbCipContext db) : base(db) 
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
