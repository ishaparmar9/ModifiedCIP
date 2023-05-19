using Microsoft.AspNetCore.Mvc;
using NewCIPlatform.Entities.Models;
using NewCIPlatform.Repository.Interface;
using NewCIPlatform.Services.Service;
using NewCIPlatform.Services.ServiceInterface;

namespace NewCIPlatform.Controllers
{
    public class SkillController : Controller
    {
        //private readonly DbCipContext _db;
        private readonly ISkillRepository _iSkillRepository;
        public SkillController(ISkillRepository iSkillRepository)
        {
            _iSkillRepository = iSkillRepository;
        }
    
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MissionSkills()
        {
            return View(_iSkillRepository.GetAll()); 
        }
    }
}
