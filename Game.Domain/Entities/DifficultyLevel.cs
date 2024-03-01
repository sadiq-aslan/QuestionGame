using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Entities
{
    public class DifficultyLevel : BaseEntity
    {
        public string Difficulty { get; set; }

       // public int CategoryId { get; set; }

        public List<Question> Questions { get; set; }
       // public Category Category { get; set; }
    }
}
