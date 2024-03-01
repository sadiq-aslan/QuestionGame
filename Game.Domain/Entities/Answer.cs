using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Entities
{
    public class Answer : BaseEntity
    {
        public string Value { get; set; }
        public IsTrue IsTrue { get; set; }

        public Question Question { get; set; }
        public int QuestionId { get; set; }

    }
}
