using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.API.Data;
using Kanban.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kanban.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {

        private readonly DataContext _context;

        public TaskController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TaskEntity> Get()
        {
            return _context.Tasks;
        }

    }
}