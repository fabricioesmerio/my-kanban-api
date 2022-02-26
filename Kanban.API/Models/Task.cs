using System.ComponentModel.DataAnnotations.Schema;

namespace Kanban.API.Models
{
    public class TaskEntity
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("position")]
        public int Position { get; set; }

        [Column("list_id")]
        public int ListId { get; set; }

        public List List { get; set; }
    }
}