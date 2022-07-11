using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedRain.Domain
{
    public class Entity
    {
        public Entity()
        { }
        public Entity(string type, string content, DateTime? created)
        {
            Type = type;
            ContentDesc = content;
            Created = created;
        }
        [Key]
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public string? Type { get; set; }
        public string? ContentDesc { get; set; }
    }

}
