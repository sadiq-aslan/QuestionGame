using Game.Aplication.DTOs.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.DTOs.Game
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string QValue { get; set; }

        public List<AnswerDto> Answers { get; set; }
    }
}
