using System.Collections.Generic;
using System.Linq;
using Kanban.API.Data;
using Kanban.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kanban.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListController : ControllerBase
    {
        private readonly DataContext _context;

        public ListController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<List> Get()
        {
            return _context.Lists;
        }

        [HttpGet("{id}")]
        public List GetbyId(int id)
        {
            return _context.Lists.FirstOrDefault(list => list.id == id);
        }
    }
}