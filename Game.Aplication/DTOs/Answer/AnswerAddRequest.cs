using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.DTOs.Answer
{
    public class AnswerAddRequest
    {
        public string answer { get; set; }
        public IsTrue IsTrue { get; set; }
        public int QuestionId { get; set; }
    }
}
