using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanban.API.Models
{
    public class List
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("position")]
        public int Position { get; set; }

        public ICollection<TaskEntity> Task { get; set; }
    }
}