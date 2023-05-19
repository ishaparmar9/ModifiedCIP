using NewCIPlatform.Repository.Interface;
using NewCIPlatform.Repository.Repository;
using NewCIPlatform.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCIPlatform.Services.Service
{
    public class SkillService<T> : ISkillService<T> where T : class
    {
        private readonly IGenericRepository<T> _iGenericRepository;
        public SkillService(IGenericRepository<T> genericRepository)
        {
            _iGenericRepository= genericRepository;
        }
        public void Create(T entity)
        {
           _iGenericRepository.Add(entity);
        }

        public void Delete(T entity)
        {
            _iGenericRepository.Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
           return _iGenericRepository.GetAll();
        }

        public T GetById(int id)
        {
            return _iGenericRepository.GetById(id);
        }

        public void Update(T entity)
        {
            _iGenericRepository.Update(entity);
        }
    }
}
